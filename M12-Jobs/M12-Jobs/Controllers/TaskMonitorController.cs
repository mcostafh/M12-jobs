using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M12_Jobs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskMonitorController : ControllerBase
    {

        private readonly ILogger<TaskMonitorController> _logger;

        public TaskMonitorController(ILogger<TaskMonitorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                Message = "Running"
            })
            .ToArray();
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
