<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Admin.Master" AutoEventWireup="true" CodeBehind="Menu_Admin.aspx.cs" Inherits="BibliotecaApp.Vista.Menu_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlAgregar" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtNserie" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtNpaginas" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Button ID="btnAgeragrN" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="btnAgeragrN_Click"/>
                <asp:Label ID="lblMensaNumer" runat="server" ></asp:Label>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
