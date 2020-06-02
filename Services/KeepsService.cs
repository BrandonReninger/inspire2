using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
    public class WeatherService
    {
        private readonly WeatherRepository _repo;
        public WeatherService(WeatherRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Weather> Get()
        {
            return _repo.Get();
        }

        public Weather Create(Weather newWeather)
        {
            return _repo.Create(newWeather);
        }
    }
}