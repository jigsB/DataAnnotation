using MVCPracticeDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPracticeDataAnnotations.Controllers
{
    public class PracticeValidationController : Controller
    {
        // GET: PracticeValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ValidationTest()
        {
            if (ModelState.IsValid)
                return View();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult ValidationTest(dataAnnotationTestModel model)
        {
            //dataAnnotationTestModel model = new dataAnnotationTestModel();
            if (ModelState.IsValid)
                return RedirectToAction("Index");
                //return model;

            return View();
            
        }
    }
}