using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Database
{
    public partial class _4_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColsData();
                ItbItemsData();
            }
        }

        ///<summary>
        ///设定下拉列表ddlCols的数据内容
        /// </summary>
        public void ddlColsData()
        {
            ddlCols.Items.Clear();
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using(SqlConnection conn=new SqlConnection(str))
            {
                conn.Open();
                string cmdText = "select uName,uRealName,uPhone,uQQ from users";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = dr.GetSchemaTable();
                ddlCols.Items.Add(new ListItem("用户名", dt.Rows[0][0].ToString()));
                ddlCols.Items.Add(new ListItem("姓名", dt.Rows[1][0].ToString()));
                ddlCols.Items.Add(new ListItem("联系电话", dt.Rows[2][0].ToString()));
                ddlCols.Items.Add(new ListItem("QQ号", dt.Rows[3][0].ToString()));
            }
        }

        ///<summary>
        ///设定列表框ltItems的数据内容
        /// </summary>
        /// 
        public void ItbItemsData()
        {
            ltbItems.Items.Clear();
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using(SqlConnection conn=new SqlConnection(str))
            {
                conn.Open();
                string filed = ddlCols.SelectedValue;
                string cmdText = "select uID," + filed + " from users";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ltbItems.Items.Add(new ListItem(dr.GetValue(1).ToString(), dr.GetValue(0).ToString()));
                }
            }
        }

        protected void ddlCols_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItbItemsData();
        }

        protected void ltbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                String cmdText = "select * from users where uID=@uid";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlParameter sp = new SqlParameter("uID", ltbItems.SelectedValue);
                cmd.Parameters.Add(sp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    StringBuilder sblstr = new StringBuilder("");
                    sblstr.Append("<br/>用户名：" + dr["uName"]);
                    sblstr.Append("<br/>姓名：" + dr["uRealName"]);
                    sblstr.Append("<br/>性别：" + dr["uSex"]);
                    sblstr.Append("<br/>年龄：" + dr["uAge"]);
                    sblstr.Append("<br/>联系电话：" + dr["uPhone"]);
                    sblstr.Append("<br/>电子邮箱：" + dr["uEmail"]);
                    lblInfo.Text = sblstr.ToString();
                }
            }
        }
    }
}