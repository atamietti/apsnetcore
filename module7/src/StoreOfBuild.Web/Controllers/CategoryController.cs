﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Domain.Dto;
using StoreOfBuild.Web.Models;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            // ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryDto category)
        {
            // ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}