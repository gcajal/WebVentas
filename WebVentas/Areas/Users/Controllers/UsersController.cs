using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebVentas.Areas.Users.Controllers
{
    [Area("Users")]//Especificamos la Area del controlador
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}