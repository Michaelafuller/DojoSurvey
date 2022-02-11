using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("survey")]
        public IActionResult Form(string Name, string DojoLocation, string FaveLanguage, string Comment)
        {
            ViewBag.Name =  Name;
            ViewBag.DojoLocation =  DojoLocation;
            ViewBag.FaveLanguage =  FaveLanguage;
            ViewBag.Comment =  Comment;
            return View("Results");
        }
    }
}