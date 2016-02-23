<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="return.aspx.cs" Inherits="BorrowReturn._return" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style10 {
            height: 20px;
            width: 126px;
        }
        .auto-style5 {
            width: 314px;
            height: 20px;
        }
        .auto-style8 {
            width: 70px;
            height: 20px;
        }
        .auto-style4 {
            height: 20px;
        }
        .auto-style11 {
            width: 126px;
        }

        .auto-style2 {
            width: 314px;
        }
        .auto-style9 {
            width: 70px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        

        
        <table style="width: 591px; margin-right: 0px; text-align:center;" >
            <tr>
                <td class="auto-style10">User</td>
                <td class="auto-style5"> Node/Model</td>
                <td class="auto-style8" >Amount</td>
                <td class="auto-style4" >Remarks</td>
            </tr>
            <tr>
                <td class="auto-style11">
       

        

        
                    <asp:Label ID="Label_User" runat="server"></asp:Label>
                    <asp:TextBox ID="TextBox_User" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
      
          
                    <asp:TextBox ID="TextBox_Model" runat="server" Width="301px"></asp:TextBox>
                </td>
                <td class="auto-style9" >
      
          
        <asp:ListBox ID="ListBox_Amount" runat="server" Rows="1" Width ="50" >
            <asp:ListItem Selected="True">1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td >
       

        

        
                    <asp:TextBox ID="TextBox_Remarks" runat="server" Width="301px"></asp:TextBox>
       

        

        
                </td>
            </tr>
            </table>
          <asp:CheckBox ID="CheckBox_A" runat="server" Text="Returned all" />
          <br />
          <asp:Button ID="Button_Return" runat="server" Text="Return Confirmed" OnClick="Button_Return_Click" />
        <br />
        <asp:Label ID="Label_Error" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
