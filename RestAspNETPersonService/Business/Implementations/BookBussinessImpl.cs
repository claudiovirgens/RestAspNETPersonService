using System.Collections.Generic;
using RestAspNETPersonService.Models;
using RestAspNETPersonService.Repository;
using RestAspNETPersonService.Business;
using RestAspNETPersonService.Repository.Generic;

namespace RestAspNETBookService.Business.Implementations
{
    public class BookBusinessImpl : IBookBusiness
    {
        
        private IRepository<Book> _repository;

        public BookBusinessImpl(IRepository<Book> repository)
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
