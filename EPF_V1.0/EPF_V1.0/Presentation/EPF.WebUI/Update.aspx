<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="EPF.WebUI.Update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Update Customer Record" 
            HorizontalAlign="Center" BorderWidth="10px" style="margin-bottom: 0px">
        <table ID="Table1" runat="server">
        
            <tr>
                 
            
                <td>
                <asp:Label ID="lblName" runat="server" Text="Name" style="font-weight: 700"></asp:Label>
                 </td>
                 <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                 </td>
                 
                 <td style="font-weight: 700">
                    <asp:Label ID="lblAdd" runat="server" Text="Address"></asp:Label>
                 </td>
                 <td>
                   <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                 </td>
               </tr>
               <tr>
                 <td>
                    <asp:Label ID="lblEmailId" runat="server" Text="Email Id" 
                         style="font-weight: 700"></asp:Label>
                 </td>
                 <td>
                   <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                 </td>
                 
                 <td>
                    <asp:Label ID="lblTelNo" runat="server" Text="Tel No" style="font-weight: 700"></asp:Label>
                 </td>
                 <td>
                   <asp:TextBox ID="txtTelNo" runat="server"></asp:TextBox>
                 </td>
                 </tr>   
                 <tr>
                 
                 <td align="center" colspan="4">
                     <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                         onclick="btnUpdate_Click" Width="80px" BackColor="#3366CC" 
                         style="font-weight: 700" />
                 </td>
                 </tr>
           
            </table>
        </asp:Panel>
    
    </div>
    <asp:Label ID="Label1" runat="server" 
        Text="Sample Project Architecture POC-Copyright © 2014 Indus Net Technologies. All rights reserved.  "></asp:Label>
    </form>
</body>
</html>