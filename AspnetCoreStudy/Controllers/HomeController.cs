using AspnetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var firstUser = new User();
            //firstUser.UserNo = 1;
            //firstUser.UserName = "홍길동";

            var hongUser = new User
            {
                UserNo = 1,
                UserName = "홍길동"
            };

            // # 1번째 방식 View(model)
            // return View(hongUser);

            // # 2번째 방식 ViewBAg
            ViewBag.User = hongUser;

            // # 3번째 방식 ViewData
            ViewData["UserNo"] = hongUser.UserNo;
            ViewData["UserName"] = hongUser.UserName;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
