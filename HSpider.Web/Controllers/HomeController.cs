using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HSpider.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace HSpider.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly HSpiderContext _context;

        public HomeController(HSpiderContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Comic comic)
        {
            if (ModelState.IsValid)
            {
                _context.Comics.Add(comic);
                await _context.SaveChangesAsync();

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