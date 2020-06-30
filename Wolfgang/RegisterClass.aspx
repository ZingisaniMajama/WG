<%@ Page Title="Regiter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterClass.aspx.cs" Inherits="Wolfgang.RegisterClass" %>






<asp:Content ID="Register" ContentPlaceHolderID="MainContent" runat="server">
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
    


     <main class="page registration-page">
        <section class="clean-block clean-form dark">
            <div class="container">
                <div class="block-heading">
                    <h2 class="text-info">Registration</h2>
                </div>
                <form>
                    <div class="form-group"><label for="name">Names</label><input class="form-control item" type="text" id="name"></div>
                    <div class="form-group"><label for="name">Surname</label><input class="form-control item" type="text" id="name"></div>
                    <div class="form-group"><label for="password">Email</label><input class="form-control item" type="password" id="password"></div>
                    <div class="form-group"><label for="email">Phone Number</label><input class="form-control item" type="text" id="email"></div>
                    <div class="form-group"><label for="email">Password</label><input class="form-control item" type="text" id="email"></div><button class="btn btn-primary btn-block" type="button">Sign Up</button></form>
            </div>
        </section>
    </main>

    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.10.0/baguetteBox.min.js"></script>
    <script src="assets/js/smoothproducts.min.js"></script>
    <script src="assets/js/theme.js"></script>
</asp:Content>

