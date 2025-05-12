using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Controllers
{
    [Route("bands")]
    public class BandsController : Controller
    {
        BandService bandService = new BandService();

        [Route("")]
        public IActionResult Index()
        {
            var model = bandService.GetAllBands();
            return View(model);
        }
    }
}
