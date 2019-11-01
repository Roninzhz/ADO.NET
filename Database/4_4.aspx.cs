using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Database
{
    public partial class _4_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using(SqlConnection conn=new SqlConnection(str))
            {
                conn.Open();
                string cmdText = "insert into Admins values(@name,@pwd,@type,default)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlParameter[] ps = { new SqlParameter("@name",txtName.Text),
                new SqlParameter("@pwd",txtPwd.Text),
                new SqlParameter("@type",ddlType.SelectedValue)};
                cmd.Parameters.AddRange(ps);
                if (txtPwd.Text != txtEPwd.Text)
                {
                    Response.Write("两次密码填写不一致，请重新填写，管理员添加失败！");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtEPwd.Text = "";
                    return;
                }
                if (cmd.ExecuteNonQuery() > 0)
                    Response.Write("添加成功！");
                else
                    Response.Write("添加失败！");
            }
        }
    }
}