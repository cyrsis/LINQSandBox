<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoRss._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-size: small">
    <form id="form1" runat="server" method="post">
    <br />
    <asp:HyperLink ID="RssLink" runat="server" Visible="False" NavigateUrl="rss.xml">[�Ȥ�q�� RSS]</asp:HyperLink>
    <br />
    <br />
    <p>
        <asp:Label ID="Label2" runat="server" Text="Rss �����G"></asp:Label>
        <asp:TextBox ID="RssComment" runat="server" TextMode="MultiLine" Height="87px" Width="82%">��RSS�ɮרϥ�LINQ to XML�BLINQ to SQL�޳N�ͦ��C</asp:TextBox></p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="�W�D���D�G"></asp:Label>
        <asp:TextBox ID="chTitle" runat="server">���\�q�f���M��</asp:TextBox></p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="�W�D�`�a�}�G"></asp:Label>
        <asp:TextBox ID="chLink" runat="server">http://www.tiyor.com/rss/</asp:TextBox></p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="�W�D�����G"></asp:Label>
        <asp:TextBox ID="chDescription" runat="server" TextMode="MultiLine" Height="100px"
            Width="80%">�o�O���եͦ�RSS���W�D�ARSS�N�έp�ÿ�XAddressBook��Ʈw�����O���C</asp:TextBox></p>
    <p>
        �ͦ��ﶵ�G<asp:DropDownList ID="sel" runat="server">
            <asp:ListItem Value="0">�ͬ��ɮ�</asp:ListItem>
            <asp:ListItem Selected="True" Value="1">������X</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="GenBut" runat="server" Text="�ͦ�" /></p>
    <p>
        <asp:Label ID="MessageInfo" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label></p>
    </form>
</body>
</html>
