<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="Web.Categorias" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2><asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label></h2>
    <hr />
    <asp:GridView ID="grdCategorias" runat="server">
    </asp:GridView>
    <hr />
    <asp:LinkButton ID="lbnCrearCategoria" runat="server"  href="NuevasCategorias.aspx" OnClick="lbnCrearCategoria_Click">Crear Categoria</asp:LinkButton>
    &nbsp;&nbsp;
    <asp:LinkButton ID="lbnVolver" runat="server" OnClick="lbnVolver_Click">volver</asp:LinkButton>
    <br />
    <br />
    <br />
</asp:Content>
