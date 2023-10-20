using System;
using System.Collections;
using System.Reflection;
using System.Xml.Linq;

namespace Lab8_OOP_Generic_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Del 1 -Stack");
            //Del 1 - Stack
            Employee employee1 = new Employee(101, "Alex", "Male", 30000);
            Employee employee2 = new Employee(102, "Sara", "Female", 40000);
            Employee employee3 = new Employee(103, "Hanna", "Female", 30000);
            Employee employee4 = new Employee(104, "Tomas", "Male", 50000);
            Employee employee5 = new Employee(105, "Kalle", "Male", 20000);

            Stack<Employee> EmployeeStack = new Stack<Employee>();
            EmployeeStack.Push(employee1);
            EmployeeStack.Push(employee2);
            EmployeeStack.Push(employee3);
            EmployeeStack.Push(employee4);
            EmployeeStack.Push(employee5);

            foreach (Employee emp in EmployeeStack)
            {
                emp.Display();
                Console.WriteLine($"Item left in the Stack = {EmployeeStack.Count}");
            }
            //Retrive using pop method //try to use while loop again here
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Retrive Using Pop Method");
            while ( EmployeeStack.Count > 0 )
            {
                EmployeeStack.Pop().Display();
                Console.WriteLine($"Item left in the Stack = {EmployeeStack.Count()}");
            }

            Console.WriteLine("-------------------------------");
            // Add all objects again
            EmployeeStack.Push(employee1);
            EmployeeStack.Push(employee2);
            EmployeeStack.Push(employee3);
            EmployeeStack.Push(employee4);
            EmployeeStack.Push(employee5);
            // Retrive using peek method
            Console.WriteLine("Retrive Using Peek Method");
            Employee empOne = EmployeeStack.Peek();
            empOne.Display();
            Console.WriteLine($"Item left in the Stack = {EmployeeStack.Count()}");
            Employee empTwo = EmployeeStack.Peek();
            empTwo.Display();
            Console.WriteLine($"Item left in the Stack = {EmployeeStack.Count()}");
            Console.WriteLine("-------------------------------");
            if (EmployeeStack.Contains(employee3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            // Del 2 - List
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Del 2 - List");
            var employeeList = new List<Employee>() { };
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
            //use Contains() method to check if the specified element exists or not in a list<T>
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("EmployeeTwo object exists in the list");
            }
            else
            {
                Console.WriteLine("EmployeeTwo object does not exit in the list");
            }
            Console.WriteLine();

            // Use Find() method to find the first male 

            Employee firstMale = employeeList.Find(x => x.Gender == "Male");
            if (firstMale != null)
            {
                Console.WriteLine(firstMale.ToString());
            }
            else
            {
                Console.WriteLine("We can't find male employees");
            }
            Console.WriteLine();
            //  Use FindAll() method to find all males
            List<Employee> allMales = employeeList.FindAll(x => x.Gender == "Male");
            if (allMales.Count > 0)
            {
                foreach (Employee e in allMales)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                Console.WriteLine("We can't find male employees");
            }

        }
    }
}