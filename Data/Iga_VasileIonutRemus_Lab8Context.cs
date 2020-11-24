using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iga_VasileIonutRemus_Lab8.Models;

namespace Iga_VasileIonutRemus_Lab8.Data
{
    public class Iga_VasileIonutRemus_Lab8Context : DbContext
    {
        public Iga_VasileIonutRemus_Lab8Context (DbContextOptions<Iga_VasileIonutRemus_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Iga_VasileIonutRemus_Lab8.Models.Book> Book { get; set; }

        public DbSet<Iga_VasileIonutRemus_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Iga_VasileIonutRemus_Lab8.Models.Category> Category { get; set; }
    }
}
