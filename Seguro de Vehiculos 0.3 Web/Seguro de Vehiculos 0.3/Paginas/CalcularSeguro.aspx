<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora de Seguro de Vehículos</title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Calculadora de Seguro de Vehículos</h1>
            <div class="input-group">
                <label for="ValorComercialTextBox">Valor Comercial del Vehículo:</label>
                <asp:TextBox ID="ValorComercialTextBox" runat="server" CssClass="form-control" placeholder="Valor Comercial del Vehículo"></asp:TextBox>
            </div>
            <div class="input-group">
                <label for="ReclamacionesAnterioresTextBox">Número de Reclamaciones Anteriores:</label>
                <asp:TextBox ID="ReclamacionesAnterioresTextBox" runat="server" CssClass="form-control" placeholder="Número de Reclamaciones Anteriores"></asp:TextBox>
            </div>
            <asp:Button ID="CalcularButton" runat="server" Text="Calcular Seguro" OnClick="CalcularButton_Click" CssClass="btn btn-primary" />
            <div id="resultado" class="mt-3"></div>
        </div>
    </form>
</body>
</html>
