﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Web.Home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home</h2>
    <hr />
    <h4>Usuarios</h4>
    <asp:LinkButton ID="lbnAdministrador" runat="server" href="Administradores.aspx">Administrador</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="lbnCliente" runat="server" href="Clientes.aspx">Cliente</asp:LinkButton>
</asp:Content>
