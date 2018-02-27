using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eighty.Bench.WebApp.Models;
using System.IO;
using System.Text;
using Eighty.Twenty;
using System.Collections.Immutable;

namespace Eighty.Bench.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Model _model = new Model(1000, "foo<>");

        public IActionResult Empty()
        {
            return NoContent();
        }

        public IActionResult Razor()
        {
            return View(_model);
        }

        public IActionResult Eighty()
        {
            return View(_model);
        }

        public IActionResult EightyAsync()
        {
            ViewData["RenderAsync"] = true;
            return View(_model);
        }

        public IActionResult Twenty()
        {
            return View(_model);
        }
    }


}
