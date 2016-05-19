<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Services_Cliente.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">

            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" 
                onclick="btnSumar_Click" />
            
            <tr></tr>
            <asp:TextBox ID="txtResultado" runat="server" Width="48px"></asp:TextBox>
            <br>
            <asp:Button ID="btnRestar" runat="server" onclick="btnRestar_Click" 
                Text="Restar" />
            <br>
            <br>
            <br>
            <br></br>
            <br>
            <br></br>
            <br></br>
            </br>
            </br>
            </br>
            </br>
            </br>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
