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
    public partial class modify : System.Web.UI.Page
    {
        public string connStr = "Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/br.mdb");
        string mid;

        protected void Page_Load(object sender, EventArgs e)
        {
            Duser myuser = new Duser();
            myuser.RecognizeUser();
            
            if (myuser.isAdmin() == false)
                Response.Redirect("index.aspx");
            
            mid = Request.QueryString["id"];
            Label_Error.Text = mid;
            if(mid == null)
                Response.Redirect("admin.aspx");
            AppInfo();
        }

        public void AppInfo()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM apply WHERE  AID = " + mid + ";";
                OleDbDataAdapter myadapter = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                myadapter.Fill(ds);
                Label_User.Text = ds.Tables[0].Rows[0]["User"].ToString();
                Label_Date.Text = ds.Tables[0].Rows[0]["ApplyDate"].ToString();
                Label_Status.Text = ds.Tables[0].Rows[0]["Status"].ToString();
                TextBox_Details.Text = ds.Tables[0].Rows[0]["ApplyDetails"].ToString();
                conn.Close();

            }
            catch (Exception ee)
            {
                Label_Error.Text = ee.ToString();
            }


        }

        protected void Button_Send_Click(object sender, EventArgs e)
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
                Button_Send.Enabled = false;
                Label_Error.Text = "Please wait 5 seconds for page redirection...";
                string rdate = DateTime.Now.ToString("yyyy-MM-dd  H:mm:ss");
                string rtype = ListBox_Type.Text;
                string rdetails = TextBox_Details.Text;
                string rmodel = TextBox_Model.Text;
                string ramount = ListBox_Amount.Text;
                string rremarks = TextBox_Remarks.Text;

                OleDbConnection conn = new OleDbConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = "UPDATE apply SET ReceiveDate = '" + rdate + "' , Type = '" + rtype + "', Model = '" + rmodel + "',Remarks = '" + rremarks + "',ApplyDetails='" + rdetails + "',ReceiveAmount = " + ramount + ",Status = 'Sent to user' WHERE AID = " + mid + ";";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ee)
                {
                    Label_Error.Text = ee.ToString();
                }
                string strRedirectPage = "admin.aspx";
                string strRedirectTime = "5";
                string strRedirect = string.Format("{0};url={1}", strRedirectTime, strRedirectPage);
                Response.AddHeader("refresh", strRedirect);
            }
        }
    }
}