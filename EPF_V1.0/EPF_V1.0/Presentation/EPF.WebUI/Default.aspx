<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EPF.WebUI._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
     <div>
    
      
        <h3 align="center" class="style1" 
             style="color: #0000FF; font-family: 'Courier New', Courier, monospace;" >Customer Information Details</h3>
        
        <asp:Panel ID="pnlCustomerAddSection" runat="server" 
             GroupingText="Add New Customer" HorizontalAlign="Center" 
             BorderWidth="10px" >
            <table ID="Table1" runat="server">
            <tr>
                <td>
                <asp:Label ID="lblName" runat="server" Text="Name" style="font-weight: 700"></asp:Label>
                 </td>
                 <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                 </td>
                 
                 <td>
                    <asp:Label ID="lblAdd" runat="server" Text="Address" style="font-weight: 700"></asp:Label>
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
                     <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" 
                         Width="80px" BackColor="#336699" Height="41px" style="font-weight: 700" />
                 </td>
                 </tr>
           
            </table>
        </asp:Panel>  
          
        <br />
        
        
        <br />
         <asp:Panel ID="CustomerDisplay" runat="server" GroupingText="Display Customer Records" 
             Direction="LeftToRight" HorizontalAlign="Center" BorderWidth="10px" >
            <asp:GridView ID="grdCustomers" runat="server" CellPadding="4" 
                DataKeyNames="Id" GridLines="None" onrowcommand="grdCustomers_RowCommand" 
                ForeColor="#333333" OnSelectedIndexChanged="grdCustomers_SelectedIndexChanged" 
                Width="835px" AllowPaging="True" AllowSorting="True" 
                onpageindexchanging="grdCustomers_PageIndexChanging" 
                onrowdeleted="grdCustomers_RowDeleted" 
                onrowdatabound="grdCustomers_RowDataBound" 
                onrowdeleting="grdCustomers_RowDeleting">
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:ButtonField CommandName="edit" Text="Update"  />
                    <asp:TemplateField HeaderText="Select">
                     <ItemTemplate>
                       <asp:LinkButton ID="LinkButton1" 
                         CommandArgument='<%# Eval("Id") %>' 
                         CommandName="Delete" runat="server">
                         Delete</asp:LinkButton>
                     </ItemTemplate>
                   </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
          <%--  <asp:Button ID="Button1" runat="server" Text="Filter Attribute" 
                onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;--%>
           <%-- <asp:TextBox ID="txtFilterName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <asp:Button ID="btnFilter" runat="server" onclick="btnFilter_Click" 
                Text="Filtrar" />--%>
            <br />
        
        
        </asp:Panel>
    
    </div>
    
     <asp:Label ID="lblFooter" runat="server" BorderWidth="2px" 
      Text="Sample Project Architecture POC-Copyright © 2014 Indus Net Technologies. All rights reserved.">
     </asp:Label>
    
    </form>
</body>
</html>
