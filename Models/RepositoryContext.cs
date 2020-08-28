using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellingYourKids.Models
{
    public class RepositoryContext : DbContext //IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Post> Posts { get; set; }
    }
}
