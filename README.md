# Dotnet DataTables Filter
A simple way to filter IQueryables with datatables.net parameters to optimize query performance

Please, help me sending updates.


To test, simple post this JSON *{ uf: 'RJ' }* in the address
http://localhost:54959/api/cities/list

To check how it works, go to CityRepository.cs line 27.

GetCities(query.UF).FilterDataTable<City, DataTablesResponse<City>>(query);
  
  The FilterDataTable method, uses information sent by Datatables.net Grid to improve the SQL query performance by changing the Linq behavior.
