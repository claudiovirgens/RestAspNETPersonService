using RestAspNETPersonService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNETPersonService.Repository
{
    public interface IBookRepository
    {
        Book Create(Book books);
        Book FindById(long id);
        List<Book> findAll();
        Book Update(Book books);
        void Delete(long id);
        bool Exists(long? id);
        bool Exists(string id);
    }
}
