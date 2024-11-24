using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;

namespace Yedidim.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CallFromPeople> CallsFromPeople { get; set; }
        public DbSet<TypesOfCall> TypesOfCall { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Yedidim");
        }
    }
}
