using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corportal.Controllers
{
    [Route("Chat")]
    public class ChatController : Controller
    {
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Index")]
        [HttpPost]
        public IActionResult Index(int id = 0)
        {
            return View();
        }

        [Route("Graduate")]
        [HttpGet]
        public IActionResult Graduate()
        {
            return View();
        }

        [Route("Graduate")]
        [HttpPost]
        public IActionResult Graduate(int id = 0)
        {
            return View();
        }

        [Route("Money")]
        [HttpGet]
        public IActionResult Money()
        {
            return View();
        }

        [Route("Money")]
        [HttpPost]
        public IActionResult Money(int id = 0)
        {
            return View();
        }
    }
}
