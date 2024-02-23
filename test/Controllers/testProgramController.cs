using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test.Data;
using test.Services;

namespace test.Controllers
{
    public class testProgramController : Controller
    {
        UserFormsupportContext db = new UserFormsupportContext();
        apiService api = new apiService();
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult saveRegister(UserRegister register)
        {
            if (register != null)
            {
                db.UserRegister.Add(register);
                db.SaveChanges();
            }
            return RedirectToAction("Register");
        }

        public IActionResult PrimeNumber() 
        { 
            return View();
        }

    }
}
