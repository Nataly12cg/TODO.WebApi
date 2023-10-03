using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Seguro_de_Vehiculos_0._3.Paginas
{
    public partial class CalcularSeguro : Page
    {
        protected void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal valorComercial = 0;
            int reclamacionesAnteriores = 0;

            if (decimal.TryParse (ValorComercialTextBox.Text,out valorComercial) && int.TryParse (ReclamacionesAnterioresTextBox.Text, out reclamacionesAnteriores))
            {
                {
                    decimal tarifaBase = valorComercial * 0.05M;
                    decimal incremento = 0;

                    if (reclamacionesAnteriores == 1)
                    {
                        incremento = tarifaBase * 0.05M;
                    }
                    // Continúa con los demás cálculos

                    decimal totalAntesDeIVA = tarifaBase + incremento;
                    decimal valorIVA = totalAntesDeIVA * 0.19M;
                    decimal totalAPagar = totalAntesDeIVA + valorIVA;

                    var resultado = new
                    {
                        ValorBase = tarifaBase,
                        Incremento = incremento,
                        TotalAntesDeIVA = totalAntesDeIVA,
                        ValorIVA = valorIVA,
                        TotalAPagar = totalAPagar
                    };

                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(resultado));
                    Response.End();
                }
            }
        }
    }   }