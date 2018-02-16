using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Massena.DataTables.Query.Extensions.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Api.Models;
using Sample.Api.Repository;

namespace Sample.Api.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class CityController : Controller
    {
        private ICityRepository CityRepo;

        public CityController(ICityRepository cityRepository) => CityRepo = cityRepository;


        [HttpGet]
        [Route("city/{name}")]
        public City ByName(string name)
        {
            return CityRepo.GetCityByName(name);
        }

        [HttpGet]
        [Route("cities/of/{uf}")]
        public IEnumerable<City> GetStateCities(string uf)
        {
            return CityRepo.GetCities(uf);
        }

        [HttpPost]
        [Route("cities/list")]
        public DataTablesResponse<City> ListStateCities([FromBody] ListCitiesByStateQuery query)
        {
            return CityRepo.GetCitiesFiltered(query);
        }
    }
}