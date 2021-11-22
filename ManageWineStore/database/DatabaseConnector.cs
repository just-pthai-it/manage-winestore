using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.database
{
    class DatabaseConnector
    {
        string strConnect = "Data Source=WRBKOR23;Initial Catalog=BTL;Integrated Security=True";
        SqlConnection sqlConnect = null;

        public SqlConnection SqlConnect { get => sqlConnect; set => sqlConnect = value; }

        public void OpenConnect()
        {
            SqlConnect = new SqlConnection(strConnect);
            if (SqlConnect.State != ConnectionState.Open)
            {
                SqlConnect.Open();
            }
        }

        public void CloseConnect()
        {
            if (SqlConnect.State != ConnectionState.Closed)
            {
                SqlConnect.Close();
                SqlConnect.Dispose();
            }
        }
    }
}
