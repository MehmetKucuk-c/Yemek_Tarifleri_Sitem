using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Tarifleri_Sitem
{
    public partial class Kullanici : System.Web.UI.MasterPage
    {
        private readonly SqlSinif sqlSinif = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select *From Tbl_Katagoriler", sqlSinif.Baglanti());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataList1.DataSource = sqlDataReader;
            DataList1.DataBind();
        }
    }
}