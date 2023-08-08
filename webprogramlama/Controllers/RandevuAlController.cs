using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication12.Entities;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    [Authorize]
    public class RandevuAlController : Controller
    {
        private readonly ILogger<RandevuAlController> _logger;
        private readonly DatabaseContext _context;

        public RandevuAlController(ILogger<RandevuAlController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public JsonResult Doktor_Gösterim(int ID)
        {
            var state = _context.Doktorlar.Where(w => w.PoliklinikId == ID);
            return Json(new SelectList(state, "Id", "NameSurname"));
        }


        public IActionResult RandevuAl()
        {
            ViewBag.Doktorlar=new SelectList(_context.Doktorlar.ToList(),"Id", "NameSurname");

            return View();
        }






        /*
        private readonly DatabaseContext _databaseContext;

        public RandevuAlController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        public IActionResult RandevuAl()
        {
            return View();
        }


        [HttpPost]
        public IActionResult RandevuAl(RandevuViewModel model)
        {
            if (ModelState.IsValid)
            {
                Randevu randevu = new Randevu()
                {
                    hastaAdi = model.hastaAdi,
                    poliklinik = model.poliklinik,
                    doktor=model.doktor,
                    gün=model.gün
                };

                _databaseContext.Randevular.Add(randevu);
                _databaseContext.SaveChanges();

            }

            return View(model);
        }*/
    }
}
