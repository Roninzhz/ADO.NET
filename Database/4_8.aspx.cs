using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace Database
{
    public partial class _4_8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetBind();
        }
        protected void SetBind()
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            DataSet ds = new DataSet();
            using(SqlConnection conn=new SqlConnection(str))
            {
                conn.Open();
                string cmdText = "select tName,tID from goodsType";
                SqlDataAdapter sda = new SqlDataAdapter(cmdText, conn);
                sda.Fill(ds, "gtype");
            }
            ddlGoodType.DataSource = ds.Tables["gtype"];
            ddlGoodType.DataTextField = "tName";
            ddlGoodType.DataValueField = "tID";
            ddlGoodType.DataBind();
            chkGoodType.DataSource = ds.Tables["gtype"];
            chkGoodType.DataTextField = "tName";
            chkGoodType.DataValueField = "tID";
            chkGoodType.DataBind();
        }
    }
}