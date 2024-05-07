using Microsoft.AspNetCore.Mvc;

namespace APICallTest.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private static readonly string[] names = new[]
        {
            "Phuc",
            "Thinh An",
            "Minh Anh",
            "Tan",
            "Duong",
            "Kiet",
            "Long",
            "Manh"
        };

        [HttpGet]
        [Route("/names")]
        public JsonResult GetNames() {
            return new JsonResult(names);
        }

        [HttpGet]
        [Route("/datenow")]
        public JsonResult GetDateNow() {
            return new JsonResult(DateTime.Now);
        }
    }
}
