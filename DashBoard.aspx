<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="hospitalmanagement.DashBoard" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <meta http-equiv="X-UA-Compatible" content="ie=edge">

  <meta name="copyright" content="MACode ID, https://macodeid.com/">

  <title>VitalCare - Medical Center HTML5 Template</title>

  <link rel="stylesheet" href="one-health/assets/css/maicons.css">

  <link rel="stylesheet" href="one-health/assets/css/bootstrap.css">

  <link rel="stylesheet" href="one-health/assets/vendor/owl-carousel/css/owl.carousel.css">

  <link rel="stylesheet" href="one-health/assets/vendor/animate/animate.css">

  <link rel="stylesheet" href="one-health/assets/css/theme.css">  






    <style type="text/css">
        .auto-style1 {
            width: 102%;
        }
        .auto-style2 {
            text-align: center;
            width: 481px;
        }
        .auto-style3 {
            text-align: center;
            width: 476px;
            border-radius: 25px;
        }
        .auto-style4 {
            text-align: center;
            width: 512px;
        }
        .auto-style5 {
            text-align: center;
            width: 522px;
        }
        .auto-style6 {
            text-align: center;
            width: 476px;
            height: 60px;
        }
        .auto-style7 {
            text-align: center;
            width: 522px;
            height: 60px;
        }
        .auto-style8 {
            text-align: center;
            width: 512px;
            height: 60px;
        }
        .auto-style9 {
            text-align: center;
            width: 481px;
            height: 60px;
        }
    </style>





