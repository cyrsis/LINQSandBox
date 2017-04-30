<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoRss._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-size: small">
    <form id="form1" runat="server" method="post">
    <br />
    <asp:HyperLink ID="RssLink" runat="server" Visible="False" NavigateUrl="rss.xml">[客戶訂單 RSS]</asp:HyperLink>
    <br />
    <br />
    <p>
        <asp:Label ID="Label2" runat="server" Text="Rss 註釋："></asp:Label>
        <asp:TextBox ID="RssComment" runat="server" TextMode="MultiLine" Height="87px" Width="82%">此RSS檔案使用LINQ to XML、LINQ to SQL技術生成。</asp:TextBox></p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="頻道標題："></asp:Label>
        <asp:TextBox ID="chTitle" runat="server">成功訂貨的清單</asp:TextBox></p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="頻道總地址："></asp:Label>
        <asp:TextBox ID="chLink" runat="server">http://www.tiyor.com/rss/</asp:TextBox></p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="頻道說明："></asp:Label>
        <asp:TextBox ID="chDescription" runat="server" TextMode="MultiLine" Height="100px"
            Width="80%">這是測試生成RSS的頻道，RSS將統計並輸出AddressBook資料庫中的記錄。</asp:TextBox></p>
    <p>
        生成選項：<asp:DropDownList ID="sel" runat="server">
            <asp:ListItem Value="0">生為檔案</asp:ListItem>
            <asp:ListItem Selected="True" Value="1">直接輸出</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="GenBut" runat="server" Text="生成" /></p>
    <p>
        <asp:Label ID="MessageInfo" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label></p>
    </form>
</body>
</html>
