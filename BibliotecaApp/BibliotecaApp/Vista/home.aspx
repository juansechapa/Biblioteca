<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BibliotecaApp.Vista.principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Principal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMensajee" runat="server"></asp:Label>
        </div>
        <div class="container">
            <div class="row justify-content-around">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click"/>
                <asp:Button ID="btnVerLibros" runat="server" Text="Ver libros" CssClass="btn btn-primary" OnClick="btnVerLibros_Click" />
                <asp:Button ID="btnPerfil" runat="server" Text="Perfil" CssClass="btn btn-primary" OnClick="btnPerfil_Click"/>
                <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesion" CssClass="btn btn-primary" OnClick="btnCerrarSesion_Click"/>
            </div>
        </div>

        <%-- Panel buscar Libros --%>
        <asp:Panel ID="pnlBuscar" runat="server">
            <div class="container">
                <div class=" row justify-content-center">
                    <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnBusqueda" runat="server" Text="buscar" OnClick="btnBusqueda_Click"/>
                </div>
            </div>
        </asp:Panel>
        <%-- Panel del perfil del usuario --%>
        <asp:Panel ID="pnlPerfil" runat="server">
            <div class="container">
                <div class="row justify-content-center">


                </div>
            </div>
        </asp:Panel>
    </form>
</body>
</html>
