using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Marketing abe = new Marketing("Abe", "CMO");
           Marketing rachel = new Marketing("Rachel", "Marketing Assistant");
           Marketing sarah = new Marketing("Sarah", "Intern");
           Finance debbie = new Finance("Debbie", "CFO");

           Company asp = new Company("Appalachia Service Project", DateTime.Now);
           asp.addEmployee(debbie);
           asp.addEmployee(abe);
           asp.addEmployee(rachel);
           asp.addEmployee(sarah);

           foreach(Employee person in asp.marketingDpt)
           {
               Console.WriteLine($"{person.Name} works in the Marketing department and is a {person.JobTitle}");
           }

        }
    }
    public class Company
    {

        public string Name { get; set;}
        public DateTime CreatedOn { get; set; }
        public List<Employee> employees = new List<Employee>();
        public List<Marketing> marketingDpt = new List<Marketing>();
        public List<Finance> financeDpt = new List<Finance>();
        public void addEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void addEmployee(Marketing marketingEmployee)
        {
            marketingDpt.Add(marketingEmployee);
        }
        public void addEmployee(Finance financeEmployee)
        {
            employees.Add(financeEmployee);
        }
        public void removeEmployee(Employee employeeName)
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

    public class Employee
    {
        public string Name {get;set;}
        public string JobTitle {get;set;}
    }

    public class Finance : Employee
    {
        public Finance(string name, string job)
        {
            this.Name = name;
            this.JobTitle = job;
        }
    }
        public class Marketing : Employee
    {
        public Marketing(string name, string job)
        {
            this.Name = name;
            this.JobTitle = job;
        }
    }

}
