namespace Exempel
{
    using Exempel.Abstract;

    using System.Collections.Generic;

    public class MyService : IMyService
    {
        private readonly IUnitOfWork unitOfWork;

        public MyService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Person AddPerson(Person p)
        {
            unitOfWork.Repository<Person>().Insert(p);
            unitOfWork.SaveChanges();
            return p;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return unitOfWork.Repository<Person>().Get();
        }

        public Person GetById(int id)
        {
            return unitOfWork.Repository<Person>().GetById(id);
        }
    }
}
