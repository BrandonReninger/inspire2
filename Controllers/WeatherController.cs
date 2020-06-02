using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Keepr.Models;
using Keepr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keepr.Controllers
{
    [ApiController]
    [Route("api/[https://www.weatherapi.com/docs/#]")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _ws;
        public KeepsController(WeatherService ws)
        {
            _ws = ws;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Weather>> Get()
        {
            try
            {
                return Ok(_ws.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            };
        }

        [HttpPost]
        [Authorize]
        public ActionResult<Weather> Post([FromBody] Keep newKeep)
        {
            try
            {
                var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                newWeather.UserId = userId;
                return Ok(_ws.Create(newWeather));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}