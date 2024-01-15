using CarStoreAPI.Business;
using CarStoreAPI.Data.Converter.Contract;
using CarStoreAPI.Data.DTO;
using CarStoreAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CarStoreAPI.Data.Converter.Implementations
{
    public class CarParser : IParser<CarDTO, Car>, IParser<Car, CarDTO>
    {

        private readonly IPersonBusiness _personBusiness;
        public CarParser(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        public Car Parse(CarDTO origin)
        {
            if(origin is null)
                return new Car();
            return new Car()
            {
                Model = origin.Model,
                Brand = origin.Brand,
                Color = origin.Color,
                Plate = origin.Plate,
                LaunchDate = DateTime.ParseExact(origin.LaunchDate, "dd/MM/yyyy HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture),
                OwnerId = _personBusiness.GetOwnerByName(origin.OwnerName).PersonId
            };
        }

        public List<Car> Parse(List<CarDTO> origin)
        {
            if (origin == null)
            {
                return new List<Car>();
            }

            List<Car> result = new List<Car>();

            foreach (var item in origin)
            {
                var car = Parse(item);

                var validationContext = new ValidationContext(car, serviceProvider: null, items: null);
                var validationResults = new List<ValidationResult>();

                if (Validator.TryValidateObject(car, validationContext, validationResults, validateAllProperties: true))
                {
                    result.Add(car);
                }
                else
                {
                    Console.WriteLine($"Invalid Car: {string.Join(", ", validationResults.Select(v => v.ErrorMessage))}");
                }
            }

            return result;
        }


        public CarDTO Parse(Car origin)
        {
            if (origin is null)
                return new CarDTO("null","null","null","null","null","null");

            var result = new CarDTO()
            {
                Model = origin.Model,
                Brand = origin.Brand,
                Plate = origin.Plate,
                LaunchDate = origin.LaunchDate.ToString("dd/mm/yyyy"),
                OwnerName = origin.Owner.Name,
                Color = origin.Color
            };

            return result;
        }

        public List<CarDTO> Parse(List<Car> origin)
        {
            throw new NotImplementedException();
        }
    }
}
