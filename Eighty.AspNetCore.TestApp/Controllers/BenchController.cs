using Eighty.AspNetCore.TestApp.Models;

using Microsoft.AspNetCore.Mvc;

namespace Eighty.AspNetCore.TestApp.Controllers;

public class BenchController : Controller
{
    private static readonly BenchModel _model = new(1000, "foo<>");

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


