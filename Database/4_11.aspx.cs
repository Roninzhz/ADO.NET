using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public partial class _4_11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddType_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("upAddGoodsType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] ps = {new SqlParameter("@tname",txtName.Text),
                new SqlParameter("@flag",SqlDbType.Int)};
                ps[1].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.AddRange(ps);
                cmd.ExecuteNonQuery();
                int tId = (int)cmd.Parameters["@flag"].Value;
                Label1.Text = txtName.Text + "的类别Id为：" + tId;
            }
        }
    }
}