<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modify.aspx.cs" Inherits="BorrowReturn.modify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1px" cellspacing="0px" style="border-collapse:collapse">
          <tr>
            <td colspan="4">Application</td>
          </tr>
          <tr>
            <td>User</td>
            <td>ApplyDate</td>
            <td>ApplyDetails</td>
            <td>Status</td>
          </tr>
          <tr>
            <td>
                <asp:Label ID="Label_User" runat="server"></asp:Label>
              </td>
            <td>
                <asp:Label ID="Label_Date" runat="server"></asp:Label>
              </td>
            <td>
                <asp:TextBox ID="TextBox_Details" runat="server"></asp:TextBox>
              </td>
            <td>
                <asp:Label ID="Label_Status" runat="server"></asp:Label>
              </td>
          </tr>
          </table>
          <table>
          <tr>
            <td colspan="4">Send to user</td>
            </tr>
          <tr>
            <td>Type</td>
            <td>Node/Model</td>
            <td>Amount</td>
            <td>Remarks</td>
          </tr>
          <tr>
            <td>
       

        

        
                    <asp:ListBox ID="ListBox_Type" runat="server" Rows="1" Width="120px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>workstation</asp:ListItem>
                        <asp:ListItem>laptop</asp:ListItem>
                        <asp:ListItem>monitor</asp:ListItem>
                        <asp:ListItem>switch</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                    </asp:ListBox>
                </td>
            <td>
      
          
                    <asp:TextBox ID="TextBox_Model" runat="server" Width="301px"></asp:TextBox>
                </td>
            <td>
      
          
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
            <td>
      
          
                    <asp:TextBox ID="TextBox_Remarks" runat="server" Width="301px"></asp:TextBox>
                </td>
          </tr>
        </table>
        <br />
        <asp:Button ID="Button_Send" runat="server" OnClick="Button_Send_Click" Text="SendToUser" />
        <br />
        <br />
    
        <asp:Label ID="Label_Error" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
