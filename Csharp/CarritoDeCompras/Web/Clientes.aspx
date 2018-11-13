<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Web.Clientes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:LinkButton ID="lbnCarritoDeCompra" runat="server" href="CarritoDeCompras.aspx">Carrito De Compra</asp:LinkButton>
    </p>
    <p>
        <asp:LinkButton ID="lbxVolverAInicio" runat="server">Volver a Inicio</asp:LinkButton>
    </p>
</asp:Content>
