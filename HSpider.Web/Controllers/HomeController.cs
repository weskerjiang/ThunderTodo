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
            List<Comic> comics = _spider.GetAllComics();

            return View(comics);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Comic comic)
        {
            //if (ModelState.IsValid)
            //{
            //    await _spider.AddComic(comic);

            //    return View();
            //}

            return View();
        }

        public IActionResult Import()
        {
            return View();
        }
    }
}