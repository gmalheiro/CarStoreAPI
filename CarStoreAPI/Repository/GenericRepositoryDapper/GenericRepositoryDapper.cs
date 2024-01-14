using CarStoreAPI.Models;
using Dapper;
using System.Data.SqlClient;

namespace CarStoreAPI.Repository.GenericRepositoryDapper;

public class GenericRepositoryDapper<T> : IGenericRepositoryDapper<T>
{
    private readonly IConfiguration? _configuration;

    public GenericRepositoryDapper(IConfiguration? configuration)
    {
        _configuration = configuration;
    }

    public IEnumerable<T> FindAll()
    {
        List<T> listTobeReturned = new List<T>();

        string query = $"SELECT * FROM {typeof(T).Name}";

        try
        {
            using (var connection = new SqlConnection(_configuration?.GetConnectionString("SqlConnString")))
            {
                listTobeReturned = connection.Query<T>(query).ToList();
                return listTobeReturned;
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    public T FindById(int id)
    {
        string query = $"SELECT * FROM {typeof(T).Name} WHERE Id = @Id";

        T itemToBeReturned;

        try
        {
            using (var connection = new SqlConnection(_configuration?.GetConnectionString("SqlConnString")))
            {
                itemToBeReturned = connection.QueryFirstOrDefault<T>(query)!; 
                
                return itemToBeReturned;       
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public void DeleteAsync(int id)
    {
        string query = $"DELETE FROM {typeof(T).Name} WHERE Id = @Id";

        try
        {
            using (var connection = new SqlConnection(_configuration?.GetConnectionString("SqlConnString")))
            {
                connection.ExecuteScalar(query, new { Id = id });
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

    }

}
