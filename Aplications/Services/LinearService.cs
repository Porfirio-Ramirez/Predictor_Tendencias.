using Aplications.Dtos;
using Aplications.Interfaces;
using Aplications.ViewModels;

namespace Aplications.Services
{
    public class LinearService : Icalculo
    {
        public object calcular(List<Precio> precios)
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

            var ultimo = ordenar.Last();

            return new Lineardto
            {
                Pendiente = Math.Round(m, 4),
                Interseccion = Math.Round(b, 4),
                ValorProyectado = Math.Round(m * (n + 1) + b, 2),
                FechaProyectada = ultimo.fecha.AddDays(1),
                tendencia = m > 0 ? "Alcista" : "Bajista"
            };

        }
    }
}
