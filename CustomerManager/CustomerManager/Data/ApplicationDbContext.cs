using System;
using System.Collections.Generic;
using System.Text;
using CustomerManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Product { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
