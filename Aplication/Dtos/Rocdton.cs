namespace Aplications.Dtos
{
    public class Rocdton
    {
        public List<(DateTime fechas, double precio, double? Roc)> elemento { get; set; }
        public string tendencia { get; set; }
    }
}
