<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="proyectito2.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar Sesión - MindUp</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f5f7fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .card-login {
            border: none;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.05);
        }
        .btn-custom {
            background-color: #14b8a6; /* Color Teal profesional */
            color: white;
            font-weight: bold;
            border: none;
        }
        .btn-custom:hover {
            background-color: #0d9488;
            color: white;
        }
    </style>
</head>
<body class="d-flex align-items-center justify-content-center vh-100">
    <form id="form1" runat="server" class="w-100" style="max-width: 400px;">
        <div class="card card-login p-4">
            <div class="text-center mb-4">
                <h2 class="fw-bold text-dark m-0">MindUp</h2>
                <small class="text-muted">Plataforma de Gestión Clínica</small>
            </div>

            <div class="mb-3">
                <label for="txtEmail" class="form-label fw-semibold">Correo Electrónico</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="nombre@correo.com" TextMode="Email"></asp:TextBox>
            </div>

            <div class="mb-4">
                <label for="txtPassword" class="form-label fw-semibold">Contraseña</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="••••••••" TextMode="Password"></asp:TextBox>
            </div>

            <div class="mb-2">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar al Sistema" CssClass="btn btn-custom w-100 py-2" OnClick="btnIngresar_Click" />
            </div>

            <div class="text-center mt-2">
                <asp:Label ID="lblMensajeError" runat="server" ForeColor="Red" Font-Size="Small" Font-Bold="true"></asp:Label>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>