using System.Collections.Generic;

namespace Massena.DataTables.Query.Extensions.Model
{

    // {"page":1,"itemsPerPage":10,"sortBy":[],"sortDesc":[],"groupBy":[],"groupDesc":[],"mustSort":false,"multiSort":false}

    /// <summary>
    /// In general used for Vue datatables - v-data-table
    /// </summary>
    public class VueDataTablesQuery
    {
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public bool MustSort { get; set; }
        public bool MultiSort { get; set; }

        public IEnumerable<string> SortBy { get; set; }
        public IEnumerable<bool> SortDesc { get; set; }
        public IEnumerable<string> GroupBy { get; set; }
        public IEnumerable<string> GroupDesc { get; set; }

        public IEnumerable<Header> Headers { get; set; }

        public class Header {
            //Display text
            public string Text { get;set; }
            //Data value field, same as ViewModel
            public string Value { get; set; }
            //Text to be filtered
            public string Filter { get; set; }
        }
    }




    /// <summary>
    /// In general used for datatables.net grid system
    /// </summary>
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
