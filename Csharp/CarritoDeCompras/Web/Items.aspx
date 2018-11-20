<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="Web.Items" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label5" runat="server" Text="ITEMS:"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    </p>
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Cantidad"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Producto"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="ddlProducto" runat="server" OnSelectedIndexChanged="SelecionarItem">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Precio Unitario"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="tbxPrecioUnitario" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Sub-Total"></asp:Label>
    </p>
    <asp:TextBox ID="tbxSubTotal" runat="server" Enabled="False"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSubTotal" runat="server" Text="Aceptar" OnClick="btnSubTotal_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbnCancelar" runat="server" href="CarritoDeCompras.aspx" Height="24px"> Cancelar</asp:LinkButton>
    <br />
</asp:Content>
