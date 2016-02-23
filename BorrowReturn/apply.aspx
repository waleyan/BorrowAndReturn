<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="apply.aspx.cs" Inherits="BorrowReturn.apply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            width: 314px;
        }
        .auto-style4 {
            height: 20px;
        }
        .auto-style5 {
            width: 314px;
            height: 20px;
        }
        .auto-style8 {
            width: 70px;
            height: 20px;
        }
        .auto-style9 {
            width: 70px;
        }
        .auto-style10 {
            height: 20px;
            width: 126px;
        }
        .auto-style11 {
            width: 126px;
        }

    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
               <h4>Hello,&nbsp;
                   <asp:Label ID="Label_FirstName" runat="server"></asp:Label>
&nbsp;<asp:Label ID="Label_LastName" runat="server"></asp:Label>
                   ! Please input the IT equipment that you want to get from TI team... </h4>
        </div> 
       

        

        
        <table style="width: 591px; margin-right: 0px; text-align:center;" >
            <tr>
                <td class="auto-style10">    Type </td>
                <td class="auto-style5"> Node/Model</td>
                <td class="auto-style8" >Amount</td>
                <td class="auto-style4" ></td>
            </tr>
            <tr>
                <td class="auto-style11">
       

        

        
                    <asp:ListBox ID="ListBox_Type" runat="server" Rows="1" Width="120px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>workstation</asp:ListItem>
                        <asp:ListItem>laptop</asp:ListItem>
                        <asp:ListItem>monitor</asp:ListItem>
                        <asp:ListItem>switch</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                    </asp:ListBox>
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
       

        

        
                    <asp:Button ID="Button_Confirm" runat="server" OnClick="Button_Confirm_Click" Text="Confirm" />
       

        

        
                </td>
            </tr>
            </table>
        <asp:Label ID="Label_Error" runat="server"></asp:Label>
        
        </form>
</body>
</html>
