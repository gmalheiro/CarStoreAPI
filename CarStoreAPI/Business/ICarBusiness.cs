using CarStoreAPI.Data.DTO;

namespace CarStoreAPI.Business;

public interface ICarBusiness
{
    List<CarDTO> FindAll();
    CarDTO FindById(int id);
    CarDTO Create(CarDTO carDTO);
    CarDTO Update(CarDTO carDTO);
    CarDTO DeleteById(int id);  
}
