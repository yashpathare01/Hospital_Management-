<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DOCTOR_MASTER.aspx.cs" Inherits="hospitalmanagement.DOCTOR_MASTER" %>

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

        function formValidator() {


            var DOCT_NAME = document.getElementById("txt_DOCT_NAME");
            var DOCT_LICENSE = document.getElementById("txt_DOCT_LICENSE");
            var DOCT_MOBILE = document.getElementById("txt_DOCT_MOBILE");
            var DOCT_ADDRESS = document.getElementById("txt_DOCT_ADDRESS");
            var DOCT_GENDER = document.getElementById("txt_DOCT_GENDER");
            var DOCT_SPECIALITY = document.getElementById("txt_DOCT_SPECIALITY");
            var DOCT_EMAIL= document.getElementById("txt_DOCT_EMAIL");



            if (notEmpty(DOCT_NAME, "Doctor Name Must be given") && isAlphabet(DOCT_NAME, "Please enter only letters for your name")) {

                if (notEmpty(DOCT_LICENSE, "License Must be given") && isAlphanumeric(DOCT_LICENSE, "Numbers and Letters Only for License")) {

                    if (notEmpty(DOCT_MOBILE, "Phone No Must be given") && validmobile(DOCT_MOBILE) && isNumeric(DOCT_MOBILE, "Please enter a valid Phone no")) {

                        if (notEmpty(DOCT_ADDRESS, "Address Must be given") && isAlphanumeric(DOCT_ADDRESS, "Numbers and Letters Only for Address")) {

                            if (notEmpty(DOCT_GENDER, "Gender Must be given") && isAlphabet(DOCT_GENDER, "Please enter only letters for your Gender")) {

                                if (notEmpty(DOCT_SPECIALITY, "Speciality Must be given") && isAlphabet(DOCT_SPECIALITY, "Please enter only letters for your Speciality")) {

                                    if (notEmpty(DOCT_EMAIL, "Email Must be given") && emailValidator(DOCT_EMAIL, "Please enter a valid email address")) {

                                        return true;
                                    }
                                }
                            }
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

            function validmobile(elem) {
                var uInput = elem.value;
                if (uInput.length == 10) {
                    return true;
                } else {
                    alert("Please enter valid mobile Or Phone No");
                    elem.value = "";
                    elem.focus();
                    return false;
                }
            }


            function lengthRestriction(elem, min, max) {
                var uInput = elem.value;
                if (uInput.length >= min && uInput.length <= max) {
                    return true;
                } else {
                    alert("Please enter between " + min + " and " + max + " characters");
                    elem.value = "";
                    elem.focus();
                    return false;
                }
            }

            function madeSelection(elem, helperMsg) {
                if (elem.value == "Please Choose") {
                    alert(helperMsg);
                    elem.focus();
                    return false;
                } else {
                    return true;
                }
            }

            function emailValidator(elem, helperMsg) {
                var emailExp = /^[\w\-\.\+]+\@[a-zA-Z0-9\.\-]+\.[a-zA-z0-9]{2,4}$/;
                if (elem.value.match(emailExp)) {
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
       <h1 class="text-center wow fadeInUp">Doctor Master</h1>
    <div class="container">
 
     


    <form id="form1" runat="server">
    <div class="container">
          <div class="row">
        <div class="col-md-6">
          
    
        
        <asp:TextBox ID="txt_DOCT_ID" PlaceHolder="Doctor ID" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />
       <br />
        
        <asp:TextBox ID="txt_DOCT_NAME" PlaceHolder="Doctor Name" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />
      
        <asp:Label ID="Label3" runat="server" Text="DEPARTMENT"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
        </asp:DropDownList>
        <br />
      
        <asp:Label ID="Label4" runat="server" Text="DEGREE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
        </asp:DropDownList>
        <br />
       
        
        <asp:TextBox ID="txt_DOCT_LICENSE" PlaceHolder="Doctor License" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />
             </div>

        <div class="col-md-6">

        
        
        <asp:TextBox ID="txt_DOCT_MOBILE" PlaceHolder="Doctor Mobile" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />

        <asp:TextBox ID="txt_DOCT_ADDRESS" PlaceHolder="Doctor Address" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />
       
        
        <asp:TextBox ID="txt_DOCT_GENDER" PlaceHolder="Doctor Gender" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />
       
        <asp:TextBox ID="txt_DOCT_SPECIALITY" PlaceHolder="Doctor Speciality" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />
      
        
        <asp:TextBox ID="txt_DOCT_EMAIL" PlaceHolder="Doctor Email" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <br />

        
        <asp:TextBox ID="txt_DOCT_PASS" PlaceHolder="Doctor Password" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        
            <br />
            <br />

            </div>
        </div>
        </div>
         </div>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btn_new" class="btn btn-primary wow zoomIn" runat="server" Text="New" OnClick="btn_new_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_save" class="btn btn-primary wow zoomIn" runat="server" Enabled="False" Text="Save" OnClick="btn_save_Click" OnClientClick="return formValidator()" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_update" class="btn btn-primary wow zoomIn" runat="server" Enabled="False" Text="Update" OnClick="btn_update_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_delete" class="btn btn-primary wow zoomIn" runat="server" Enabled="False" Text="Delete" OnClick="btn_delete_Click" />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="GridView1" CssClass="table-responsive" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" style="margin-left: 0px">
        </asp:GridView>
    
   
    </form>
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

