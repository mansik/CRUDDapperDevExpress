using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDapperDevExpress.Models
{
    internal class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        public static IDbConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);            
        }

        public static IDbConnection GetADOConnection()
        {
            // ADO.NET에서 사용, Dapper는 자체적으로 Open()함수를 호출하므로 아래가 필요없다.
            var connection = new SqlConnection(ConnectionString);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception("Failed to connect to database.", ex);
            }

            return connection;
        }
    }
}
