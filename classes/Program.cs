using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Company target = new Company();
           target.Name = "Target";
           Console.WriteLine(target.Name);
           target.addEmployee("Meg");
           target.addEmployee("Hannah");
           target.addEmployee("Brenda");
           foreach(string name in target.employees)
           {
                Console.WriteLine(name);
           }
           Company walmart = new Company("Walmart", DateTime.Now);
           Console.WriteLine(walmart.CreatedOn);
        }
    }
    public class Company
    {

        public string Name { get; set;}
        public DateTime CreatedOn { get; set; }
        public List<string> employees = new List<string>();
        public void addEmployee(string employeeName)
        {
            employees.Add(employeeName);
        }
        public void removeEmployee(string employeeName)
        {
            employees.Remove(employeeName);
        }
        public Company(string name, DateTime DateCreated)
        {
            this.Name = name;
            this.CreatedOn = DateCreated;
        }
        public Company()
        {

        }

    }
}
