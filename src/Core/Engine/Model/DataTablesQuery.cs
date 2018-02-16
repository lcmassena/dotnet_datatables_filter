using System.Collections.Generic;

namespace Massena.DataTables.Query.Extensions.Model
{
    public class DataTablesQuery 
    {
        public DataTablesQuery()
        {
            Length = 10;
        }

        public class SearchSettings
        {
            public SearchSettings(string value, bool regex)
            {
                Value = value;
                Regex = regex;
            }

            public string Value { get; set; }
            public bool Regex { get; set; }
        }

        public class Column
        {
            public string Data { get; set; }
            public string Name { get; set; }
            public bool Searchable { get; set; }
            public bool Orderable { get; set; }
            public SearchSettings Search { get; set; }
        }

        public class Ordination
        {
            public int Column { get; set; }
            public string Dir { get; set; }
        }

        public int Draw { get; set; }
        public List<Column> Columns { get; set; }
        public List<Ordination> Order { get; set; }

        /// <summary>
        /// É a pagina que está sendo exibida no grid
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Quantidade de registros a serem exibidos por página
        /// </summary>
        public int Length { get; set; }

        public SearchSettings Search { get; set; }

        //Custom filters
        public class Filter
        {
            public string Field { get; set; }
            public string Value { get; set; }
        }

        public List<Filter> Filters { get; set; }

    }
}
