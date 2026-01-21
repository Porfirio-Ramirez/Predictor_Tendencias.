using Aplications.Enums;
using Aplications.ViewModels;

namespace Aplications.Services
{
    public class SelectorService
    {
        private readonly SmaService _sma;
        private readonly LinearService _linear;
        private readonly RocService _Roc;

        public SelectorService(
            SmaService sma,
            LinearService linear,
            RocService roc)
            
            {
            _sma = sma;
            _linear = linear;
            _Roc = roc;

            }


        public object Ejecutar(TipoModo modo, List<Precio> precios)
        {
            switch (modo)
            {
                case TipoModo.Sma:
                    return _sma.calcular(precios);

                case TipoModo.RegresionLinear:
                    return _linear.calcular(precios);

                case TipoModo.Roc:
                    return _Roc.calcular(precios);

                default:
                    return "Modo no soportado";


            }
        }
            
            

            
    }
}
