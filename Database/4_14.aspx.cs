using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class _4_14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataListBind()
        {
            int PageNumber = 1;
            if (ViewState["Page"] != null)
                PageNumber = Convert.ToInt16(ViewState["Page"]);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = sqlGoods.Select(DataSourceSelectArguments.Empty);
            pds.AllowPaging = true;
            pds.PageSize = 3;
            if (PageNumber > pds.PageCount)
                PageNumber = 1;
            pds.CurrentPageIndex = PageNumber - 1;
            dlstGoods.DataSourceID = null;
            dlstGoods.DataSource = pds;
            dlstGoods.DataBind();
            lblCurPage.Text = "第" + (pds.CurrentPageIndex + 1).ToString() + "页";
            lblTotalPage.Text = "/共" + pds.PageCount.ToString() + "页";
            ViewState["Page"] = PageNumber;
            lbtnPre.Enabled = true;
            lbtnNext.Enabled = true;
            if (pds.IsFirstPage)
                lbtnPre.Enabled = false;
            if (pds.IsLastPage)
                lbtnNext.Enabled = false;

        }

        protected void LinkBtnClick(object sender, CommandEventArgs e)
        {
            int curPage = Convert.ToInt16(ViewState["Page"]);
            if (e.CommandName == "Pre")
                ViewState["Page"] = curPage - 1;
            if (e.CommandName == "Next")
                ViewState["Page"] = curPage + 1;
            DataListBind();
        }

        protected void lbtnPre_Click(object sender, EventArgs e)
        {

        }

        protected void lbtnNext_Click(object sender, EventArgs e)
        {

        }
    }
}