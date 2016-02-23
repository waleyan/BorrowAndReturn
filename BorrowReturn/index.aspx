<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BorrowReturn.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
             <h2>PPDC Borrow&Return System</h2>
             <h5>(v1.0.0)</h5>
            <HR style="border:1 dashed #987cb9; margin-left: 0px;" width="100%" ;SIZE=1>
               <h4>Welcome,
                   <asp:Label ID="Label_FirstName" runat="server" ForeColor="Blue" ></asp:Label>
&nbsp;<asp:Label ID="Label_LastName" runat="server" ForeColor="Blue"></asp:Label>
&nbsp;(<asp:Label ID="Label_AccountName" runat="server"></asp:Label>
                   ) ! </h4>
             <h4>If you want to apply for IT equipment from TI team, click here:&nbsp;
                 <asp:Button ID="Button_Apply" runat="server" OnClick="Button_Apply_Click" style="height: 26px" Text="Apply" />
             </h4>
             <p style="font-size: smaller; color: #FF0000">(Please do not apply for same equipment repeatly.)</p>
             <p style="font-size: smaller; color: #FF0000">&nbsp;</p>
             <HR style="border:1 dashed #987cb9; margin-left: 0px;" width="100%" ;SIZE=1>
             <h4>Your Application and borrowing history: <asp:Label ID="Label_History" runat="server"></asp:Label>
                 &nbsp;
                 </h4>
             <p>
                 <asp:GridView ID="GridView_History" runat="server">
                 </asp:GridView>
             </p>
             <p>
                 &nbsp;</p>
             <p>
                 &nbsp;</p>
             <p>
                 &nbsp;</p>
        </div> 
       

        

        
        </div>
        <HR style="border:1 dashed #987cb9; margin-left: 0px;" width="100%" ;SIZE=1>
        <asp:Label ID="Label_Error" runat="server"></asp:Label>
    </form>
</body>
</html>
