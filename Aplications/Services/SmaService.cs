using Aplications.Dtos;
using Aplications.Interfaces;
using Aplications.ViewModels;

namespace Aplications.Services
{
    public class SmaService : Icalculo
    {
        public object calcular(List<Precio> precios)
        {
            var ordenar = precios.OrderByDescending(x => x.fecha).Take(20).ToList();

            var smacorta = ordenar.Take(5).Average(x => x.precio);
            var smalarga = ordenar.Average(x => x.precio);

            return new Smadto
            {
                smacorta = Math.Round(smacorta, 2),
                smalarga = Math.Round(smalarga, 2),
                tendencia = smacorta > smalarga ? "Alcisa" : "Bajista"


            };

        }
    }
}
