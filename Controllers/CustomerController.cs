using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud1.Models;

namespace Crud1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _s;
        public CustomerController(ApplicationDbContext s)
        {
            _s = s;
        }
        public IActionResult Index()
        {
            var id = _s.Customers.ToList();
            return View(id);
        }
    }
}