</head>
<body>

  <!-- Back to top button -->
  <div class="back-to-top"></div>

  <header>
    <div class="topbar">
      <div class="container">
        <div class="row">
          <div class="col-sm-8 text-sm">
            <div class="site-info">
              <a href="#"><span class="mai-call text-primary"></span> +00 999 2222 888</a>
              <span class="divider">|</span>
              <a href="#"><span class="mai-mail text-primary"></span> VitalCare@example.com</a>
            </div>
          </div>
          <div class="col-sm-4 text-right text-sm">
            <div class="social-mini-button">
              <a href="#"><span class="mai-logo-facebook-f"></span></a>
              <a href="#"><span class="mai-logo-twitter"></span></a>
              <a href="#"><span class="mai-logo-dribbble"></span></a>
              <a href="#"><span class="mai-logo-instagram"></span></a>
            </div>
          </div>
        </div> <!-- .row -->
      </div> <!-- .container -->
    </div> <!-- .topbar -->

    <nav class="navbar navbar-expand-lg navbar-light shadow-sm">
      <div class="container">
        <a class="navbar-brand" href="one-health/html/index.html"><span class="text-primary">Vital</span>-Care</a>

        <form action="#">
          <div class="input-group input-navbar">
            <div class="input-group-prepend">
              <span class="input-group-text" id="icon-addon1"><span class="mai-search"></span></span>
            </div>
            <input type="text" class="form-control" placeholder="Enter keyword.." aria-label="Username" aria-describedby="icon-addon1">
          </div>
        </form>

        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupport" aria-controls="navbarSupport" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>




        <div class="collapse navbar-collapse" id="navbarSupport">
          <ul class="navbar-nav ml-auto">
            
           
            <li class="nav-item active">
              <a class="nav-link" href="one-health/html/index.html">Logout</a>
            </li>
           
          </ul>
        </div>
          
          
          
          
          
           <!-- .navbar-collapse -->
      </div> <!-- .container -->
    </nav>
  </header>

  <div class="page-section">
    <div class="container">







    <form id="form1" runat="server">
    <div style="text-align: left">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="MANAGE" style="font-weight: 700; text-decoration: underline; font-size: x-large"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="LIST REPORTS" style="font-weight: 700; font-size: x-large; text-decoration: underline"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="DYNAMIC REPORTS" style="font-weight: 700; text-decoration: underline; font-size: x-large"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="DATEWISE REPORTS" style="font-weight: 700; text-decoration: underline; font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1"  runat="server" NavigateUrl="~/CASEPAPER.aspx" >CASEPAPER</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink9"  runat="server" NavigateUrl="~/Reports/CASEPAPER_list_report.aspx">CASEPAPER</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink17"  runat="server" NavigateUrl="~/Reports/CASEPAPER_dynamic1.aspx">DEPARTMENT wise CASEPAPER</asp:HyperLink>
                </td>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink29"  runat="server" NavigateUrl="~/Reports/Datewise_CASEPAPER.aspx">CASEPAPER</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink2"  runat="server" NavigateUrl="~/DEGREE_MASTER.aspx">DEGREE</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink10"  runat="server" NavigateUrl="~/Reports/DEGREE_MASTER_list_report.aspx">DEGREE</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink18"  runat="server" NavigateUrl="~/Reports/CASEPAPER_dynamic2.aspx">DOCTOR wise CASEPAPER</asp:HyperLink>
                </td>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink30"  runat="server" NavigateUrl="~/Reports/Datewise_IPD_MASTER.aspx">IPD</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink3"  runat="server" NavigateUrl="~/DEPARTMENT.aspx">DEPARMENT</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/Reports/DEPARTMENT_list_report.aspx">DEPARTMENT</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink19"  runat="server" NavigateUrl="~/Reports/CASEPAPER_dynamic3.aspx">PATIENT wise CASEPAPER</asp:HyperLink>
                </td>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink31"  runat="server" NavigateUrl="~/Reports/Datewise_OPD_MASTER.aspx">OPD</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink4"  runat="server" NavigateUrl="~/DOCTOR_MASTER.aspx">DOCTOR</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink12"  runat="server" NavigateUrl="~/Reports/DOCTOR_MASTER_list_report.aspx">DOCTOR</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink20"  runat="server" NavigateUrl="~/Reports/DOCTOR_MASTER_dynamic1.aspx">DEPARTMENT wise DOCTOR</asp:HyperLink>
                </td>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink32"  runat="server" NavigateUrl="~/Reports/Datewise_FINAL_BILLING.aspx">FINAL BILLING</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink5"  runat="server" NavigateUrl="~/IPD_MASTER.aspx">IPD</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink13"  runat="server" NavigateUrl="~/Reports/IPD_MASTER_list_report.aspx">IPD</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink21"  runat="server" NavigateUrl="~/Reports/DCTOR_MASTER_dynamic2.aspx">DEGREE wise DCTOR</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/OPD_MASTER.aspx">OPD</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink14"  runat="server" NavigateUrl="~/Reports/OPD_MASTER_list_report.aspx">OPD</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink22"  runat="server" NavigateUrl="~/Reports/IPD_MASTER_dynamic1.aspx">DEPARTMENT wise IPD</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink7"  runat="server" NavigateUrl="~/PATIENT_MASTER.aspx">PATIENT</asp:HyperLink>
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink15"  runat="server" NavigateUrl="~/Reports/PATIENT_MASTER_list_report.aspx">PATIENT</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink23"  runat="server" NavigateUrl="~/Reports/IPD_MASTER_dynamic2.aspx">CASEPAPER wise IPD</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/FINAL_BILLING.aspx">FINAL BILLING</asp:HyperLink>
                </td>
                <td class="auto-style7">
                    <asp:HyperLink ID="HyperLink16"  runat="server" NavigateUrl="~/Reports/FINAL_BILLING_list_report.aspx">FINAL BILLING</asp:HyperLink>
                </td>
                <td class="auto-style8">
                    <asp:HyperLink ID="HyperLink24" runat="server" NavigateUrl="~/Reports/OPD_MASTER_dynamic1.aspx">DEPARTMENT wise OPD</asp:HyperLink>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink25" runat="server" NavigateUrl="~/Reports/OPD_MASTER_dynamic2.aspx">CASEPAPER wise OPD</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink26"  runat="server" NavigateUrl="~/Reports/FINAL_BILLING_dynamic1.aspx">DEPARTMENT wise FINAL BILLING</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink27" runat="server" NavigateUrl="~/Reports/FINAL_BILLING_dynamic2.aspx">IPD wise FINAL BILLING</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink28" runat="server" NavigateUrl="~/Reports/FINAL_BILLING_dynamic3.aspx">CASEPAPER wise FINAL BILLING</asp:HyperLink>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>




</div>
  </div>
<script src="../one-health/assets/js/jquery-3.5.1.min.js"></script>

<script src="../one-health/assets/js/bootstrap.bundle.min.js"></script>

<script src="../one-health/assets/vendor/owl-carousel/js/owl.carousel.min.js"></script>

<script src="../one-health/assets/vendor/wow/wow.min.js"></script>

<script src="../one-health/assets/js/google-maps.js"></script>

<script src="../one-health/assets/js/theme.js"></script>

<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAIA_zqjFMsJM_sxP9-6Pde5vVCTyJmUHM&callback=initMap"></script>
  
</body>
</html>
