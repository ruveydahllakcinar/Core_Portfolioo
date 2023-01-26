﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.v1 = "Update About";
            ViewBag.v2 = "About";
            ViewBag.v3 = "Update About";
            ViewBag.v4 = "/Feature/Index";
            var values = aboutManager.TGetByID(1);
            return View(values);
        }


        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");

        }
    }
}
