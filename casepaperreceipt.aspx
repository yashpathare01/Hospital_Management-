<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="casepaperreceipt.aspx.cs" Inherits="hospitalmanagement.casepaperreceipt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style type="text/css">

      table {
            border:1px solid black;

        }
        .auto-style1 {
            width: 410px;
        }
        
        .auto-style7 {
            width: 154px;
            height: 69px;
            font-size: medium;
        }
        .auto-style8 {
            height: 69px;
        }
        .auto-style19 {
            height: 55px;
        }
        .auto-style23 {
            height: 41px;
        }
        .auto-style27 {
            height: 61px;
        }
        .auto-style28 {
            height: 16px;
            text-align: center;
        }
        .auto-style31 {
            height: 50px;
        }
        .forsize {
            height:100px;
            border:2px solid black;
        }
        .auto-style49 {
            width: 28px;
        }
        .auto-style52 {
            height: 80px;
            text-align: center;
            }
        .auto-style54 {
            height: 20px;
        }
        .auto-style56 {
            height: 13px;
            text-align: center;
        }
        .auto-style61 {
            height: 15px;
        }
        .auto-style62 {
            width: 154px;
            height: 15px;
        }
        .auto-style63 {
            height: 16px;
        }
        .auto-style64 {
            width: 154px;
            height: 16px;
        }
        .auto-style65 {
            width: 154px;
            height: 13px;
        }
        .auto-style66 {
            height: 26px;
            width: 20px;
        }
        .auto-style67 {
            height: 29px;
            width: 20px;
        }
        .auto-style68 {
            height: 17px;
            width: 20px;
        }
        .auto-style69 {
            height: 17px;
            text-align: center;
            }
    </style>

    
     <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.22/pdfmake.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/html2canvas/0.4.1/html2canvas.min.js"></script>
    <script type="text/javascript">
        function Export() {
            html2canvas(document.getElementById('bill'), {
                onrendered: function (canvas) {
                    var data = canvas.toDataURL();
                    var docDefinition = {
                        content: [{
                            image: data,
                            width: 500
                        }]
                    };
                    pdfMake.createPdf(docDefinition).download("Table.pdf");
                }
            });
        }
    </script>

</head>
<body>
    <link href="one-health/assets/css/bootstrap.css" rel="stylesheet" />

    <form id="form1" runat="server">
         <div style="text-align: center">
          
           <asp:Button ID="Button1" class="btn btn-primary wow zoomIn" OnClientClick=" Export()" runat="server" Text="Export" Height="56px" Width="121px"/>
          
        </div>

    <div style="text-align: center">
            
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
    </div>
       
    </form>
</body>
</html>
