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

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IWebHostEnvironment _webHost;


        public AdminController(ILogger<AdminController> logger, IWebHostEnvironment webHost)
        {
            _logger = logger;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DuyurularListele()
        {
            return View();
        }

        public IActionResult DuyuruAdd()
        {
            return View();
        }

        public IActionResult DuyuruUpdate(int id)
        {
            return View();
        }

        public IActionResult DuyuruDelete(int id)
        {
            return View();
        }

        public IActionResult MesajKutusu()
        {
            return View();
        }

        public IActionResult AdminMesajDetails(int? id)
        {
            return View();
        }

        public IActionResult UserMesajDetails(int? id)
        {
            return View();
        }

        public IActionResult AdminMesajSil(int id)
        {
            return View();
        }

        public IActionResult UserMesajSil(int id)
        {
            return View();
        }

        public IActionResult Profilim()
        {
            return View();
        }

        public IActionResult ProfilDuzenle()
        {
            return View();
        }
       
        // anasayfa düzenleme
        public IActionResult IletisimBilgileri()
        {
            return View();
        }

        public IActionResult FooterDuzenle()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
