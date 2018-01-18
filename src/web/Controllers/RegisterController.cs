using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                //ViewData["register.txt_Mobile"] = "092224955";
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Information(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                ViewData["register.txt_CardNo"] = registerModel.txt_CardNo;
                ViewData["register.txt_CardID"] = registerModel.txt_CardID;
                ViewData["register.txt_BirthDate"] = registerModel.txt_BirthDate;
                ViewData["register.txt_Mobile"] = "092224955";

            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ConfirmOTP(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                ViewData[""] = "";
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Success(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                ViewData[""] = "";
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
