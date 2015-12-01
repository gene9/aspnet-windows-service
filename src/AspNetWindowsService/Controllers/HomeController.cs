using Microsoft.AspNet.Mvc;
using System;
using Microsoft.Extensions.PlatformAbstractions;
using MyDnxService.Models;

namespace MyDnxService
{
    public class HomeController : Controller
    {
        private readonly IApplicationEnvironment appEnvironment;

        public HomeController(IApplicationEnvironment appEnvironment)
        {
            this.appEnvironment = appEnvironment;
        }

        [Route("")]
        public IActionResult Index()
        {
            //return View("~/Views/Home/Index.cshtml", new Example
            return View("Index", new Example
            {
                Text = DateTime.Now.ToLongDateString()
            });
        }
    }
}
