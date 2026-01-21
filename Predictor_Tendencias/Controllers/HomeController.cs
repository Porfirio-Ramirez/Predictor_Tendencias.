using Aplications.Enums;
using Aplications.Services;
using Aplications.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Predictor_Tendencias.Controllers
{
    public class HomeController : Controller
    {
        private readonly SelectorService _selector;

        public HomeController(SelectorService selector)
        {
            _selector = selector;
        }
        public IActionResult Index()
        {
            return View(new ModoViewModel
            {
                modo = PrediccionConfi.Instance.seleccionarmodo
            });
        }

        [HttpPost]
        public IActionResult CalcularValor(ModoViewModel modo)
        {
            if (modo.fecha.Count != 20 || modo.precio.Count != 20)
            {
                ModelState.AddModelError("", "Tiene que ingresar 20 fechas y 20 precios");
                return View("Index", modo);

            }
            else
            {
                var serie = modo.fecha.Select((d, i) => new Precio
                {
                    fecha = d,
                    precio = modo.precio[i]

                }).ToList();

                
                modo.modo = PrediccionConfi.Instance.seleccionarmodo;
                modo.resultado = _selector.Ejecutar(modo.modo, serie);
            }
            return View("Index", modo);
            {
                
            }
        }
    }
}
