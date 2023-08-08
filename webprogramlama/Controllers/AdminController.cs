using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Entities;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {

        private readonly DatabaseContext _databaseContext;

        public AdminController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DoktorViewModel model)
        {
            if (ModelState.IsValid) {
                Doktor doktor = new Doktor()
                {
                    NameSurname=model.NameSurname,
                    poliklinik=model.poliklinik

                };

                _databaseContext.Doktorlar.Add(doktor);
                _databaseContext.SaveChanges();
                 
            }

           


                return View(model);
        }

    }
}
