<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminregister.aspx.cs" Inherits="adminregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name" style="font-weight: 700"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nametxt" runat="server" Height="25px" style="margin-left: 31px; margin-bottom: 0px" Width="206px" CssClass="newStyle1"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Email-Id&nbsp;&nbsp;
            <asp:TextBox ID="emailtxt" runat="server" Height="25px" style="margin-left: 31px; margin-bottom: 0px" Width="206px" CssClass="newStyle2"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Password
            <asp:TextBox ID="passtxt" runat="server" Height="25px" style="margin-left: 31px; margin-bottom: 0px" TextMode="Password" Width="206px" CssClass="newStyle3"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="font-weight: 700">
            &nbsp;&nbsp;&nbsp;&nbsp; Contact_no&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="contacttxt" runat="server" Height="25px" style="margin-left: 31px; margin-bottom: 0px" TextMode="Password" Width="206px" CssClass="newStyle3"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="profile_pic" style="font-weight: 700"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="newStyle4" />
&nbsp;&nbsp;</p>
        <p>
&nbsp;<asp:Button ID="Button1" runat="server" Height="41px" OnClick="Button1_Click" Text="Register" Width="116px" style="font-weight: 700; background-color: #99CCFF" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" ForeColor="#006600" Text="insertion complete" Visible="False"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
