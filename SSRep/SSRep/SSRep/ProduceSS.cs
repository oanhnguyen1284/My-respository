using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace SSRep
{
    public partial class ProduceSS : Form
    {
        private static readonly string Path = Application.StartupPath + @"\user.Info";

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
                if (rbUpdate.Checked)
                {
                    tfbProduceSS.Text = GetUpdateSatement();
                }
                if (rbLkQT.Checked)
                {
                    tfbProduceSS.Text = GetLookupQueryTemplate();
                }
                if (rbUpdateExpired.Checked)
                {
                    tfbProduceSS.Text = GetUpdateExpriedRecord();
                }
            }
            catch (Exception ex)
            {
                rtbErrorMsg.Text = ex.ToString();
            }
            
        }

        private void btDefineSCDTypes_Click(object sender, EventArgs e)
        {
            var frm = new SCDTypeDefinition();
            frm.Columns = GetColumnsName();
            frm.PKColumns = GetPrimaryKeysColumns();
            frm.ShowDialog();
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
                    connection.Close();
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
                                Id = reader.GetInt32(0),
                                ColumnName = reader.GetString(1)
                            });
                        }
                    }
                    connection.Close();
                }
              
            }
            return columns;
        }

        private IEnumerable<Table> GetColumnsNotPK()
        {
            var columns = new List<Table>();

            using (var connection = SingleConnection.GetSqlConnectionToDB(cbDatabases.Text))
            {

                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "select c.table_schema, c.COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS c where Table_Name=" +
                          " '" + txtTableName.Text + "' AND c.COLUMN_NAME NOT IN (select COLUMN_NAME from INFORMATION_SCHEMA.KEY_COLUMN_USAGE where Table_Name='" + txtTableName.Text +"')";
                    connection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(new Table
                            {
                                SchemaName = reader.GetString(0),
                                ColumnName = reader.GetString(1)
                            });
                        }
                    }
                    connection.Close();
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

        private string GetUpdateSatement()
        {
            IEnumerable<Table> columnsName = GetColumnsNotPK();
            int i = 0;
            var enumerable = columnsName as IList<Table> ?? columnsName.ToList();

         //   string updateStatement = "UPDATE [" + cbDatabases.Text + "].[" + enumerable[0].SchemaName + "].[" + txtTableName.Text + "]\n SET " ;
            var updateStatement = new StringBuilder();
             updateStatement.Append("UPDATE [SAP].[" + txtTableName.Text + "]\n SET ");
            foreach (var it in enumerable)
            {

                updateStatement.Append("[" + it.ColumnName + "]=?");

                if (i + 1 < enumerable.Count)
                {
                    updateStatement.Append(",");
                }
                i = i + 1;
                updateStatement.Append("\n");
                //selectStatement += "[" + it + "]";

            }
            updateStatement.Append(", [AUDIT_LAST_UPDATED_DTM] = ? WHERE ");

            var columnsPKName = GetPrimaryKeysColumns().ToList();
            i = 0;
            foreach (var cl in columnsPKName)
            {
                updateStatement.Append("[" + cl.ColumnName + "]=?");
                if (i + 1 < columnsPKName.Count)
                {
                    updateStatement.Append(" AND ");
                }
                i = i + 1;
                updateStatement.Append("\n");
            }
            updateStatement.Append(" AND ? = 'TRUE'");
            return updateStatement.ToString();
        }

        private void WriteUserInput()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
            if (File.Exists(Path))
            {
                string content = "server:" + cbServerName.Text + ";user:" + cbLogin.Text + ";password:" + txtPassword.Text + ";isRemember:" + chkRemember.Checked;
                using (var sw = new StreamWriter(Path))
                {
                    sw.Write(content);
                }
                
                
            }
        }

        private void ReadUserInput()
        {
            if (File.Exists(Path))
            {
                string[] content = File.ReadAllText(Path).Split(Convert.ToChar(";"));
              
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
            string pathSCDType1 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_1.txt";
            int i = 0;
            string str =  "CONVERT(NVARCHAR(32), HashBytes('MD5',  " + "\n";
            if (File.Exists(pathSCDType1))
            {
                string[] content = File.ReadAllText(pathSCDType1).Split(Convert.ToChar(";"));
                foreach (var item in content)
                {
                    str += "ISNULL([" + item.Trim() + "], '') ";

                    if (i + 1 < content.Length)
                    {
                        str += " + '|' +";
                    }
                    i = i + 1;
                    str += "\n";
                }
            }
            str += " ), 2) AS SCD1_HASH_ID";
            return str;
        }

        private string Get_SCD2_HASH_ID_Column()
        {
            string pathSCDType2 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_2.txt";
            int i = 0;
            string str = "CONVERT(NVARCHAR(32), HashBytes('MD5',  " + "\n";
            if (File.Exists(pathSCDType2))
            {
                string[] content = File.ReadAllText(pathSCDType2).Split(Convert.ToChar(";"));
                foreach (var item in content)
                {
                    str += "ISNULL([" + item.Trim() + "], '') ";

                    if (i + 1 < content.Length)
                    {
                        str += " + '|' +";
                    }
                    i = i + 1;
                    str += "\n";
                }
            }
            str += " ), 2) AS SCD2_HASH_ID";
            return str;
        }

        private string GetSelectStatementWithHashColumns()
        {
            IEnumerable<Table> columnsName = GetColumnsName();
            int i = 0;
            var enumerable = columnsName as IList<Table> ?? columnsName.ToList();

            var selectStatement = new StringBuilder();
            selectStatement.Append( "\"");
            selectStatement.Append("SELECT \n" + Get_NK_HASH_ID_Column() + ", \n" + 
                                                   Get_FULL_HASH_ID_Column() + ", \n " + 
                                                   Get_SCD1_HASH_ID_Column() + ", \n " +
                                                   Get_SCD2_HASH_ID_Column() + ", \n ");
            foreach (var it in enumerable)
            {

                selectStatement.Append( "[" + it.ColumnName + "]");

                if (i + 1 < enumerable.Count)
                {
                    selectStatement.Append(",");
                }
                i = i + 1;
                selectStatement.Append("\n");
                //selectStatement += "[" + it + "]";

            }
            selectStatement.Append(" FROM   \"+");
            selectStatement.Append("  @[User::SAPSourceDBSchema] + \".[" + txtTableName.Text + "]\"");
          
          return selectStatement.ToString();
        }

        private string GetLookupQueryTemplate()
        {
            var selectStatement = new StringBuilder();
            selectStatement.Append("\"");
            selectStatement.Append("SELECT \n" + Get_NK_HASH_ID_Column());
       
            selectStatement.Append(" FROM   \"+");
            selectStatement.Append("  @[User::SAPSourceDBSchema] + \".[" + txtTableName.Text + "]\"");

            return selectStatement.ToString();
        }

        private string GetUpdateExpriedRecord()
        {
            //   string updateStatement = "UPDATE [" + cbDatabases.Text + "].[" + enumerable[0].SchemaName + "].[" + txtTableName.Text + "]\n SET " ;
            var updateStatement = new StringBuilder();
            updateStatement.Append("UPDATE [SAP].[" + txtTableName.Text + "]\n SET ");
            updateStatement.Append("[EFFECTIVE_END_DT] = ?\n");
            updateStatement.Append(", [CURRENT_FLAG] = 'FALSE'\n");
            updateStatement.Append(", [AUDIT_LAST_UPDATED_DTM] = ? WHERE ");

            var columnsPKName = GetPrimaryKeysColumns().ToList();
            int i = 0;
            foreach (var cl in columnsPKName)
            {
                updateStatement.Append("[" + cl.ColumnName + "]=?");
                if (i + 1 < columnsPKName.Count)
                {
                    updateStatement.Append(" AND ");
                }
                i = i + 1;
                updateStatement.Append("\n");
            }
            updateStatement.Append(" AND [CURRENT_FLAG] = 'TRUE'");
            return updateStatement.ToString();
        }

        #endregion

      
       
     }

}
