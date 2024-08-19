<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IPD_MASTER.aspx.cs" Inherits="hospitalmanagement.IPD_MASTER" %>

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



    <script type="text/javascript" >

        function formValidator() {
            // Make quick references to our fields
            var WARD_NM = document.getElementById("txt_WARD_NM");           
            var BED_NO = document.getElementById("txt_BED_NO");
            var DIESE_NAME = document.getElementById("txt_DIESE_NAME");
            var TREATMENT = document.getElementById("txt_TREATMENT");

            // Check each input in the order that it appears in the form!
            if (notEmpty(WARD_NM, "Name Must be given") && isAlphabet(WARD_NM, "Please enter only letters for your name")) {
                if (notEmpty(BED_NO, "Bed Number Must be given") && isAlphanumeric(BED_NO, "Numbers and Letters Only for Bed Number")) {
                    if (notEmpty(DIESE_NAME, "Disease Name Must be given") && isAlphabet(DIESE_NAME, "Please enter only letters for your disease")) {
                        if (notEmpty(TREATMENT, "Treatment Must be given") && isAlphabet(TREATMENT, "Please enter only letters for your Treatment Name")) {


                            return true;

                        }
                    }
                }
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


                function isAlphabet(elem, helperMsg) {
                    var alphaExp = /^[a-zA-Z ]+$/;
                    if (elem.value.match(alphaExp)) {
                        return true;
                    } else {
                        alert(helperMsg);
                        elem.value = "";
                        elem.focus();
                        return false;
                    }
                }

                function isAlphanumeric(elem, helperMsg) {
                    var alphaExp = /^[0-9a-zA-Z ]+$/;
                    if (elem.value.match(alphaExp)) {
                        return true;
                    } else {
                        alert(helperMsg);
                        elem.value = "";
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
        </div> <!-- .navbar-collapse -->
      </div> <!-- .container -->
    </nav>
  </header>

  <div class="page-section">
       <h1 class="text-center wow fadeInUp">IPD Master</h1>
    <div class="container">
     


    <form id="form1" runat="server">
    <div style="height: 1144px; text-align: center">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
    
       
        <asp:TextBox ID="txt_IPD_ID" CssClass="form-control" PlaceHolder="IPD ID" runat="server" Enabled="False"></asp:TextBox>
       </br>
      
        <asp:Label ID="Label3" runat="server" Text="DEPARTMENT"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
        </asp:DropDownList>
       </br>
       
        </br>
        <asp:TextBox ID="txt_IPD_DATE" CssClass="form-control" PlaceHolder="IPD Date" runat="server" Enabled="False" TextMode="Date"></asp:TextBox>
        </br>
       
        <asp:Label ID="Label5" runat="server" Text="CASEPAPER NO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
        </asp:DropDownList>
        <br />

                    </div>
                <div class="col-md-6">


        
        
        <asp:TextBox ID="txt_WARD_NM" CssClass="form-control" PlaceHolder="Ward Name" runat="server" Enabled="False"></asp:TextBox>
        <br />
      </br>
        
        <asp:TextBox ID="txt_BED_NO" CssClass="form-control" PlaceHolder="Bed No" runat="server" Enabled="False"></asp:TextBox>
        <br />
     </br>
       
        <asp:TextBox ID="txt_DIESE_NAME" CssClass="form-control" PlaceHolder="Dieses Name" runat="server" Enabled="False"></asp:TextBox>
        <br />
       </br>
        
        <asp:TextBox ID="txt_TREATMENT" CssClass="form-control" PlaceHolder="Treatment" runat="server" Enabled="False"></asp:TextBox>
        <br />
          </br>
        

                    </div>
                </div>
            </div>

        <asp:Button ID="btn_new" class="btn btn-primary wow zoomIn" runat="server" Text="New" OnClick="btn_new_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_save" class="btn btn-primary wow zoomIn" runat="server" Text="Save" Enabled="False" OnClick="btn_save_Click" OnClientClick="return formValidator()" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_update" class="btn btn-primary wow zoomIn" runat="server" Text="Update" Enabled="False" OnClick="btn_update_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_delete" class="btn btn-primary wow zoomIn" runat="server" Text="Delete" Enabled="False" OnClick="btn_delete_Click" />
        <br />
        <br />
        <div class="table-responsive">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1"></asp:GridView>
           
        </div>
         
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

