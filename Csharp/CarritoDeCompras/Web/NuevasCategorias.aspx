<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevasCategorias.aspx.cs" Inherits="Web.NuevaCategoria" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblNuevaCategoria" runat="server" Font-Names="Calibri" Font-Size="X-Large" Text="Nueva  Categoria" Width="169px"></asp:Label>
        <br />
    </p>
    <p>
        &nbsp;
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </p>
&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtId" runat="server" Width="128px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Descripcion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
&nbsp;<p>

        &nbsp; &nbsp;&nbsp;<asp:Button ID="btnCrear" runat="server" Text="Crear" Height="24px" OnClick="btnCrear_Click" />
        &nbsp;&nbsp;
        <asp:LinkButton ID="lbnCancelar" runat="server" href="Categorias.aspx" Height="24px">Cancelar</asp:LinkButton>

    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
