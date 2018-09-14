using RestAspNETPersonService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNETPersonService.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> findAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
