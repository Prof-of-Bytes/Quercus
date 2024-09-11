using Microsoft.AspNetCore.Mvc;
using Quercus.Models;
using Quercus.Repos;
using Quercus.Utils;


namespace Quercus.Controllers
{

    public class OaksController : Controller
    {
        private Repository<Oak> data { get; set; }
        public OaksController(TreeContext ctx) => data = new Repository<Oak>(ctx);

        public IActionResult Index() => RedirectToAction("List");

        public ViewResult List(OakGridData values)
        {

            var options = new QueryOptions<Oak>
            {
                PageNumber = values.PageNumber,
                PageSize = values.PageSize,
                OrderByDirection = values.SortDirection,
            };

            if (values.IsSortBySpecies)
            {
                options.OrderBy = a => a.Species;
            }
            else
            {
                options.OrderBy = a => a.PlantId;
            }

            var vm = new OakListViewModel{
                Oaks = data.List(options),
                CurrentRoute = values,
                TotalPages = values.GetTotalPages(data.Count)
            };
            return View(vm);
        }

    }
}



