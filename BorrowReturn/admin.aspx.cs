using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.DirectoryServices.AccountManagement;

namespace BorrowReturn
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Duser myuser = new Duser();
            myuser.RecognizeUser();

            if (myuser.isAdmin() == false)
                Response.Redirect("index.aspx");
        }


        protected void GridView_Apply_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 i = Convert.ToInt32(e.CommandArgument.ToString());//得到行号 
            string mid = ((GridView)sender).DataKeys[i].Values["AID"].ToString();
            string mstatus = GridView_Apply.Rows[i].Cells[9].Text;
            int st;
            if (mstatus == "Pending") st = 1;
            else if (mstatus == "Sent to user") st = 2;
            else if (mstatus == "Returned") st = 3;
            else st = 4;

            if (e.CommandName == "Send to user")
            {
                if (st != 1)
                {
                    Response.Write("<script>alert('<Pending> status needed!')</script>");
                    return;
                }   
                Response.Redirect("modify.aspx?id=" + mid);

            }
            else if (e.CommandName == "Returning")
            {
                if (st != 2)
                {
                    Response.Write("<script>alert('<Sent to user> status needed!')</script>");
                    return;
                }
                Response.Redirect("return.aspx?id=" + mid);
            }
            
        }

        protected void Button_iReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("return.aspx");
        }





    }
}