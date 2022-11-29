using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProje.Models;

namespace WebProje.ViewComponents.DuyuruListele
{
    public class DuyuruListele : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var d = c.Duyurus.ToList();
            return View(d);
        }
    }
}
