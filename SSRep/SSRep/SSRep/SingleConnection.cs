using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SSRep
{
    //singleton pattern
    public class SingleConnection
    {
        private static SqlConnectionStringBuilder _singleSqlConnectionBuilder;
        private static SqlConnection _singleSqlConnection;
        //constructor
        protected SingleConnection() { 
        }

        public static SqlConnectionStringBuilder GetSqlConnectionBuilder(string serverName, string userId, string password)
        {
            if (_singleSqlConnectionBuilder == null)
            {
                _singleSqlConnectionBuilder = new SqlConnectionStringBuilder()
                {
                    DataSource = serverName,
                    UserID = userId,
                    Password = password
                };
            }
            return _singleSqlConnectionBuilder;
        }

        public static SqlConnection GetSqlConnection(SqlConnectionStringBuilder singleSqlConnBuilder) {
            if (singleSqlConnBuilder != null)
            {
                _singleSqlConnection = new SqlConnection(singleSqlConnBuilder.ConnectionString);
            }
            return _singleSqlConnection;
        }

        public static SqlConnection GetSqlConnectionToDB(string databaseName) {
            if (_singleSqlConnectionBuilder != null)
            {
                _singleSqlConnection = new SqlConnection(_singleSqlConnectionBuilder.ConnectionString + ";Database='" + databaseName + "'");
            }
            return _singleSqlConnection;
        }

        public static bool IsConnect()
        {
            return _singleSqlConnectionBuilder==null? false:true;
        }
    }
}
