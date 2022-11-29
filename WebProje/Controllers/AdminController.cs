using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System;
using WebProje.Models;
using System.Linq;
using Microsoft.AspNetCore.Authentication;

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment _webHost;

        Context c = new Context();

        public AdminController(ILogger<AdminController> logger, IWebHostEnvironment webHost)
        {
            _logger = logger;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DuyuruAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DuyuruAdd(Duyuru duyuru)
        {
            if (ModelState.IsValid)
            {
                if (duyuru.Resim == null)
                {
                    c.Duyurus.Add(duyuru);
                    c.SaveChanges();
                }
                else if (duyuru.Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(duyuru.Resim.FileName);
                    string extension = Path.GetExtension(duyuru.Resim.FileName);
                    duyuru.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/DuyuruResim/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await duyuru.Resim.CopyToAsync(filestream);
                    }
                    c.Duyurus.Add(duyuru);
                    c.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult DuyuruUpdate(int id)
        {
            var guncelle = c.Duyurus.Find(id);
            return View(guncelle);
        }

        [HttpPost]
        public async Task<IActionResult> DuyuruUpdate(Duyuru duyuru)
        {
            if (ModelState.IsValid)
            {
                if (duyuru.Resim == null)
                {
                    c.Duyurus.Update(duyuru);
                    c.SaveChanges();
                }
                else if (duyuru.Resim != null)
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(duyuru.Resim.FileName);
                    string extension = Path.GetExtension(duyuru.Resim.FileName);
                    duyuru.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Resimler/DuyuruResim/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await duyuru.Resim.CopyToAsync(filestream);
                    }
                    c.Duyurus.Update(duyuru);
                    c.SaveChanges();
                }
            }
            return RedirectToAction("DuyuruAdd", "Admin");
        }

        public IActionResult DuyuruDelete(int id)
        {
            var sil = c.Duyurus.Find(id);
            c.Duyurus.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("DuyuruAdd", "Admin");
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
