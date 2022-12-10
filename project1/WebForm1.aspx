<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="project1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;Ətraflı<br />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            Kime&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="104px"></asp:TextBox>
            <br />
            <br />
            Mövzu :&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="109px" AppendDataBoundItems="True" AutoPostBack="True" 
            >
            </asp:DropDownList>
            <br />
            <br />
            Kontent:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="104px" Height="20px" style="margin-top: 7px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </asp:Panel>
    </form>
</body>
</html>
