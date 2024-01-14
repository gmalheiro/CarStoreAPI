using CarStoreAPI.Models;
using CarStoreAPI.Repository.GenericRepositoryDapper;

namespace CarStoreAPI.Repository.CarRepositoryDapper;

public interface ICarRepositoryDapper : IGenericRepositoryDapper<Car>
{
    void Create(Car car);
    void Update(Car car);
}
