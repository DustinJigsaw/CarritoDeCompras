<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Web.Clientes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cliente</h2>
    <hr />
    <h4>Opciones</h4>
    <asp:LinkButton ID="lbnCarritoDeCompra" runat="server" href="CarritoDeCompras.aspx">Carrito De Compra</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="lbxVolverAInicio" href="Home.aspx" runat="server">Volver</asp:LinkButton>
</asp:Content>
