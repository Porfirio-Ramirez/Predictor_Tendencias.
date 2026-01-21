namespace Aplications.Enums
{
    public class PrediccionConfi
    {
        private static PrediccionConfi _instance;

        public TipoModo seleccionarmodo { get; set; } = TipoModo.Sma;

        public static PrediccionConfi Instance =>
            _instance ??= new PrediccionConfi();
        


    }
}
