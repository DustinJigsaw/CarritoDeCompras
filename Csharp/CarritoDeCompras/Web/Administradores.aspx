<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administradores.aspx.cs" Inherits="Web.Administradores" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="LinkButton1" runat="server" href="Productos.aspx">NuevoProducto</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton2" runat="server" href="Categorias.aspx" >NuevaCategoria</asp:LinkButton>
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton3" runat="server" href="Home.aspx">Cancelar</asp:LinkButton>
</asp:Content>
