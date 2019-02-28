using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HSpider.Web.Models;
using HSpider.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace HSpider.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpiderService _spider;

        public HomeController(ISpiderService spider)
        {
            _spider = spider;
        }

        public IActionResult Index()
        {
            List<Comic> comics = _spider.GetAllComics().Where(c => c.Downloaded == 0).ToList();

            return View(comics);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Comic comic)
        {
            if (ModelState.IsValid)
            {
                _spider.AddComic(comic);

                return View();
            }

            return View();
        }

        public IActionResult Import()
        {
            return View();
        }
    }
}