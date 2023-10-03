public class SeguroVehiculo
{
    public decimal ValorComercial { get; set; }
    public int ReclamacionesAnteriores { get; set; }

    public decimal CalcularTarifaBase()
    {
        return ValorComercial * 0.05m;
    }

    public decimal CalcularIncremento()
    {
        decimal incremento = 0;
        switch (ReclamacionesAnteriores)
        {
            case 1:
                incremento = CalcularTarifaBase() * 0.05m;
                break;
            case 2:
                incremento = CalcularTarifaBase() * 0.15m;
                break;
            case 3:
                incremento = CalcularTarifaBase() * 0.30m;
                break;
            default:
                incremento = CalcularTarifaBase() * 0.50m;
                break;
        }
        return incremento;
    }

    public decimal CalcularTotal()
    {
        decimal tarifaBase = CalcularTarifaBase();
        decimal incremento = CalcularIncremento();
        decimal totalAntesIVA = tarifaBase + incremento;
        decimal iva = totalAntesIVA * 0.19m;
        decimal totalPagar = totalAntesIVA + iva;
        return totalPagar;
    }
}
