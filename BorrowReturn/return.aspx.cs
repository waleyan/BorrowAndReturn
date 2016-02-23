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
    public partial class _return : System.Web.UI.Page
    {
        public string connStr = "Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/br.mdb");
        string mid, muser;
        protected void Page_Load(object sender, EventArgs e)
        {
            Duser myuser = new Duser();
            myuser.RecognizeUser();

            if (myuser.isAdmin() == false)
                Response.Redirect("index.aspx");

            mid = Request.QueryString["id"];
            Label_Error.Text = mid;
            if(mid == null)
            {
                TextBox_User.Visible = true;
                CheckBox_A.Visible = false;
                Label_User.Visible = false;
                muser = "unknown";
                mid = "0";
            }
            else
            {
                TextBox_User.Visible = false;
                CheckBox_A.Visible = true;
                Label_User.Visible = true;
                ShowUser();
            }
        }

        public void ShowUser()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM apply WHERE  AID = " + mid + ";";
                OleDbDataAdapter myadapter = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                myadapter.Fill(ds);
                muser = ds.Tables[0].Rows[0]["User"].ToString();
                Label_User.Text = muser;
                conn.Close();
            }
            catch (Exception ee)
            {
                Label_Error.Text = ee.ToString();
            }


        }

        protected void Button_Return_Click(object sender, EventArgs e)
        {
            if (TextBox_Model.Text == "")
            {
                Response.Write("<script>alert('Please fulfill Model！')</script>");
                return;
            }
            else
            {
                Button_Return.Enabled = false;
                Label_Error.Text = "Please wait 5 seconds for page redirection...";
                string idate = DateTime.Now.ToString("yyyy-MM-dd  H:mm:ss");
                string imodel = TextBox_Model.Text;
                string iamount = ListBox_Amount.Text;
                string iremarks = TextBox_Remarks.Text;

                OleDbConnection conn = new OleDbConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO [return] (ReturnDate,Equipment,ReturnAmount,AID,Remarks) VALUES('" + idate + "','" + imodel + "','" + iamount + "','"+mid+"','"+iremarks+"');";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.ExecuteNonQuery();


                    if (CheckBox_A.Checked == true)
                    {
                        string sql1 = "UPDATE apply SET Status = 'Returned' WHERE AID = " + mid + ";";
                        OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
                        cmd1.ExecuteNonQuery();
                    }

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