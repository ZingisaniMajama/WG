<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Wolfgang.Login" %>
<asp:Content ID="Login" ContentPlaceHolderID="MainContent" runat="server">
     <%-- Head--%>
   
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
 
    <link rel="icon" type="image/jpeg" sizes="2000x1999" href="assets/img/WG%20LOGO-FLAT%20COLOR.jpg">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Montserrat:400,400i,700,700i,600,600i">
    <link rel="stylesheet" href="assets/fonts/simple-line-icons.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.10.0/baguetteBox.min.css">
    <link rel="stylesheet" href="assets/css/smoothproducts.css">
    
        <main class="page login-page">
        <section class="clean-block clean-form dark">
            
            <div class="container">
                <div class="block-heading">
                    <h2 class="text-info">Log In</h2>
                </div>
                <form style="margin-left: 40px" >
                    <div class="form-group"><label for="email">Email</label><asp:TextBox runat="server" class="form-control item" type="text" id="txtxEmail" name="email"/></div>
                    <div class="form-group"><label for="password">Password</label><input runat="server" class="form-control" type="password" id="Inpassword" name="npPassword"></div>
                    <div class="form-group">
                        
                        <div class="form-check"><input class="form-check-input" type="checkbox" id="checkbox">
                            <label class="form-check-label" for="checkbox">Remember me</label>

                        </div>
                    </div><button class="btn btn-primary btn-block" type="button">Log In</button>
                    <a class="text-right" href="Registration.aspx" style="width: 72px;height: 13px;margin: 153px;padding: 25px;">Sign Up</a>
                </form>
            </div>
                
        </section>
    </main>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.10.0/baguetteBox.min.js"></script>
    <script src="assets/js/smoothproducts.min.js"></script>
    <script src="assets/js/theme.js"></script>
</asp:Content>
