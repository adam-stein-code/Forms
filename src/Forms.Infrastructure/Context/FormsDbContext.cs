using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Forms.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Forms.Infrastructure.Context
{
    public class FormsDbContext : DbContext
    {
        public FormsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Questions> Questions { get; set; }

    }
}
