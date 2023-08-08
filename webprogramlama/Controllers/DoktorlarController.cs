using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Entities;

namespace WebApplication12.Controllers
{
    [Route("Doktorlar")]
    [ApiController]
    public class DoktorlarController : ControllerBase
    {

        private readonly DatabaseContext _context;

        public DoktorlarController(DatabaseContext context)
        {
            _context = context;
        }



        [HttpGet]
        public IActionResult Index()
        {
            
            return Ok(_context.Doktorlar.ToList());
        }


    }
}
