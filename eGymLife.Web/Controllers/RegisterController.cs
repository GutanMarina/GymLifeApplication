using eGymLife.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using eGymLife.BusinessLogic.Core;
using eGymLife.BusinessLogic.Interfaces;
using eGymLife.BusinessLogic.DBModel;
using eGymLife.Web.Models.Register;
using eGymLife.Domain.Enums;
using eGymLife.Domain.Entities.User;
using eGymLife.Domain.Model;
using eGymLife.BusinessLogic.BlStruct;


namespace eGymLife.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;
        public RegisterController()
        {
            var bl = new BusinessLogicBL();
            _session = bl.GetSessionBL();
        }


        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserRegister model)
        {
            if (ModelState.IsValid)
            {

                var userData = new UDbTable
                {
                    Username = model.Username,
                    Email = model.Email,
                    Password = model.Password,
                    RegistrationDateTime = DateTime.Now,
                    RegistrationIp = Request.UserHostAddress,
                    LastLogin = DateTime.Now, // Inițializare corectă
                    Level = URole.User // Setare rol implicit
                };

                _session.UserRegister(userData); // Metoda doar salvează userul

                return RedirectToAction("Register");
            }

            return View(model);
        }

    }
}