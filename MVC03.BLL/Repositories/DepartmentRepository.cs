using MVC03.BLL.Interfaces;
using MVC03.DAL.Data.Context;
using MVC03.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC03.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MVC03DbContext _context;
    public DepartmentRepository(MVC03DbContext context)
        {
            _context = context;
        }
        public int Add(Department model)
        {
            _context.Departments.Add(model);
            return _context.SaveChanges();
        }

        public int Delete(Department model)
        {
            _context.Departments.Remove(model);
            return _context.SaveChanges();
        }

        public Department? Get(int id)
        {
            return _context.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public int Update(Department model)
        {
            _context.Departments.Update(model);
            return _context.SaveChanges();
        }
    }
}
