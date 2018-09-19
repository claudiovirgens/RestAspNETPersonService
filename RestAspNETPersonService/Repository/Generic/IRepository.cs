﻿using RestAspNETPersonService.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNETPersonService.Repository.Generic
{
    public interface IRepository<T> where T: BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> findAll();
        T Update(T item);
        void Delete(long id);

        bool Exists(long? id);
        bool Exists(string id);

    }
}