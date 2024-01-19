using CarStoreAPI.Data.Converter.Implementations;
using CarStoreAPI.Data.DTO;
using CarStoreAPI.Repository.CarRepositoryDapper;

namespace CarStoreAPI.Business.Implementation;

public class CarBusiness : ICarBusiness
{
    private readonly ICarRepositoryDapper _carRepositoryDapper;
    private readonly CarParser _parser;

    public CarBusiness(ICarRepositoryDapper carRepositoryDapper, CarParser parser)
    {
        _carRepositoryDapper = carRepositoryDapper;
        _parser = parser;
    }

    public CarDTO Create(CarDTO carDTO)
    {

        var car = _parser.Parse(carDTO);

        _carRepositoryDapper.Create(car);

        return carDTO;
    }

    public CarDTO DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public List<CarDTO> FindAll()
    {
        var cars = _carRepositoryDapper.FindAll();

        return _parser.Parse(cars);
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
