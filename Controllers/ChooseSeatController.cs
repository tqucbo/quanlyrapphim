using Microsoft.AspNetCore.Mvc;

namespace QuanLyRapPhim.Controllers
{
    public class ChooseSeatController : Controller
    {
        [Route("/chooseseat/{filmScheduleId}")]
        public IActionResult Index(string filmScheduleId)
        {
            return View(filmScheduleId);
        }
    }
}