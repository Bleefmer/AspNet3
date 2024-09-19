using LAB_3.Services;
using Microsoft.AspNetCore.Mvc;


namespace YourNamespace.Controllers
{
    [Route("Time")]
    public class TimeController : Controller
    {
        private readonly TimeService _timeService;

        public TimeController(TimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpGet("CurrentTime")]
        public IActionResult CurrentTime()
        {
            var timeOfDay = _timeService.GetCurrentTimeOfDay();
            return Content($"Зараз {timeOfDay}");
        }
    }
}
