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
    public partial class apply : System.Web.UI.Page
    {
        public string connStr = "Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/br.mdb");
        public string lusername;


        protected void Page_Load(object sender, EventArgs e)
        {
            Duser myuser = new Duser();
            bool isDomainUser = myuser.RecognizeUser();
            Label_FirstName.Text = myuser.FirstName;
            Label_LastName.Text = myuser.LastName;
            lusername = myuser.UserName;

            if (isDomainUser == false)
                Button_Confirm.Enabled = false;
        }

        protected void Button_Confirm_Click(object sender, EventArgs e)
        {
            
            if (ListBox_Type.Text == "")
            {
                Response.Write("<script>alert('Please choose type！')</script>");
                return;
            }
            else if (ListBox_Type.Text == "other" && TextBox_Model.Text == "")
            {
                Response.Write("<script>alert('Please input node/model！')</script>");
                return;
            }
            else
            {
                Button_Confirm.Enabled = false;
                Label_Error.Text = "Application accepted! Please wait 5 seconds for page redirection...";
                string idate = DateTime.Now.ToString("yyyy-MM-dd  H:mm:ss");
                string details;

                details = ListBox_Type.Text + " " + TextBox_Model.Text + "   *" + ListBox_Amount.Text;

                OleDbConnection conn = new OleDbConnection(connStr);

                try
                {
                    conn.Open();
                    string sql = "INSERT INTO [apply] ([User],ApplyDate,ApplyDetails,Status) VALUES('" + lusername + "','" + idate + "','" + details + "','Pending');";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ee)
                {
                    Label_Error.Text = ee.ToString();
                }


                string strRedirectPage = "index.aspx";
                string strRedirectTime = "5";
                string strRedirect = string.Format("{0};url={1}", strRedirectTime, strRedirectPage);
                Response.AddHeader("refresh", strRedirect);
            }
        }


    }
}