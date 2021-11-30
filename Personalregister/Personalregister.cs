using System;
using System.Collections.Generic;
using System.Text;

namespace Personalregister
{
    class Personalregister
    {
        /// <summary>
        /// List of emplyees
        /// </summary>
        private List<Employee> employees = new List<Employee>();

        /// <summary>
        /// Adds a emplyee to the list
        /// </summary>
        /// <param name="name">Name of the emplyee</param>
        /// <param name="salary">The salary</param>
        public void AddEmployee(string name, decimal salary)
        {
            Employee person = new Employee();
            person.Name = name;
            person.Salary = salary;

            employees.Add(person);

        }

        /// <summary>
        /// Prints the list of emplyees and ther salaryes
        /// </summary>
        public void ListEmplyees()
        {
            Console.Clear();
            Console.WriteLine("List of employees");
            foreach (var employee in employees)
            {
                Console.WriteLine("Name {0} has Salary {1}", employee.Name, employee.Salary);
            }
        }

        /// <summary>
        /// Add a employee to the list form the console
        /// </summary>
        /// <returns>Returns true or flase depending on the result input
        /// true if ok 
        /// false if somthing went wrong
        /// </returns>
        public bool AddEmplyee()
        {
            string name = "";
            bool res = true;

            Console.Write("Enter name (exit to quit)");
            name = Console.ReadLine();
            if (name.ToLower() == "exit")
            {
                res = false;
            }
            else if (name == "")
            {
                Console.WriteLine("Name not entered correct!");
                res = false;
            }

            if (res)
            {
                Console.Write("Enter salary ");
                decimal salary;
                if (!decimal.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Salary not correct!");
                    res = false;

                }
                else
                {
                    AddEmployee(name, salary);
                }

            }


            return res;
        }

        /// <summary>
        /// Add som testdata
        /// </summary>
        public void AddTestData()
        {
            AddEmployee("Adam", 10000);
            AddEmployee("Eva", 1000000);
            AddEmployee("Joakim von Anka", 1000000);
            AddEmployee("Kalle Anka", 1000);
            AddEmployee("Janne Långben", 55000);
        }
    }
}
