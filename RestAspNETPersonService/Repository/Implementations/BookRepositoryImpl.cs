using System;
using System.Collections.Generic;
using System.Linq;
using RestAspNETPersonService.Context;
using RestAspNETPersonService.Models;
using RestAspNETPersonService.Repository;

namespace RestAspNETBookService.Repository.Implementations
{
    public class BookRepositoryImpl : IBookRepository
    {
        
        private MySQLContext _context;

        public BookRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public Book Create(Book Book)
        {
            try
            {
                _context.Add(Book);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Book;
        }

        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null) _context.Books.Remove(result);                
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Book> findAll()
        {
            return _context.Books.ToList();

        }

            
        public Book FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
            
        }

        public Book Update(Book Book)
        {
            if (!Exists(Book.Id)) return null;
            
            var result = _context.Books.SingleOrDefault(b => b.Id == Book.Id);
            if (result != null) { 

                try
            {
                    _context.Entry(result).CurrentValues.SetValues(Book);
                    _context.SaveChanges();
                }
            catch (Exception ex)
            {
                throw ex;
            }
            }
            return result;
            
        }

        public bool Exists(long? id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }

        public bool Exists(string id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
