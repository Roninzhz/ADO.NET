using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class _5_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GoodTypeDataContext lq = new GoodTypeDataContext();
            var mylq = from gt in lq.GoodsType select gt;
            gvGoodsType.DataSource = mylq;
            gvGoodsType.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            GoodTypeDataContext lq = new GoodTypeDataContext();
            GoodsType gt = new GoodsType();
            gt.tName = txtName.Text.Trim();
            lq.GoodsType.InsertOnSubmit(gt);
            lq.SubmitChanges();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            GoodTypeDataContext lq = new GoodTypeDataContext();
            var types = from gt in lq.GoodsType where gt.tName == txtNamebe.Text.Trim() select gt;
            foreach (var type in types)
                type.tName = txtNameaf.Text.Trim();
            lq.SubmitChanges();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            GoodTypeDataContext lq = new GoodTypeDataContext();
            var types = from gt in lq.GoodsType where gt.tName == txtNameDe.Text.Trim() select gt;
            foreach (var type in types)
                lq.GoodsType.DeleteOnSubmit(type);
            lq.SubmitChanges();
        }
    }
}