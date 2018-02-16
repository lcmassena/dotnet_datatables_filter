using Massena.DataTables.Query.Extensions.Model;

namespace Sample.Api.Models
{
    /// <summary>
    /// Representa uma consulta a ser realizada na aplicação
    /// Por herdar o DataTablesQuery, possui as propriedades oriundas do grid
    /// </summary>
    public class ListCitiesByStateQuery : DataTablesQuery
    {
        public string UF { get; set; }
    }
}
