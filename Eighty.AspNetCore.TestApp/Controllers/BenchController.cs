using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eighty.Test.WebApp.Models;
using System.IO;
using System.Text;
using Eighty.Twenty;
using System.Collections.Immutable;

namespace Eighty.Test.WebApp.Controllers
{
    public class BenchController : Controller
    {
        private static readonly BenchModel _model = new BenchModel(1000, "foo<>");

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
