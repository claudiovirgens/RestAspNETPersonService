using System;
using System.Collections.Generic;
using RestAspNETPersonService.Models;

namespace RestAspNETPersonService.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> findAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(object i)
        {
            return new Person
            {
                Id = IncremetAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Person Address" + i,
                Gender = "Male"
            };
        }

        private long IncremetAndGet()
        {
            return System.Threading.Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - MG",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
