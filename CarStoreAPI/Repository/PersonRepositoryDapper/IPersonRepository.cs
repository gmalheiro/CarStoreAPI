using CarStoreAPI.Models;
using CarStoreAPI.Repository.GenericRepositoryDapper;

namespace CarStoreAPI.Repository.PersonRepositoryDapper;

public interface IPersonRepository : IGenericRepositoryDapper<Person>
{
    void Create(Person person);
    void Update(Person person);

    Person GetOwnerByName(string name);
}
