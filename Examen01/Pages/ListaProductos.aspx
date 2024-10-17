<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="Examen01.Pages.ListaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lista de productos </h2>
    <br />
    <asp:Button ID="btnNuevo_Producto" runat="server" Text="Nuevo Producto" OnClick="btnNuevo_Producto_Click" BackColor="LightBlue" />

    <br />
    <br />
    <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" CellPadding="14" CssClass="table table-bordered" OnRowDataBound="gvProductos_RowDataBound" OnPageIndexChanging="gvProductos_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="idProducto" HeaderText="ID" />

            <asp:BoundField DataField="nombre" HeaderText="Producto" />

            <asp:BoundField DataField="fechaRegistro" HeaderText="Fecha registro" DataFormatString="{0:dd/MM/yyyy HH:mm}" />

            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />

            <asp:BoundField DataField="precioUnitario" HeaderText="Precio unitario" DataFormatString="{0:N2}" />

            <asp:BoundField HeaderText="Costo total" DataFormatString="{0:N2}" />

            <asp:BoundField HeaderText="Estado" />

        </Columns>
    </asp:GridView>
</asp:Content>
