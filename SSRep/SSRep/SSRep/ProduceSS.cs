using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace SSRep
{
    public partial class ProduceSS : Form
    {
        private static string _strConnection;
        private static readonly string _path = Application.StartupPath + @"\user.Info";

        public ProduceSS()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            ConnectionToServer();
        }

        private void ConnectionToServer()
        {
            
            var connection = new SqlConnectionStringBuilder
            {
                DataSource = cbServerName.Text,
                UserID = cbLogin.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            // connection.IntegratedSecurity = true;

            _strConnection = connection.ToString();

            //create connection
            var sqlConn = new SqlConnection(_strConnection);
            try
            {
                //open connection
                sqlConn.Open();


                //get databases
                DataTable tblDatabases = sqlConn.GetSchema("Databases");

                //close connection
                sqlConn.Close();

                //add to list
                var databases = new List<String>();
                foreach (DataRow row in tblDatabases.Rows)
                {
                    String strDatabaseName = row["database_name"].ToString();

                    databases.Add(strDatabaseName);
                }

                cbDatabases.DataSource = databases;

                // writing information 
                if(chkRemember.Checked)
                    WriteUserInput();

                ReadUserInput();
            }
            catch (Exception ex)
            {
                rtbErrorMsg.Text = @"Cannot to Server: " + ex;
            }
          
        }

        private IList<string> GetServerNames()
        {
            var  serverNames = new List<String>();
            SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
            DataTable serversTable = servers.GetDataSources();

            foreach (DataRow row in serversTable.Rows)
            {
                string serverName = row[0].ToString();
                try
                {

                    if (row[1].ToString() != "")
                    {

                        serverName += "\\" + row[1].ToString();

                    }


                }
                catch{


                }
                serverNames.Add(serverName);
            }

            return serverNames;
        }

        private void ProduceSS_Load(object sender, EventArgs e)
        {
          //  cbServerName.DataSource = GetServerNames();
            ReadUserInput();
        }

        private void btProcessing_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbSelect.Checked)
                {
                    tfbProduceSS.Text = GetSelectStatement();
                }
                if (rbUpdate.Checked)
                {

                }
            }
            catch (Exception ex)
            {
                rtbErrorMsg.Text = ex.ToString();
            }
            
        }

        private IEnumerable<Table> GetColumnsName()
        {
            var columns = new List<Table>();
            string tmpCon = _strConnection + ";Database='" + cbDatabases.Text + "'" ;
            using (var connection = new SqlConnection(tmpCon))
            {
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "select c.name, s.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id "+
                            "inner join sys.schemas s on s.schema_id = t.schema_id and t.name = '" + txtTableName.Text + "' and t.type = 'U'";
                    connection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(new Table
                            {
                                SchemaName = reader.GetString(1),
                                ColumnName = reader.GetString(0)
                            });
                        }
                    }
                }
            }

            return columns;
        }

        private string GetSelectStatement()
        {
            IEnumerable<Table> columnsName = GetColumnsName();
            int i = 0;
            var enumerable = columnsName as IList<Table> ?? columnsName.ToList();

            string selectStatement = "SELECT " +"\n";
            foreach (var it in enumerable)
            {

                selectStatement += "[" + it.ColumnName + "]";
               
                if (i + 1 < enumerable.Count)
                {
                    selectStatement += ",";
                }
                i = i + 1;
                selectStatement += "\n";
                //selectStatement += "[" + it + "]";

            }
            selectStatement += " FROM [" + cbDatabases.Text + "].[" + enumerable[0].SchemaName + "].[" + txtTableName.Text + "]";

            return selectStatement;
        }

        private void WriteUserInput()
        {
            if (!File.Exists(_path))
            {
                File.Create(_path);
            }
            if (File.Exists(_path))
            {
                string content = "server:" + cbServerName.Text + ";user:" + cbLogin.Text + ";password:" + txtPassword.Text + ";isRemember:" + chkRemember.Checked;
                using (var sw = new StreamWriter(_path))
                {
                    sw.Write(content);
                }
                
                
            }
        }

        private void ReadUserInput()
        {
            if (File.Exists(_path))
            {
                string[] content = File.ReadAllText(_path).Split(Convert.ToChar(";"));
              
                foreach (var s in content)
                {
                    var tmp = s.Split(Convert.ToChar(":"));
                    if(tmp[0].ToLower()=="server")
                         cbServerName.Text =  tmp[1];
                    if(tmp[0].ToLower() == "user")
                        cbLogin.Text =tmp[1] ;
                    if(tmp[0].ToLower() == "password")
                        txtPassword.Text =  tmp[1] ;
                    if (tmp[0].ToLower() == "isremember")
                        chkRemember.Checked =  Convert.ToBoolean(tmp[1]);
                }
            }

            
        }
    }
}
