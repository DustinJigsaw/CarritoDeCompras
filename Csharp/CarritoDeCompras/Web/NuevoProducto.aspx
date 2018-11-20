<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoProducto.aspx.cs" Inherits="Web.NuevoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2><asp:Label ID="Label1" runat="server" Text="Crear Producto"></asp:Label></h2>
    <hr />
    <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Codigo de barra"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtCodBarra" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
    &nbsp;<asp:TextBox ID="txtnom" runat="server"></asp:TextBox>
    &nbsp;
    <asp:Label ID="Label7" runat="server" Text="Precio unitario"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtPrecioUni" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    &nbsp;
    <asp:Label ID="Label6" runat="server" Text="Descripcion"></asp:Label>
    &nbsp;
    <br />
    &nbsp;<asp:TextBox ID="txtDescripcion" runat="server" Height="69px" Width="842px"></asp:TextBox>
    <br />
    <br />
    &nbsp;<asp:Label ID="Label5" runat="server" Text="Categoria"></asp:Label>
    &nbsp;
    <asp:DropDownList ID="ddlcategoria" runat="server" OnSelectedIndexChanged="ddlcategoria_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnCrear" runat="server" Height="26px" Text="Crear" Width="89px" OnClick="btnCrear_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" href="Productos.aspx" OnClick="LinkButton1_Click">Cancelar</asp:LinkButton>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
