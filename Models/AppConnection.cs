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
        public static SqlConnection Connection
        {
            get
            {
                var connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                var connection = new SqlConnection(connectionString);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Failed to connect to database! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
                }

                return connection;
            }
        }
    }
}
