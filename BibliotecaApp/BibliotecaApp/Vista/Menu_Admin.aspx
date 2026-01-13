<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Admin.Master" AutoEventWireup="true" CodeBehind="Menu_Admin.aspx.cs" Inherits="BibliotecaApp.Vista.Menu_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <%-- Cambiar ubicacion de estos des botones --%>
        <div class="row justify-content-center">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar un nuevo libro" CssClass="btn btn-primary" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnListar" runat="server" Text="Listar todos los libros" CssClass="btn btn-primary" OnClick="btnListar_Click" />
        </div>

    </div>
    <%-- panel para agregar un nuevo libro --%>
    <asp:Panel ID="pnlAgregar" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtNserie" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtNpaginas" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
                <asp:Button ID="btnAgeragrN" runat="server" Text="Agregar libro" CssClass="btn btn-primary" OnClick="btnAgeragrN_Click" />
                <asp:Label ID="lblMensaNumer" runat="server"></asp:Label>
            </div>
        </div>
    </asp:Panel>

    <%-- panel para listar todos los libros --%>
    <asp:Panel ID="pnlListarLibros" runat="server">

    </asp:Panel>
</asp:Content>
