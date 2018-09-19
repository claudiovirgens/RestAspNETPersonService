using System;
using System.Collections.Generic;
using System.Linq;
using RestAspNETPersonService.Models;
using RestAspNETPersonService.Repository;
using RestAspNETPersonService.Business;
using RestAspNETPersonService.Repository;

namespace RestAspNETBookService.Business.Implementations
{
    public class BookBusinessImpl : IBookBusiness
    {
        
        private IBookRepository _repository;

        public BookBusinessImpl(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book Book)
        {
           //Add Bussiness Rules Here 
            return _repository.Create(Book);
        }

        public void Delete(long id)
        {
            //Add Bussiness Rules Here 
            _repository.Delete(id);
        }

        public List<Book> findAll()
        {
            return _repository.findAll();

        }

            
        public Book FindById(long id)
        {
            //Add Bussiness Rules Here 
            return _repository.FindById(id);
            
        }

        public Book Update(Book Book)
        {
            //Add Bussiness Rules Here 
            return _repository.Update(Book);
            
        }

      
    }
}
