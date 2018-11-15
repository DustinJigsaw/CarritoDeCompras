<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Web.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Lista de productos"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="grdProductos" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;
        <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar producto" Width="137px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" href="Administradores.aspx">Cancelar</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" href="NuevoProducto.aspx">Crear producto</asp:LinkButton>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
</asp:Content>
