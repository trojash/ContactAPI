﻿using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
    public class ContactAPIDbContext: DbContext
    {
        public ContactAPIDbContext(DbContextOptions options): base(options) 
        { 
            
        }

        //properties
        public DbSet<Contact> Contacts { get; set; }

    }

}
