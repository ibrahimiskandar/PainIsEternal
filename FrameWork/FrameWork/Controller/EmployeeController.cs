using FrameWork.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using FrameWork;

namespace Controller.EmployeeController
{
    public class EmployeeController
    {
        private readonly AppDbContext _context;
        public EmployeeController()
        {
            _context = new AppDbContext();
        }
        public void GetAllEmployees()
        {
            foreach (var item in _context.Employees)
            {
                Console.WriteLine(item.Fullname);
            }
        }
        public void AddEmployee(string fullname)
        {
            try
            {
                Employee employee = new Employee { Fullname = fullname };
                _context.Employees.Add(employee);
                _context.SaveChanges();
                Console.WriteLine("Isci yaradildi");
            }
            catch (Exception)
            {

                Console.WriteLine("isci yaradilmadi");
            }
        }
        public void DeleteEmployee(int id)
        {
            try
            {
                Employee employee = _context.Employees.Find(id);
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                Console.WriteLine("isci silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Id movcud deyil");
            }
        }
        public void GetEmployeeById(int id)
        {
            try
            {
                Console.WriteLine(_context.Employees.Find(id).Fullname);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                Console.WriteLine("Id movcud deyil");
            }
        }
        public void FilterByName(string search)
        {
            try
            {
                List<Employee> employees = _context.Employees.ToList();
                foreach (var item in employees)
                {
                    if (item.Fullname.ToLower().Contains(search) || item.Fullname.ToUpper().Contains(search))
                    {
                        Console.WriteLine(item.Fullname);
                    }
                    else
                    {
                        Console.WriteLine("isci movcud deyil");
                        break;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("isci movcud deyil");
            }
        }
    }
}
