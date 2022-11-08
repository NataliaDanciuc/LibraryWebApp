using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Danciuc_Natalia_Lab2.Models;

namespace Danciuc_Natalia_Lab2.Data
{
    public class Danciuc_Natalia_Lab2Context : DbContext
    {
        public Danciuc_Natalia_Lab2Context (DbContextOptions<Danciuc_Natalia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Danciuc_Natalia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Danciuc_Natalia_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Danciuc_Natalia_Lab2.Models.Category> Category { get; set; }

        public DbSet<Danciuc_Natalia_Lab2.Models.Author> Author { get; set; }

        public DbSet<Danciuc_Natalia_Lab2.Models.Member> Member { get; set; }

        public DbSet<Danciuc_Natalia_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
