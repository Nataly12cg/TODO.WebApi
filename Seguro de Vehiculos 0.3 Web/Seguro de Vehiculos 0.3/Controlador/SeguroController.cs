using System;
using System.Web.UI;
using Newtonsoft.Json;

public partial class SeguroController : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Este controlador solo se utiliza para recibir datos del cliente.
        // No es necesario realizar ninguna acción en Page_Load.
    }

    protected void CalcularButton_Click(object sender, EventArgs e)
    {
        // Obtiene los valores de los controles de servidor
        decimal valorComercial = Convert.ToDecimal(Request.Form["ValorComercialTextBox"]);
        int reclamacionesAnteriores = Convert.ToInt32(Request.Form["ReclamacionesAnterioresTextBox"]);

        // Realiza los cálculos
        decimal tarifaBase = valorComercial * 0.05M;
        decimal incremento = 0;

        if (reclamacionesAnteriores == 1)
        {
            incremento = tarifaBase * 0.05M;
        }
        // Continúa con los demás cálculos

        // Calcula el valor total
        decimal totalAntesDeIVA = tarifaBase + incremento;
        decimal valorIVA = totalAntesDeIVA * 0.19M;
        decimal totalAPagar = totalAntesDeIVA + valorIVA;

        // Crea un objeto Seguro para enviar al cliente
        var seguro = new
        {
            ValorBase = tarifaBase,
            Incremento = incremento,
            TotalAntesDeIVA = totalAntesDeIVA,
            ValorIVA = valorIVA,
            TotalAPagar = totalAPagar
        };

        // Serializa el objeto Seguro a JSON y lo envía al cliente
        Response.ContentType = "application/json";
        Response.Write(JsonConvert.SerializeObject(seguro));
        Response.End();
    }
}
