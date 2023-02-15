using Microsoft.EntityFrameworkCore;
using SmapleCodeFirst.Entities;

namespace SmapleCodeFirst.Context
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }
        DbSet<Employees> Employees { get; set; }

    }
}