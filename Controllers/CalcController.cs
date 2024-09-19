using LAB_3.Services;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("Calc")]
    public class CalcController : Controller
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("Add")]
        public IActionResult Add(int a, int b)
        {
            var result = _calcService.Add(a, b);
            return Content($"Результат додавання: {result}");
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(int a, int b)
        {
            var result = _calcService.Subtract(a, b);
            return Content($"Результат віднімання: {result}");
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return Content($"Результат множення: {result}");
        }

        [HttpGet("Divide")]
        public IActionResult Divide(int a, int b)
        {
            if (b == 0)
            {
                return Content("Помилка: на нуль ділити не можна");
            }
            var result = _calcService.Divide(a, b);
            return Content($"Результат ділення: {result}");
        }
    }
}
