using Microsoft.AspNetCore.Mvc;

namespace VeloSportStore.API.Infrastructure.Controllers
{
    [ApiController]
    [Route("/home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return new ActionResult<string>("Тест");
        }
    }
}
