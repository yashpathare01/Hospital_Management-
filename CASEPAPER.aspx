<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CASEPAPER.aspx.cs" Inherits="hospitalmanagement.CASEPAPER" %>

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


    <script type="text/javascript" language="javascript">

        function formValidator()
        {
            // Make quick references to our fields
           
            var CASEPAPER_FEES = document.getElementById("txt_CASEPAPER_FEES");
          


            // Check each input in the order that it appears in the form!
           
            if (notEmpty(CASEPAPER_FEES, "Please fill yore amount") && isNumeric(CASEPAPER_FEES, "Please enter only digit for Fees"))
             {
                                return true;
                            }
                        
                    
                
            
            return false;
        }


        function notEmpty(elem, helperMsg) {

            if (elem.value.length == 0) {
                alert(helperMsg);
                elem.focus(); // set the focus to this input
                return false;
            }
            return true;
        }


        function isNumeric(elem, helperMsg) {
            var numericExpression = /^[0-9]+$/;
            if (elem.value.match(numericExpression)) {
                return true;
            } else {
                elem.value = "";
                alert(helperMsg);
                elem.focus();
                return false;
            }
        }

       

        
</script>

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

            <li class="nav-item">
              <a class="nav-link" href="DashBoard.aspx">Dashboard</a>
            </li>
            <li class="nav-item">
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
      <h1 class="text-center wow fadeInUp">Casepaper</h1>



    <form id="form1" runat="server">
    <div >
        <div class="container">
            <div class="row">
                <div class="col-md-6">
    
        </br>
        <asp:TextBox ID="txt_CASEPAPER_ID" CssClass="form-control" PlaceHolder="Casepaper ID" runat="server" Enabled="False"></asp:TextBox>
        <br />
       
        
        <asp:TextBox ID="txt_CASE_DATE" CssClass="form-control" PlaceHolder="Casepaper Date" runat="server" Enabled="False" TextMode="Date"></asp:TextBox>
        <br />
       
        <asp:Label ID="Label3" runat="server" Text="DEPARTMENT"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
        </asp:DropDownList>
       
        
                    </div>
               
                <div class="col-md-6">

        <asp:Label ID="Label6" runat="server" Text="DOCTOR"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
        </asp:DropDownList>
        <br />
        
        <asp:Label ID="Label4" runat="server" Text="PATIENT"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server">
        </asp:DropDownList>
        <br />
       
        
        <asp:TextBox ID="txt_CASEPAPER_FEES" CssClass="form-control" PlaceHolder="Casepaper Fees" runat="server" Enabled="False"></asp:TextBox>
        <br />
       
                    </div>

            </div>

        </div>

        <asp:Button ID="btn_new" class="btn btn-primary wow zoomIn" runat="server" Text="New" OnClick="btn_new_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_save" class="btn btn-primary wow zoomIn" runat="server" Enabled="False" Text="Save" OnClick="btn_save_Click" OnClientClick="return formValidator()" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_update" class="btn btn-primary wow zoomIn" runat="server" Enabled="False" Text="Update" OnClick="btn_update_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_delete" class="btn btn-primary wow zoomIn" runat="server" Enabled="False" Text="Delete" OnClick="btn_delete_Click" />
        </br>
        </div>
        </br>
        <div>
        <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </div>

    </form>


</div>
  </div>

  

<script src="one-health/assets/js/jquery-3.5.1.min.js"></script>

<script src="one-health/assets/js/bootstrap.bundle.min.js"></script>

<script src="one-health/assets/vendor/owl-carousel/js/owl.carousel.min.js"></script>

<script src="one-health/assets/vendor/wow/wow.min.js"></script>

<script src="one-health/assets/js/google-maps.js"></script>

<script src="one-health/assets/js/theme.js"></script>

<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAIA_zqjFMsJM_sxP9-6Pde5vVCTyJmUHM&callback=initMap"></script>
  
</body>
</html>


