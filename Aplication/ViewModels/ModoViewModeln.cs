using Aplications.Enums;

namespace Aplications.ViewModels
{
    public class ModoViewModeln
    {
        public List<DateTime> fecha { get; set; } = new();

        public List<double> precio { get; set; } = new();

        public object resultado { get; set; }
        public TipoModon modo { get; set; }
    }
}
