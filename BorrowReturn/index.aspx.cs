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
    public partial class index : System.Web.UI.Page
    {
        public string connStr = "Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/br.mdb");
        public string lusername;

        protected void Page_Load(object sender, EventArgs e)
        {
            Duser myuser = new Duser();
            bool isDomainUser = myuser.RecognizeUser();
            Label_FirstName.Text = myuser.FirstName;
            Label_LastName.Text = myuser.LastName;
            Label_AccountName.Text = myuser.domainAndName;
            lusername = myuser.UserName;

            if (isDomainUser == false)
                Button_Apply.Enabled = false;
            CheckHistory(); 
        }
        


        
        public void CheckHistory()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT User,ApplyDate,ApplyDetails,ReceiveDate,Type,Model,ReceiveAmount,Remarks,Status FROM apply WHERE  User = '" + lusername + "' ;";
                OleDbDataAdapter myadapter = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                myadapter.Fill(ds);
                if (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0)
                {
                    Label_History.Text = "No Record";
                }
                else
                {
                    GridView_History.DataSource = ds;
                    GridView_History.DataBind();
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                Label_Error.Text = ee.ToString();
            }

        }

        protected void Button_Apply_Click(object sender, EventArgs e)
        {
            Response.Redirect("apply.aspx");
        }




    }
}