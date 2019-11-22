using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Database
{
    public partial class _4_12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTranTest_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SMDB"].ToString();
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlTransaction trans;
                trans = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;
                try
                {

                    //此处报错，日期由default换用获取系统时间函数getdate()函数，报错解决
                    cmd.CommandText = "insert into GoodEvaluate values(1,46,'案例丰富，实用！',getdate())";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Goods set gdEvNum=gdEvNum+1 where gdID=46";
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    Response.Write("评价成功！");
                }
                catch (Exception ee)
                {
                    Response.Write(ee);
                    trans.Rollback();
                }
            }
        }
    }
}