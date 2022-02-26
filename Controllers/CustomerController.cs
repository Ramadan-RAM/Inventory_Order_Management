﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Order_Managemen.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Customer.RoleName)]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}