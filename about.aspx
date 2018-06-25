<%@ Page Language="C#" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="about" %>

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
table,th,td {
  border : 1px solid black;
  border-collapse: collapse;
}
th,td {
  padding: 5px;
}

.center {
    display: block;
    margin-left: auto;
    margin-right: auto;
    width: 72%;
                height: 449px;
            }
            .auto-style271 {
                height: 246px;
                width: 1091px;
                font-size: medium;
                color: #000000;
            }
            .auto-style272 {
                color: #000000;
                font-weight: 700;
                font-size: x-large;
            }
        </style>
        </head>

<body>
    <form id="form1" runat="server">
        
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
                        <li><a href="<li><a href="http://localhost:10872/gallarey.aspx">Gallery</a></li>
                        
					
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->		
    </header><!--/header-->


        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div>
            <img src="img/3D-HD-Backgrounds-High-Quality-For-Desktop.jpg" alt="Paris" class="center"><br />
        </div>
        <br />
        
        <br />
        &nbsp;&nbsp;
        <br />
        <div class="auto-style271">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="HACK" CssClass="auto-style272"></asp:Label>
       
                 &nbsp; stands for Hardware Acceleration Club of KUET. The members of HACK especially works on embedded systems&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; development. HACK has developed some Robots like- -SKIM-H, the first intelligent ROBOT of Bangladesh. -Multi ROBOT, two robot can communicate with each other and can make a map of an area. -M ROBOT, a voice controlled ROBOT. -Wayfarer, a garbage man ROBOT. -Fast Line Tracer Robot and some others. HACK has implemented various projects like- -Home automation. -Online Heart rate monitoring system. -Pressure and temperate monitoring system of Human body. -Local Area Network using head phone. -Portable Face Recognizer. and many more. The members of HACK are now working on some innovative and challenging projects including: -Maze Solver Robot This facebook group works as a communication medium to share the ideas and knowledge between the members and others who are interested in embedded system development<br />
           
            </div>
        <br />
&nbsp;<asp:Button ID="Button3" runat="server" Height="52px" OnClick="Button3_Click" style="color: #FFFF00; font-weight: 700; background-color: #000066" Text="resources" Width="202px" />
&nbsp;
        <br />
        <br />
        &nbsp<asp:Button ID="Button1" runat="server" Height="53px" OnClick="Button4_Click" style="color: #FFFF00; font-weight: 700; background-color: #000066" Text="events" Width="203px" />;&nbsp;
        <br />
        <br />
        <br />
&nbsp;

        <button type="button" onclick="loadDoc()">show_instructors</button>

<table id="demo"></table>



        <script>
            function loadDoc() {
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function () {
                    if (this.readyState == 4 && this.status == 200) {
                        myFunction(this);
                    }
                };
                xhttp.open("GET", "record.xml", true);
                xhttp.send();
            }
            function myFunction(xml) {
                var i;
                var xmlDoc = xml.responseXML;
                var table = "<tr><th>Designation</th><th>Name</th><th>Batch</th></tr>";
                var x = xmlDoc.getElementsByTagName("CD");
                for (i = 0; i < x.length; i++) {
                    table += "<tr><td>" +
                    x[i].getElementsByTagName("DESIGNATION")[0].childNodes[0].nodeValue +
                    "</td><td>" +
                    x[i].getElementsByTagName("NAME")[0].childNodes[0].nodeValue +
                    "</td><td>" +
                    x[i].getElementsByTagName("BATCH")[0].childNodes[0].nodeValue +
                    "</td></tr>";
                }
                document.getElementById("demo").innerHTML = table;
            }
</script>



    </form>

</body>
</html>


