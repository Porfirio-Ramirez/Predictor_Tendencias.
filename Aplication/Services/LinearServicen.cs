using Aplications.Dtos;
using Aplications.Interfaces;
using Aplications.ViewModels;

namespace Aplications.Services
{
    public class LinearServicen : Icalculon
    {
        public object calcular(List<Precion> precios)
        {
            var ordenar = precios.OrderBy(x => x.fecha).ToList();

            int n = ordenar.Count;

            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += i + 1;
                sumY += (double)ordenar[i].precio;
                sumXY += (i + 1) * (double)ordenar[i].precio;
                sumX2 += Math.Pow(i + 1, 2);
            }

            double m = (n * sumXY - sumX * sumY) /
                       (n * sumX2 - Math.Pow(sumX, 2));
            double b = (sumY - m * sumX) / n;

            return new Lineardton
            {
                fechas = ordenar.Last().fecha.AddDays(1),
                valor = Math.Round((double)(m * (n + 1) + b), 2),
                tendencia = m > 0 ? "Alcista" : "Bajista"
            };
        }
    }
}
