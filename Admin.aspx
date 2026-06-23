<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="proyectito2.Admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Panel de Administración - Gestión de Psicólogos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f5f7fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .navbar-custom {
            background-color: #0f172a; /* Slate oscuro */
        }
        .card-custom {
            border: none;
            border-radius: 10px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.03);
        }
        .btn-teal {
            background-color: #20b8a6; /* Esmeralda/Teal profesional */
            color: white;
            font-weight: bold;
            border: none;
        }
        .btn-teal:hover {
            background-color: #0d9488;
            color: white;
        }
        .grid-header {
            background-color: #0f172a !important;
            color: white !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-custom navbar-dark mb-4 shadow-sm">
            <div class="container-fluid px-4">
                <a class="navbar-brand fw-bold" href="#">MindUp Admin</a>
                <div class="navbar-text text-white">
                    Bienvenido, <asp:Label ID="lblNombreAdmin" runat="server" Font-Bold="true"></asp:Label>
                </div>
            </div>
        </nav>

        <div class="container-fluid px-4">
            <div class="row">
                <div class="col-md-4 mb-4">
                    <div class="card card-custom p-4 bg-white">
                        <h4 class="fw-bold mb-3" style="color: #0f172a;">Registrar Nuevo Psicólogo</h4>
                        
                        <div class="mb-3">
                            <label class="form-label fw-semibold">Nombre Completo:</label>
                            <asp:TextBox ID="txtNombrePsico" runat="server" CssClass="form-control" placeholder="Ej. Juan Pérez"></asp:TextBox>
                        </div>

                        <div class="mb-3">
                            <label class="form-label fw-semibold">Correo de Acceso:</label>
                            <asp:TextBox ID="txtUserPsico" runat="server" CssClass="form-control" placeholder="usuario@correo.com" TextMode="Email"></asp:TextBox>
                        </div>

                        <div class="mb-4">
                            <label class="form-label fw-semibold">Contraseña:</label>
                            <asp:TextBox ID="txtPassPsico" runat="server" CssClass="form-control" placeholder="••••••••" TextMode="Password"></asp:TextBox>
                        </div>

                        <asp:Button ID="btnGuardarPsico" runat="server" Text="Registrar Psicólogo" CssClass="btn btn-teal w-100 py-2 shadow-sm" OnClick="btnGuardarPsico_Click" />
                    </div>
                </div>

                <div class="col-md-8 mb-4">
                    <div class="card card-custom p-4 bg-white">
                        <h4 class="fw-bold mb-3" style="color: #0f172a;">Psicólogos Registrados en el Sistema</h4>
                        
                        <div class="table-responsive">
                            <asp:GridView ID="dgvPsicologos" runat="server" CssClass="table table-bordered table-hover align-middle m-0" AutoGenerateColumns="true">
                                <HeaderStyle CssClass="grid-header" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>