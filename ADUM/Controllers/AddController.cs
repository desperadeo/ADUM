using ADUM.Models;
using ADUM.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Controllers
{
    public class AddController : Controller
    {
        private readonly IAddRepository _addRepository;

        public AddController(IAddRepository addRepository)
        {
            _addRepository = addRepository;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Token token)
        {
            // CHECK IF FORM IS EMPTY
        if(ModelState.IsValid)
            {
                _addRepository.CreateToken(token);
                return RedirectToAction("ConfirmCreate");
            }
        else
            {
                return View();
            }

        }

        public IActionResult ConfirmCreate()
        {
            return View();
        }

    }
}
