using Massena.DataTables.Query.Extensions.Model;
using Sample.Api.Models;
using System.Linq;

namespace Sample.Api.Repository
{
    /// <summary>
    /// Interface do repositorio de cidades
    /// </summary>
    public interface ICityRepository
    {
        City GetCityByName(string name);

        IQueryable<City> GetCities(string uf);

        DataTablesResponse<City> GetCitiesFiltered(ListCitiesByStateQuery query);
    }
}
