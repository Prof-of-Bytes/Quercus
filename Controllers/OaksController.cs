using Microsoft.AspNetCore.Mvc;
using PlantOpedia.Models;
using PlantOpedia.Models.Domain;

namespace PlantOpedia.Controllers{

    public class OaksController : Controller{

        private TreeContext _context {get; set;} 

        public OaksController(TreeContext ctx) {
            _context = ctx;
        }

        public IActionResult List(){
           var oaks  = _context.Oaks.ToList().Take(50);
           return View(oaks);
        }
    }



}