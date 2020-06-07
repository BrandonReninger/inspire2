using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        static HttpClient client = new HttpClient();

        static async Task<Weather> GetProductAsync(string path)
        {
            Weather weather = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                weather = await response.Content.ReadAsAsync<Weather>();
            }
            return weather;
        }
    }

}