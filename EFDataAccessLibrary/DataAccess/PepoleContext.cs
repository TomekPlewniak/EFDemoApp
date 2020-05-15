﻿using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.DataAccess
{
    public class PepoleContext : DbContext
    {
        public PepoleContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Email> EmailAddresses { get; set; }
    }
}
