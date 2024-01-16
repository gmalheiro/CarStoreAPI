using CarStoreAPI.Models;

namespace CarStoreAPI.Business
{
    public interface IPersonBusiness
    {
        List<Person> FindAll();
        Person FindById(string id);
        Person Create(Person person);
        Person Update(Person person);
        Person Delete(Person person);
        Person GetOwnerByName(string name);
    }
}
