using CarStoreAPI.Models;
using Dapper;
using System;
using System.Data.SqlClient;

namespace CarStoreAPI.Repository.PersonRepositoryDapper;

public class PersonRepositoryDapper : IPersonRepository
{
    private readonly IConfiguration _configuration;

    public PersonRepositoryDapper(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Create(Person person)
    {
        using (var connection = new SqlConnection(_configuration.GetConnectionString("SQLServerConnString")))
        {
            string? query = @$"INSERT INTO [Person] VALUES 
                            (@Name,
                             @Surname,
                             @Birthdate,
                             @DocumentNumber)";

            connection.Execute(query, new
            {
                Name = person.Name,
                Surname = person.Surname,
                Birthdate = person.Birthdate,
                DocumentNumber = person.DocumentNumber,
            });
        }
    }

    public void Update(Person person)
    {
        using (var connection = new SqlConnection(_configuration.GetConnectionString("SQLServerConnString")))
        {
            string? query = @$"UPDATE  [Person] SET
                             [Name] = @Model,
                             [Surname] = @Brand,
                             [Birthdate] = @Color,
                             [Documentnumber] = @Plate
                             WHERE [Id] = @Id ";

            connection.Execute(query, new
            {
                Name = person.Name,
                Surname = person.Surname,
                Birthdate = person.Birthdate,
                DocumentNumber = person.DocumentNumber,
                Id = person.PersonId
            });
        }
    }

    public Person GetOwnerByName(string name)
    {
        var person = new Person();
        using (var connection = new SqlConnection(_configuration.GetConnectionString("SQLServerConnString")))
        {
            string? query = @$"SELECT * FROM [Person] AS p
                               WHERE p.Name = @Name 
                              ";

            person = connection.QueryFirstOrDefault<Person>(query, new
            {
                Name = name
            });

            return person is null ? new Person() : person;
        }
    }
}
