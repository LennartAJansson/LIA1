namespace Exempel.Abstract
{
    using System.Collections.Generic;

    public interface IMyService
    {
        IEnumerable<Person> GetAllPeople();
        Person GetById(int id);
        Person AddPerson(Person p);
    }
}
