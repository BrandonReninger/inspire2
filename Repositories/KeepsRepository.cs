using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Dapper;

namespace Keepr.Repositories
{
    public class WeatherRepository
    {
        private readonly IDbConnection _db;

        public WeatherRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Weather> Get()
        {
            string sql = "SELECT * FROM Keeps WHERE isPrivate = 0;";
            return _db.Query<Weather>(sql);
        }

        internal Weater Create(Weather KeepData)
        {
            throw new NotImplementedException();
        }
    }
}