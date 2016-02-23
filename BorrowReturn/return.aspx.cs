using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BorrowReturn
{ 
    public partial class _return : System.Web.UI.Page
    {
        string mid;
        protected void Page_Load(object sender, EventArgs e)
        {
            Duser myuser = new Duser();
            myuser.RecognizeUser();

            if (myuser.isAdmin() == false)
                Response.Redirect("index.aspx");

            mid = Request.QueryString["id"];
         //   Label_Error.Text = mid;
            if (mid == null)
                Response.Redirect("admin.aspx");
        }
    }
}