<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="BorrowReturn.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Application records:<br />
        <br />
        <asp:GridView ID="GridView_Apply" runat="server" AutoGenerateColumns="False" DataKeyNames="AID" DataSourceID="myds" OnRowCommand="GridView_Apply_RowCommand">
            <Columns>
                <asp:BoundField DataField="AID" HeaderText="AID" InsertVisible="False" ReadOnly="True" SortExpression="AID" Visible="False" />
                <asp:BoundField DataField="User" HeaderText="User" SortExpression="User" />
                <asp:BoundField DataField="ApplyDate" HeaderText="ApplyDate" SortExpression="ApplyDate" />
                <asp:BoundField DataField="ApplyDetails" HeaderText="ApplyDetails" SortExpression="ApplyDetails" />
                <asp:BoundField DataField="ReceiveDate" HeaderText="ReceiveDate" SortExpression="ReceiveDate" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="ReceiveAmount" HeaderText="ReceiveAmount" SortExpression="ReceiveAmount" />
                <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:ButtonField Text="Send to user" CommandName="Send to user" />
                <asp:ButtonField Text="Returning" CommandName ="Returning" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="myds" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\br.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [apply] ORDER BY [ApplyDate] DESC"></asp:SqlDataSource>
        <asp:Label ID="Label_Error" runat="server"></asp:Label>
            <HR style="border:1 dashed #987cb9; margin-left: 0px;" width="100%" ;SIZE=1>
               <p>
                   Returning Records:</p>
        <p>
            <asp:Button ID="Button_iReturn" runat="server" BorderStyle="None" EnableTheming="True" OnClick="Button_iReturn_Click" Text="Independent Return" />
        </p>
        <p>
            <asp:GridView ID="GridView_Return" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
