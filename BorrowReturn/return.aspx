<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="return.aspx.cs" Inherits="BorrowReturn._return" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 309px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
          <table>
          <tr>
            <td>User</td>
            <td>Node/Model</td>
          
            <td class="auto-style1">Remarks</td>
          </tr>
          <tr>
            <td>
       

        

        
                    <asp:Label ID="Label_User" runat="server"></asp:Label>
              </td>
            <td>
      
          
                    <asp:TextBox ID="TextBox_Model" runat="server" Width="301px"></asp:TextBox>
                </td>
            
            <td class="auto-style1">
      
          
                    <asp:TextBox ID="TextBox_Remarks" runat="server" Width="301px"></asp:TextBox>
                </td>
          </tr>
        </table>
          <asp:CheckBox ID="CheckBox1" runat="server" Text="Returned all" />
          <br />
          <asp:Button ID="Button_Return" runat="server" Text="Return Confirmed" />
        <br />
        <asp:Label ID="Label_Error" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
