using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace project1.Models
{
    public class ApplicationUser: DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {
        }
        public DbSet<User> Registration { get; set; }
    }
}

