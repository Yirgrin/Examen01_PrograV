<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mensaje.aspx.cs" Inherits="Examen01.Pages.Mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1> Proceso finalizado </h1>
<br />
<a> Se ha completado correctamente el registro de un nuevo producto en la base de datos</a><br />
<br />
<br />
<asp:Button ID="btnRegresa" runat="server" Text="Regresar" OnClick="btnRegresa_Click"/>
</asp:Content>
