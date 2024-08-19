<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="billform.aspx.cs" Inherits="hospitalmanagement.billform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 98%;
            border:2px solid black;
        }
        .auto-style2 {
            height: 40px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
            color: #00D9A5;
            font-size: 30px;
            height: 12px;
        }
        .auto-style13 {            text-align: right;
            font-size: 30px;
            height: 98px;
        }
        .auto-style21 {
            text-align: center;
            width: 361px;
            height: 12px;
        }
        .auto-style26 {
            width: 65px;
        }
        .auto-style27 {
            width: 533px;
            font-size: 30px;
            text-align: center;
        }
        .auto-style30 {
            color: #00CC00;
            font-size: 40px;
        }
        .newStyle1 {
            font-family: gibson;
        }
        .newStyle2 {
            font-family: "Segoe UI Semibold";
        }
        .newStyle3 {
            font-family: "Yu Gothic UI";
        }
        .newStyle4 {
            font-family: Arial;
        }
        .newStyle5 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .auto-style36 {
            color: #00D9A5;
        }
        .newStyle6 {
            font-family: Calibri;
        }
        .newStyle7 {
            font-family: Calibri;
        }
        .newStyle8 {
            color: #00D9A5;
            font-size: 40px;
        }
        .auto-style40 {
            height: 3px;
            text-align: center;
        }
        .auto-style41 {
            font-size: 60px;
        }
        .auto-style42 {
            font-size: 40px;
        }
        .auto-style46 {
            font-size: 25px;
        }
        .auto-style47 {
            color: #00D9A5;
            font-size: 30px;
        }
        .auto-style48 {
            font-size: 30px;
        }
        .auto-style50 {
            font-size: 25px;
            height: 42px;
        }
        .auto-style68 {
            width: 871px;
            font-size: 25px;
            height: 33px;
        }
        .auto-style69 {
            height: 12px;
            text-align: center;
            width: 88px;
        }
        .auto-style73 {
            text-align: center;
            width: 533px;
            height: 12px;
        }
        .auto-style92 {
            height: 42px;
        }
        .auto-style99 {
            width: 533px;
            font-size: 30px;
            height: 12px;
        }
        .auto-style101 {
            font-size: 30px;
            height: 26px;
            width: 223px;
        }
        .auto-style102 {
            width: 871px;
            font-size: 25px;
            height: 26px;
        }
        .auto-style103 {
            font-size: 25px;
            height: 26px;
        }
        .auto-style104 {
            font-size: 30px;
            height: 14px;
        }
        .auto-style105 {
            font-size: 30px;
            height: 33px;
            width: 223px;
        }
        .auto-style106 {
            font-size: 25px;
            height: 33px;
        }
        .auto-style107 {
            font-size: 30px;
            height: 35px;
        }
        .auto-style108 {
            font-size: 30px;
            height: 30px;
            text-align: left;
        }
        .auto-style110 {
            height: 50px;
            text-align: center;
        }
        .auto-style111 {
            height: 50px;
        }
        .auto-style112 {
            font-size: 30px;
            height: 70px;
            text-align: center;
            background-color: #D7FFE3;
        }
        .auto-style114 {
            color: #00D9A5;
            font-size: 40px;
        }
        .auto-style115 {
            color: #000000;
            text-align: left;
        }
        .auto-style116 {
            color: #000000;
        }
        .auto-style120 {
            font-size: 25px;
            height: 24px;
        }
        .auto-style121 {
            text-align: center;
            width: 432px;
            height: 12px;
        }
        .auto-style124 {
            font-size: 30px;
            height: 12px;
            width: 223px;
        }
        .auto-style125 {
            width: 871px;
            font-size: 25px;
            height: 12px;
        }
        .auto-style126 {
            font-size: 25px;
            height: 12px;
        }
        .auto-style127 {
            font-size: 30px;
            height: 8px;
        }
        .auto-style128 {
            font-size: 30px;
            text-align: right;
        }
        .auto-style129 {
            font-size: 30px;
            height: 98px;
        }
        .auto-style130 {
            width: 533px;
            font-size: 30px;
            text-align: center;
            height: 98px;
        }
        .auto-style131 {
            font-size: 30px;
            height: 70px;
        }
        .auto-style137 {
            font-size: 30px;
            height: 70px;
            width: 361px;
        }
        .auto-style138 {
            width: 88px;
            font-size: 25px;
            height: 70px;
        }
        .auto-style139 {
            width: 432px;
            font-size: 25px;
            height: 70px;
        }
        .auto-style140 {
            width: 533px;
            font-size: 25px;
            height: 70px;
        }
        .auto-style142 {
            height: 71px;
            width: 361px;
        }
        .auto-style143 {
            width: 88px;
            height: 71px;
        }
        .auto-style144 {
            height: 71px;
            width: 432px;
        }
        .auto-style145 {
            width: 533px;
            height: 71px;
        }
        .auto-style146 {
            height: 71px;
        }
        .auto-style147 {
            width: 533px;
            font-size: 25px;
            height: 70px;
            text-align: center;
            background-color: #D7FFE3;
        }
        .auto-style148 {
            width: 432px;
            font-size: 25px;
            height: 70px;
            text-align: center;
            background-color: #D7FFE3;
        }
        .auto-style149 {
            width: 88px;
            font-size: 25px;
            height: 70px;
            text-align: center;
            background-color: #D7FFE3;
        }
        .auto-style150 {
            font-size: 30px;
            height: 70px;
            width: 361px;
            text-align: center;
            background-color: #D7FFE3;
        }
        .auto-style151 {
            width: 65px;
            height: 77px;
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
    <form id="form1" runat="server">
        <div style="text-align: center">
           
           <asp:Button ID="btn_export" class="btn btn-primary wow zoomIn" OnClientClick=" Export()" runat="server" Text="Export" Height="56px" Width="121px" />
          
        </div>
    <div style="text-align: center">
   
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
    </div>
         
    </form>
</body>
</html>
