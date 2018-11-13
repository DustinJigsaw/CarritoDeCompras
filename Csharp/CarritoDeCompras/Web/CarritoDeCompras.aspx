<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="Web.CarritoDeCompras" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:LinkButton ID="LlbnNuevoItem" runat="server" href="Items.aspx" OnClick="LlbnNuevoItem_Click">Nuevo Item</asp:LinkButton>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Listado"></asp:Label>
    </p>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Total"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxTotal" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lbnCancelar" runat="server" href="Clientes.aspx" OnClick="lbnCancelar_Click" Height="24px">Cancelar</asp:LinkButton>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
