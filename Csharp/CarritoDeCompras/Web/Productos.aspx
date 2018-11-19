<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Web.Productos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><asp:Label ID="Label1" runat="server" Text="Lista de productos"></asp:Label></h1>
    <hr />
    <asp:GridView ID="grdProductos" runat="server">
    </asp:GridView>
    <hr />
    <asp:LinkButton ID="LinkButton1" runat="server" href="NuevoProducto.aspx">Nuevo Producto</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton2" runat="server" href="Administradores.aspx">Volver</asp:LinkButton>
</asp:Content>
