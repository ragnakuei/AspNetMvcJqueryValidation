using MvcJqueryValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJqueryValidation.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult IndexPost(TestViewModel viewModel)
        {
            if(ModelState.IsValid == false)
            {
                TempData["Message"] = "驗証失敗";
                return View(viewModel);
            }

            TempData["Message"] = "驗証成功";
            return RedirectToAction("Index");
        }
    }
}