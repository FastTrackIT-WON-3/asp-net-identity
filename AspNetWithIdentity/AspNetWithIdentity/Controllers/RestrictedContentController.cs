using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWithIdentity.Controllers
{
    [Authorize(Roles = "admin")]
    public class RestrictedContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
