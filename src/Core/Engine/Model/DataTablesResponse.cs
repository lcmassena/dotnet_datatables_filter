using System.Collections.Generic;

namespace Massena.DataTables.Query.Extensions.Model
{
    public class DataTablesResponse<T>
    {
        /// <summary>
        /// Quantidade de vezes que o grid foi renderizado/filtrado/paginado
        /// </summary>
        public int Draw { get; set; }
        /// <summary>
        /// Quantidade de registros filtrados
        /// </summary>
        public int RecordsFiltered { get; set; }
        /// <summary>
        /// Quantidade total de registros, sem filtros
        /// </summary>
        public int RecordsTotal { get; set; }
        /// <summary>
        /// Lista de objetos à serem renderizados no grid
        /// </summary>
        public IEnumerable<T> Data { get; set; }
    }
}
