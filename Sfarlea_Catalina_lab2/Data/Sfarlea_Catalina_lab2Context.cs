using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sfarlea_Catalina_lab2.Models;

namespace Sfarlea_Catalina_lab2.Data
{
    public class Sfarlea_Catalina_lab2Context : DbContext
    {
        public Sfarlea_Catalina_lab2Context (DbContextOptions<Sfarlea_Catalina_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sfarlea_Catalina_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sfarlea_Catalina_lab2.Models.Publisher> Publisher { get; set; } = default!;

        public DbSet<Sfarlea_Catalina_lab2.Models.Author> Author { get; set; } = default!;

        public DbSet<Sfarlea_Catalina_lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Sfarlea_Catalina_lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Sfarlea_Catalina_lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
