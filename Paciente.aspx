<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="proyectito2.Paciente" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Portal del Paciente - MindUp</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f5f7fa;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .navbar-custom {
            background-color: #0d9488; /* Color Teal/Esmeralda característico de tu proyecto */
        }
        .card-custom {
            border: none;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.04);
        }
        .grid-header {
            background-color: #0d9488 !important;
            color: white !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-custom navbar-dark mb-4 shadow-sm">
            <div class="container-fluid px-4">
                <a class="navbar-brand fw-bold" href="#">MindUp Pacientes</a>
                <div class="navbar-text text-white">
                    Bienvenido, <asp:Label ID="lblNombrePaciente" runat="server" Font-Bold="true"></asp:Label>
                </div>
            </div>
        </nav>

        <div class="container px-4">
            <div class="p-4 mb-4 bg-white card-custom">
                <h2 class="fw-bold text-dark mb-2">Encuentra a tu especialista ideal</h2>
                <p class="text-muted m-0">A continuación, te mostramos el catálogo de psicólogos activos y calificados dentro de nuestra plataforma con los que puedes iniciar un proceso de atención.</p>
            </div>

            <div class="card card-custom p-4 bg-white">
                <h4 class="fw-bold mb-3" style="color: #0d9488;">Especialistas Disponibles</h4>
                
                <div class="table-responsive">
                    <asp:GridView ID="dgvPsicologosDisponibles" runat="server" CssClass="table table-bordered table-hover align-middle m-0" AutoGenerateColumns="true">
                        <HeaderStyle CssClass="grid-header" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>