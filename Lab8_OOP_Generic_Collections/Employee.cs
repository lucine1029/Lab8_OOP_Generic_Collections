using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_OOP_Generic_Collections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double MonthlySalary { get; set; }
        public Employee(int id, string name, string gender, double monthlySalary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            MonthlySalary = monthlySalary;
        }
        public void Display()
        {
            Console.WriteLine($"{Id} - {Name} - {Gender} - {MonthlySalary}");
        }
        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Gender = {Gender}, MonthlySalary = {MonthlySalary}";
        }

    }
}
