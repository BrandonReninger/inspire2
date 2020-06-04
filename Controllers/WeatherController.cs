using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
// using Inspire2.Models;
// using Inspire2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Inspire2.Controllers
{
    public class Weather
    {
        public decimal Temp { get; set; }
        public string Icon { get; set; }
        public decimal Wind { get; set; }
        public int Humidity { get; set; }
        public decimal FeelsLike { get; set; }
        public decimal UV { get; set; }
    }

    [Route("api[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            string url = "http://api.weatherapi.com/v1/current.json?key=81b8c7586a6c4d5ab5360439200206&q=83709";
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }

}