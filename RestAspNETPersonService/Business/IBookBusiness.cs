using RestAspNETPersonService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNETPersonService.Business
{
    public interface IBookBusiness
    {
        Book Create(Book books);
        Book FindById(long id);
        List<Book> findAll();
        Book Update(Book books);
        void Delete(long id);
    }
}
