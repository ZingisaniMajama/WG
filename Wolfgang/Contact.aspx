<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Wolfgang.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <address>
        Wolfgang<br />
        Rosetenville, JH 2000<br />
        <abbr title="Phone">Phone:</abbr>
        066.038.6805
    </address>
    
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
   
    <div>
        <input runat="server" rid="Text1" type="text" name="Text1" />
    </div>
</asp:Content>
