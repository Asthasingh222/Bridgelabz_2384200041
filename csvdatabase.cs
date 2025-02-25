
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace SQLiteques
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
     public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=employees.db");
    }

    class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            context.Database.EnsureCreated(); // Ensure DB exists

            // Add Sample Data if Empty
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee { Name = "Alice", Department = "IT", Salary = 60000 },
                    new Employee { Name = "Bob", Department = "HR", Salary = 55000 },
                    new Employee { Name = "Charlie", Department = "Finance", Salary = 65000 }
                );
                context.SaveChanges();
            }

            var employees = context.Employees.ToList();

            // Generate CSV
            string filePath = "EmployeeReport.csv";
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("Employee ID,Name,Department,Salary");

            foreach (var emp in employees)
            {
                csvBuilder.AppendLine($"{emp.EmployeeId},{emp.Name},{emp.Department},{emp.Salary}");
            }

            File.WriteAllText(filePath, csvBuilder.ToString());
            Console.WriteLine($"CSV file created: {filePath}");
        }
    }
}


}

