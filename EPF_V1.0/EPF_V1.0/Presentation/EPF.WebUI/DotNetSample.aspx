<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DotNetSample.aspx.cs" Inherits="EPF.WebUI.DotNetSample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
        <td>
            <asp:Button ID="btnEnum" runat="server" Text="Enum" onclick="btnEnum_Click" />
        </td>
    </tr>
    
     <tr>
        <td>
            <asp:Button ID="btnInterface" runat="server" Text="Interface" 
                onclick="btnInterface_Click" />
        </td>
    </tr>
    
     <tr>
        <td>
            <asp:Button ID="btnProperty" runat="server" Text="Property" 
                onclick="btnProperty_Click" />
        </td>
    </tr>
    
     <tr>
        <td>
            <asp:Button ID="btnConstructor" runat="server" Text="Constructor" />
        </td>
    </tr>
    
     <tr>
        <td>
            <asp:Button ID="btnStatic" runat="server" Text="Static" 
                onclick="btnStatic_Click" />
        </td>
    </tr>
    
     <tr>
        <td>
            <asp:Button ID="btnErrorHandling" runat="server" Text="ErrorHandling" 
                onclick="btnErrorHandling_Click" />
        </td>
    </tr>
    
      <tr>
        <td>
            <asp:Button ID="btnUsing" runat="server" Text="Using" />
        </td>
    </tr>
    
       <tr>
        <td>
            <asp:Button ID="btnGlobal" runat="server" Text="Global Variable" 
                onclick="btnGlobal_Click" />
        </td>
    </tr>
    
    
    </table>
    
    </div>
    </form>
</body>
</html>
