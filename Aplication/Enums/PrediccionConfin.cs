namespace Aplications.Enums
{
    public class PrediccionConfin
    {
        private static PrediccionConfin _instance;

        public TipoModon seleccionarmodo { get; set; } = TipoModon.Sma;

        public static PrediccionConfin Instance =>
            _instance ??= new PrediccionConfin();
        


    }
}
