using CarStoreAPI.Models;
using CarStoreAPI.Repository.CarRepositoryDapper;
using CarStoreAPI.Repository.PersonRepositoryDapper;

namespace CarStoreAPI.Business.Implementation;

public class PersonBusiness : IPersonBusiness
{

    private readonly IPersonRepository _personRepository;

    public PersonBusiness(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public Person Create(Person person)
    {
        throw new NotImplementedException();
    }

    public Person Delete(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> FindAll()
    {
        throw new NotImplementedException();
    }

    public Person FindById(string id)
    {
        throw new NotImplementedException();
    }

    public Person GetOwnerByName(string name)
    {
        var person = new Person();

        try
        {
            person = _personRepository.GetOwnerByName(name);
            return person;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public Person Update(Person person)
    {
        throw new NotImplementedException();
    }
}
