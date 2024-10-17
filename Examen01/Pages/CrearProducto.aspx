<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearProducto.aspx.cs" Inherits="Examen01.Pages.CrearProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <h2>Crear producto </h2>
    <br />

    <a>Nombre del producto </a>
    <br />
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    <br />
    <a>Cantidad </a>
    <br />
    <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
    <br />
    <br />
    <a>Precio Unitario </a>
    <br />
    <asp:TextBox ID="txtPrecioU" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar"  BackColor="LightBlue" OnClick="btnGuardar_Click"  />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
