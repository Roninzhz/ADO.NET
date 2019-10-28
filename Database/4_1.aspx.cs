using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Database
{
    public partial class _4_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSM_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using(SqlConnection conn=new SqlConnection(str))
            {
                try
                {
                    conn.Open();
                    Label1.Text = "连接字符串:" + conn.ConnectionString;
                    Label1.Text += "<br/>连接状态:" + conn.State.ToString();
                    Label1.Text += "<br/>数据源:" + conn.DataSource;
                    Label1.Text += "<br/>服务器版本:" + conn.ServerVersion;
                    Label1.Text += "<br/>数据库名称:" + conn.Database;
                }
                catch(Exception ee)
                {
                    Label1.Text = "连接失败原因为：" + ee.Message;
                }
                finally
                {
                    conn.Dispose();
                }
            }
        }
    }
}