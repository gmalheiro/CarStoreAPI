using CarStoreAPI.Models;
using Dapper;
using System.Data.SqlClient;

namespace CarStoreAPI.Repository.CarRepositoryDapper;

public class CarRepositoryDapper : ICarRepositoryDapper
{
    private readonly IConfiguration _configuration;

    public CarRepositoryDapper(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Create(Car car)
    {
        using (var connection = new SqlConnection(_configuration.GetConnectionString("SQLServerConnString")))
        {
            string? query = @$"INSERT INTO [CAR] VALUES 
                            (@Model,
                             @Brand,
                             @Color,
                             @Plate,
                             @LaunchDate,
                             @OwnerId)";

            connection.Execute(query, new
            {
                Model = car.Model,
                Brand = car.Brand,
                Color = car.Color,
                Plate = car.Plate,
                LaunchDate = car.LaunchDate,
                OwnerId = car.OwnerId,
            });
        }
    }

    public void Update(Car car)
    {
        using (var connection = new SqlConnection(_configuration.GetConnectionString("SQLServerConnString")))
        {
            string? query = @$"UPDATE  [CAR] SET
                             [Model] = @Model,
                             [Brand] = @Brand,
                             [Color] = @Color,
                             [Plate] = @Plate,
                             [LaunchDate] = @LaunchDate,
                             [OwnerId] = @OwnerId
                             WHERE [Id] = @Id";

            connection.Execute(query, new
            {
                Model = car.Model,
                Brand = car.Brand,
                Color = car.Color,
                Plate = car.Plate,
                LaunchDate = car.LaunchDate,
                Id = car.CarId
            });
        }
    }
}
