﻿using Microsoft.EntityFrameworkCore;
using RestAspNETPersonService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNETPersonService.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){ }

        public DbSet<Person> Persons { get; set; }
    }
}