<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoCheckWord._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="ShowText" runat="server" Font-Size="Small"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Small" Text="輸入敏感詞,一行一個"></asp:Label>
            <br />
            <asp:TextBox ID="words" runat="server" Height="100px" Width="100%" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="輸入發佈內容"></asp:Label>
            <br />
            <asp:TextBox ID="UserText" runat="server" Height="175px" Width="100%" TextMode="MultiLine"></asp:TextBox>
            <br />
            <p align="center" dir="ltr">
                <asp:Button ID="Ok" runat="server" Text="傳送" /></p>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
