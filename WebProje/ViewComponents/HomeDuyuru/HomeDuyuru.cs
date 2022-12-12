using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProje.Models;

namespace WebProje.ViewComponents.HomeDuyuru
{
    public class HomeDuyuru : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var d = c.Duyurus.ToList();
            return View(d);
        }
    }
}