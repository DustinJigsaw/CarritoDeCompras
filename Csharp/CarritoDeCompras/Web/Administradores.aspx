<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administradores.aspx.cs" Inherits="Web.Administradores" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Administrador</h2>
    <hr />
    <h3>Opciones</h3>
    <asp:LinkButton ID="LinkButton1" runat="server" href="Productos.aspx">Productos</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton2" runat="server" href="Categorias.aspx" >Categorias</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton3" runat="server" href="Home.aspx">Volver</asp:LinkButton>
</asp:Content>
