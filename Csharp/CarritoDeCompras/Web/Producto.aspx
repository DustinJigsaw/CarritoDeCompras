<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Web.NuevoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Lista de productos"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" href="NuevoProducto.aspx">Crear producto</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" href="Administradores.aspx">Cancelar</asp:LinkButton>
    </p>
</asp:Content>
