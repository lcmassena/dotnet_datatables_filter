# Dotnet DataTables Filter
A simple way to filter IQueryables with datatables.net and/or Vue DataTable parameters to optimize query performance

Please, help me sending updates.

Recently I've added support to Vue DataTables (v-data-table)
Now it's possible to post the VueDT options to your API and query data using that information.

The method FilterDataTable manipulates the LINQ query before materializing it.
The query is filtered, reordered and paginated in memory and executed in the most optimized way.

This code support EntityFramework, Linq2Db and other ORM frameworks.



To test, simple post this JSON *{ uf: 'RJ' }* in the address
http://localhost:54959/api/cities/list

To check how it works, go to CityRepository.cs line 27.

GetCities(query.UF).FilterDataTable<City, DataTablesResponse<City>>(query);
  
  The FilterDataTable method, uses information sent by Datatables.net Grid to improve the SQL query performance by changing the Linq behavior.
