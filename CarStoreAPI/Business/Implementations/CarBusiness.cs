using CarStoreAPI.Data.DTO;
using CarStoreAPI.Repository.CarRepositoryDapper;

namespace CarStoreAPI.Business.Implementation;

public class CarBusiness : ICarBusiness
{
    private readonly ICarRepositoryDapper _carRepositoryDapper;

    public CarBusiness(ICarRepositoryDapper carRepositoryDapper)
    {
        _carRepositoryDapper = carRepositoryDapper;
    }

    public CarDTO Create(CarDTO carDTO)
    {
        try
        {
            return carDTO;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public CarDTO DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public List<CarDTO> FindAll()
    {
        throw new NotImplementedException();
    }

    public CarDTO FindById(int id)
    {
        throw new NotImplementedException();
    }

    public CarDTO Update(CarDTO carDTO)
    {
        throw new NotImplementedException();
    }
}
