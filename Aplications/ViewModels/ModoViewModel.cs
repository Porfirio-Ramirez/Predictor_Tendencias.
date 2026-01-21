using Aplications.Enums;

namespace Aplications.ViewModels
{
    public class ModoViewModel
    {
        public List<DateTime> fecha { get; set; } = new();

        public List<double> precio { get; set; } = new();

        public object resultado { get; set; }
        public TipoModo modo { get; set; }
    }
}
