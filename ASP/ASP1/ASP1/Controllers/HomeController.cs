using System;
using Microsoft.AspNetCore.Mvc;

namespace ASP1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
    }
}
