<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaApp.Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-around">
                <div class="col-md-4"></div>
                <asp:Button ID="bntInicarSecion" runat="server" Text="Iniciar sesion" CssClass="btn btn-primary" OnClick="bntInicarSesion_Click" />
                <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" CssClass="btn btn-primary" OnClick="btnRegistrarse_Click" />
            </div>
        </div>

        <asp:Panel ID="pnlLogin" runat="server">
            <div class="container mt-5">
                <div class="row justify-content-center">
                    <div class="col-md-4">
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>

                        <asp:Button ID="btnLogin" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                        <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
                    </div>
                </div>
            </div>
        </asp:Panel>
        <%-- panel de registro --%>

        <asp:Panel ID="pnlRegistro" runat="server">
            <div class="container mt-5">
                <div class="row justify-content-center">
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="txtCorreo_Registro" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:TextBox ID="txtContraseña_Registro" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnRegistrar" runat="server" Text="Registrarme" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" />
                        <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-primary" OnClick="btnVolver_Click" />
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </asp:Panel>

    </form>
</body>
</html>
