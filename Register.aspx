<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="StyleSheet" type="text/css" href="generelstyle.css"/>
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
	<link rel="stylesheet" href="css/font-awesome.min.css"/>
	<link rel="stylesheet" href="css/animate.css"/>
	<link rel="stylesheet" href="css/overwrite.css"/>
	<link href="css/animate.min.css" rel="stylesheet"/> 
    <style>
        
        .formclass 
        {
            padding:20px;
            margin:0px auto;
            background:#f00;
            width:200px;
        }
        h2
        {
            text-align:center;
        }
        .input
        {
            padding:4px;
            width:100%;
        }
        .facebook {
           position:fixed;
           margin-left:30px;
            width: 41px;
            height: 35px;
            text-align:right;
            top: 157px;
            left: 22px;
        }
        .twitter {
             position:fixed;
           margin-left:53px;
            width: 34px;
            height: 34px;
            text-align:right;
            top: 195px;
            left: 5px;
        }
        .google {
            position:fixed;
            margin-left:300px;
            width: 35px;
            height: 33px;
            text-align:right;
            top: 126px;
            left: -245px;
        }
        input[type=search] {
            border-style: none;
            border-color: inherit;
            border-width: medium;
width: 48%;
            padding: 10px;
            border-radius:0.2cm 0 0 0.2cm;
            height: 37px;
        }
        button.search-button {
            border-style: none;
            border-color: inherit;
            border-width: medium;
width: 197px;
            background-color: #44a41d;
            border-radius:0 0.2cm 0.2cm 0;
            cursor:pointer;
            height: 45px;
            margin-left: 0px;
            margin-right: 0px;
        }
            button.search-button:hover {
                background-color: #dd1717;
            }
        

        .fwimage1 {
            height: 273px;
            width: 782px;
        }
        .searchbox {
            height: 168px;
            width: 666px;
            margin-right: 2px;
        }
        

        .newStyle1 {
            background-color: #FFFFFF;
            border: medium ridge #000080;
        }
        .newStyle2 {
            border: medium ridge #000080;
        }
        .newStyle3 {
            border: medium ridge #000080;
        }
        .newStyle4 {
            border-style: ridge;
            border-color: #000080;
        }
                

        .auto-style271 {
            color: #FFFFFF;
        }
                

  </style>      
        
    
    
</head>
<body>
   <form id="form1" runat="server">


        <div class="new">

        </div>



    

            <header id="header">
        <nav class="navbar navbar-fixed-top" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Hardware Acceleration Club</a>
                </div>				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="http://localhost:10872/Default3.aspx">Home</a></li>
                        <li><a href="http://localhost:10872/member.aspx">Members</a></li>
                        <li><a  href="http://localhost:10872/post.aspx">Post</a></li>
                        <li><a  href="http://localhost:10872/filelogin.aspx">Files</a></li> 
                        <li><a href="#gallery">Gallery</a></li>
                        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
					
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->		
    </header>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <!--/header-->
     
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     
    
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Name" style="font-weight: 700; color: #FFFF00;"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nametxt" runat="server" Height="36px" style="margin-left: 31px; margin-bottom: 0px" Width="226px" CssClass="newStyle1"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="email_id" style="font-weight: 700; color: #FFFF00;"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="emailtxt" runat="server" Height="36px" style="margin-left: 31px; margin-bottom: 0px" Width="222px" CssClass="newStyle2"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="Label1" runat="server" Text="password" style="font-weight: 700; color: #FFFF00;"></asp:Label>
            <asp:TextBox ID="passtxt" runat="server" Height="38px" style="margin-left: 31px; margin-bottom: 0px" TextMode="Password" Width="220px" CssClass="newStyle3"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="profile_pic" style="font-weight: 700; color: #FFFF00;"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="newStyle4" Height="42px" Width="276px" />
&nbsp;&nbsp;</p>
        <p>
&nbsp;<asp:Button ID="Button1" runat="server" Height="46px" OnClick="Button1_Click" Text="Register" Width="154px" style="font-weight: 700; background-color: #000066" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" ForeColor="#006600" Text="insertion complete" Visible="False" CssClass="auto-style271"></asp:Label>
        </p>
        <p>
            &nbsp;</p>&nbsp;
           
           
        
    </form>
</body>
</html>
