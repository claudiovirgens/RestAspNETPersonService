using System;
using System.Collections.Generic;
using System.Linq;
using RestAspNETPersonService.Models;
using RestAspNETPersonService.Repository;

namespace RestAspNETPersonService.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
           //Add Bussiness Rules Here 
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            //Add Bussiness Rules Here 
            _repository.Delete(id);
        }

        public List<Person> findAll()
        {
            return _repository.findAll();

        }

            
        public Person FindById(long id)
        {
            //Add Bussiness Rules Here 
            return _repository.FindById(id);
            
        }

        public Person Update(Person person)
        {
            //Add Bussiness Rules Here 
            return _repository.Update(person);
            
        }

      
    }
}
