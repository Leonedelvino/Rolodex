using Microsoft.AspNetCore.Mvc;
using Rolodex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolodex.Controllers
{
    public class RolodexController : Controller
    {
        private readonly RolodexContext db;

        public RolodexController(RolodexContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return this.View();
        }
        
        public IActionResult Topics()
        {
            return this.View();
        }
    }
}
