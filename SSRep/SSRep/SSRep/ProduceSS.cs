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
        private static readonly string _path = Application.StartupPath + @"\user.Info";

        public ProduceSS()
        {
            InitializeComponent();
        }

        #region "Events"   

        private void btConnect_Click(object sender, EventArgs e)
        {
            ConnectionToServer();
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
                if (rbHashColumn.Checked)
                {
                    tfbProduceSS.Text = GetSelectStatementWithHashColumns();
                }
            }
            catch (Exception ex)
            {
                rtbErrorMsg.Text = ex.ToString();
            }
            
        }
        #endregion

        #region "Methods"
       
        private void ConnectionToServer()
        {

            var sqlConnBuilder = SingleConnection.GetSqlConnectionBuilder(cbServerName.Text, cbLogin.Text, txtPassword.Text);
            // connection.IntegratedSecurity = true;

            try
            {

                using (var sqlConn = SingleConnection.GetSqlConnection(sqlConnBuilder))
                {
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

                }


                // writing information 
                if (chkRemember.Checked)
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
            var serverNames = new List<String>();
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
                catch
                {


                }
                serverNames.Add(serverName);
            }

            return serverNames;
        }

        private IEnumerable<Table> GetColumnsName()
        {
            var columns = new List<Table>();
            
            using (var connection =  SingleConnection.GetSqlConnectionToDB(cbDatabases.Text))
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

        private IEnumerable<Table> GetPrimaryKeysColumns()
        {
            var columns = new List<Table>();
          
            using (var connection = SingleConnection.GetSqlConnectionToDB(cbDatabases.Text))
            {
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "select c.ORDINAL_POSITION, c.COLUMN_NAME from INFORMATION_SCHEMA.KEY_COLUMN_USAGE c where Table_Name=" +
                          " '" + txtTableName.Text + "'";
                    connection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(new Table
                            {
                                Id = reader.GetInt16(0),
                                ColumnName = reader.GetString(1)
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

        private string Get_NK_HASH_ID_Column()
        {
            IEnumerable<Table> primaryColumns = GetPrimaryKeysColumns();
            int i = 0;
            var enumerable = primaryColumns as IList<Table> ?? primaryColumns.ToList();

            string str = "CONVERT(NVARCHAR(32), HashBytes('MD5',  " + "\n";
            foreach (var it in enumerable)
            {

                str += "ISNULL([" + it.ColumnName + "], '') ";

                if (i + 1 < enumerable.Count)
                {
                    str += " + '|' +";
                }
                i = i + 1;
                str += "\n";

            }
            str += " ), 2) AS NK_HASH_ID";

            return str;
        }

        private string Get_FULL_HASH_ID_Column()
        {
            IEnumerable<Table> primaryColumns = GetColumnsName();
            int i = 0;
            var enumerable = primaryColumns as IList<Table> ?? primaryColumns.ToList();

            string str = "CONVERT(NVARCHAR(32), HashBytes('MD5',  " + "\n";
            foreach (var it in enumerable)
            {

                str += "ISNULL([" + it.ColumnName + "], '') ";

                if (i + 1 < enumerable.Count)
                {
                    str += " + '|' +";
                }
                i = i + 1;
                str += "\n";
              

            }
            str += " ), 2) AS FULL_HASH_ID";

            return str;
        }

        private string Get_SCD1_HASH_ID_Column()
        {
            string _path_scdType1 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_1.txt";
            string[] content;
            int i = 0;
            string str =  "CONVERT(NVARCHAR(32), HashBytes('MD5',  " + "\n";
            if (File.Exists(_path_scdType1))
            {
                content = File.ReadAllText(_path_scdType1).Split(Convert.ToChar(";"));
                foreach (var item in content)
                {
                    str += "ISNULL([" + item + "], '') ";

                    if (i + 1 < content.Length)
                    {
                        str += " + '|' +";
                    }
                    i = i + 1;
                    str += "\n";
                }
            }
          
            return str;
        }

        private string Get_SCD2_HASH_ID_Column()
        {
            string _path_scdType2 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_2.txt";
            string[] content;
            int i = 0;
            string str = "CONVERT(NVARCHAR(32), HashBytes('MD5',  " + "\n";
            if (File.Exists(_path_scdType2))
            {
                content = File.ReadAllText(_path_scdType2).Split(Convert.ToChar(";"));
                foreach (var item in content)
                {
                    str += "ISNULL([" + item + "], '') ";

                    if (i + 1 < content.Length)
                    {
                        str += " + '|' +";
                    }
                    i = i + 1;
                    str += "\n";
                }
            }

            return str;
        }

        private string GetSelectStatementWithHashColumns()
        {
            IEnumerable<Table> columnsName = GetColumnsName();
            int i = 0;
            var enumerable = columnsName as IList<Table> ?? columnsName.ToList();

            string selectStatement = "SELECT \n" + Get_NK_HASH_ID_Column() + ", \n" + 
                                                   Get_FULL_HASH_ID_Column() + ", \n " + 
                                                   Get_SCD1_HASH_ID_Column() + ", \n " +
                                                   Get_SCD2_HASH_ID_Column() + ", \n ";
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
        #endregion

        private void btDefineSCDTypes_Click(object sender, EventArgs e)
        {
            var frm = new SCDTypeDefinition();
            frm.ShowDialog();
        }

    }
}
