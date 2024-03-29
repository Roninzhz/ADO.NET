﻿using System;
using System.Configuration;
using System.Data;
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
            using (SqlConnection conn = new SqlConnection(str))
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
                catch (Exception ee)
                {
                    Label1.Text = "连接失败原因为：" + ee.Message;
                }
                finally
                {
                    conn.Dispose();
                }
            }
        }

        protected void CreateTable_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Create Table Test(tID Int)";
                cmd.ExecuteNonQuery();
                Label1.Text = "Test is Create";
            }
        }

        protected void Count_Click_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string cmdText = "Select count(*) from users";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                int nums = (int)cmd.ExecuteScalar();
                Label1.Text = "本站注册人数:" + nums;
            }
        }
    }
}