public class PersonService
{
    private readonly IPersonRepository _repo;

    public PersonService(IPersonRepository repo)
    {
        _repo = repo;
    }

    public Person GetPerson()
    {
        return _repo.GetPerson();
    }
}