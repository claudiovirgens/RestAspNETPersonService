﻿using System;
using System.Collections.Generic;
using System.Linq;
using RestAspNETPersonService.Context;
using RestAspNETPersonService.Models;

namespace RestAspNETPersonService.Repository.Implementations
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        
        private MySQLContext _context;

        public PersonRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null) _context.Persons.Remove(result);                
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Person> findAll()
        {
            return _context.Persons.ToList();

        }

            
        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return null;
            
            var result = _context.Persons.SingleOrDefault(b => b.Id == person.Id);
            if (result != null) { 

                try
            {
                    _context.Entry(result).CurrentValues.SetValues(person);
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
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
