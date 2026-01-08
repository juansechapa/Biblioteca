<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Menu.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="BibliotecaApp.Vista.Principal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Panel buscar Libros --%>
    <asp:Panel ID="pnlBuscar" runat="server">
        <div class="container">
            <div class=" row justify-content-center">
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Button ID="btnBusqueda" runat="server" Text="buscar" OnClick="btnBusqueda_Click" />
            </div>
        </div>
    </asp:Panel>



    <%-- Panel del perfil del usuario --%>
    <asp:Panel ID="pnlPerfil" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <h5>Mi perfil</h5>

            </div>
        </div>
    </asp:Panel>
</asp:Content>
