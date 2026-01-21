using Aplications.Enums;
using Aplications.ViewModels;

namespace Aplications.Services
{
    public class SelectorServicen
    {
        private readonly SmaServicen _sma;
        private readonly LinearServicen _linear;
        private readonly RocServicen _Roc;

        public SelectorServicen(
            SmaServicen sma,
            LinearServicen linear,
            RocServicen roc)
            
            {
            _sma = sma;
            _linear = linear;
            _Roc = roc;

            }


        public object Ejecutar(TipoModon modo, List<Precion> precios)
        {
            switch (modo)
            {
                case TipoModon.Sma:
                    return _sma.calcular(precios);

                case TipoModon.RegresionLinear:
                    return _linear.calcular(precios);

                case TipoModon.Roc:
                    return _Roc.calcular(precios);

                default:
                    return "Modo no soportado";


            }
        }
            
            

            
    }
}
