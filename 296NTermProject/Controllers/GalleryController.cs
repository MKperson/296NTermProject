﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _296NTermProject.Controllers
{
    public class GalleryController : Controller
    {
        [Authorize(Roles = "Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}