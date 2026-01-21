using Aplications.Enums;
using Aplications.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Predictor_Tendencias.Controllers
{
    public class ModoController : Controller
    {
        public IActionResult Index()
        {
            return View(new Selector_ModoViewModel
            {
                GetTipoModo = PrediccionConfi.Instance.seleccionarmodo
            });
        }

        [HttpPost]
        public IActionResult Index(Selector_ModoViewModel modoView)
        {
            
           PrediccionConfi.Instance.seleccionarmodo = modoView.GetTipoModo;
           
            return RedirectToAction("Index");
        }
    }
}
