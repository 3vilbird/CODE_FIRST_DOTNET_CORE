using SmapleCodeFirst.Context;
using SmapleCodeFirst.Entities;

namespace SmapleCodeFirst.Services
{
    public class Employee : IEmployee
    {
        private readonly EmpContext _context;

        public Employee(EmpContext context)
        {
            _context = context;
        }

        public string AddEmployes(Employees emp)
        {
            _context.Add<Employees>(emp);
            _context.SaveChanges();
            return "Done";
        }
    }
}