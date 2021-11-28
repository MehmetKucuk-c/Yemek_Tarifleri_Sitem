using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Yemek_Tarifleri_Sitem
{
    public class SqlSinif
    {
        public SqlConnection Baglanti()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-FGPFH37;Initial Catalog=DboYemekTarifi;Integrated Security=True;MultipleActiveResultSets=True");
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}