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

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            int type = int.Parse(ddlType.SelectedValue);
            using(SqlConnection conn=new SqlConnection(str))
            {
                try
                {
                    conn.Open();
                    string sqlTxt = "select count(*) from admins where aName=@name and aPwd=@pwd and aType=@type";
                    SqlCommand cmd = new SqlCommand(sqlTxt, conn);
                    SqlParameter[] sps = {new SqlParameter("@name",name),
                    new SqlParameter("@pwd",pwd),
                    new SqlParameter("@type",type)};
                    cmd.Parameters.AddRange(sps);
                    if (((int)cmd.ExecuteScalar()) > 0)
                    {
                        Session["manager"] = name;
                        Response.Write("<script>alert('登陆成功');location.href('ADMain.aspx');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('用户名或密码错误')</script>");
                    }
                }
                catch(Exception ee)
                {
                    //Response.Write("<script>alert('用户名或密码错误')</script>");
                    Response.Write(ee.Message);
                }
            }
        }
    }
}