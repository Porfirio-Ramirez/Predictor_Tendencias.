using Aplications.Dtos;
using Aplications.Interfaces;
using Aplications.ViewModels;

namespace Aplications.Services
{
    public class RocServicen : Icalculon
    {
        public object calcular(List<Precion> precios)
        {
            var ordenar = precios.OrderBy(x => x.fecha).ToList();

            var elementos = new List<(DateTime, double, double?)>();

            for (int i = 0; i < ordenar.Count; i++)
            {
                if (i < 5)
                    elementos.Add((ordenar[i].fecha, ordenar[i].precio, null));
                else
                {
                    var roc = ((ordenar[i].precio / ordenar[i - 5].precio) - 1) * 100;
                    elementos.Add((ordenar[i].fecha, ordenar[i].precio, Math.Round(roc, 2)));
                }
            }

            return new Rocdton
            {
                elemento = elementos,
                tendencia = elementos.Last().Item3 > 0 ? "Alcista" : "Bajista"
            };
        }
    }
}
