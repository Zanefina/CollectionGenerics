using System;
using System.Collections.Generic;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {  //Employeers objects
            Employee E1 = new Employee() 
            {
                ID = 101,
                Name = "Sara",
                Gender = "F",
                Salary = 25000
            };
            Employee E2 = new Employee()
            {
                ID = 102,
                Name = "Lars",
                Gender = "M",
                Salary = 15000
            };
            Employee E3 = new Employee()
            {
                ID = 103,
                Name = "Mia",
                Gender = "F",
                Salary = 20000
            };
            Employee E4 = new Employee()
            {
                ID = 104,
                Name = "Lio",
                Gender = "M",
                Salary = 25000
            };
            Employee E5 = new Employee()
            {
                ID = 105,
                Name = "Sam",
                Gender = "M",
                Salary = 3000
            };
            Console.WriteLine("-----------STACK-----------");
            Stack<Employee> emStack = new Stack<Employee>(); //The stack
            emStack.Push(E1);
            emStack.Push(E2);
            emStack.Push(E3);
            emStack.Push(E4);
            emStack.Push(E5);

            foreach (Employee item in emStack)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", item.ID, item.Name, item.Gender, item.Salary);
                Console.WriteLine("Items left in the Stack: {0}", emStack.Count);

            }
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Retrive using Pop Method: ");
            while (emStack.Count > 0) 
            {
                Employee E = emStack.Pop(); //Pop method
                Console.WriteLine("{0} - {1} - {2} - {3}", E.ID, E.Name, E.Gender, E.Salary);
                Console.WriteLine("Items left in the Stack: {0}", emStack.Count);
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Retrive using Peek Method: ");
            emStack.Push(E1);
            emStack.Push(E2);
            emStack.Push(E3);
            emStack.Push(E4);
            emStack.Push(E5);
            Employee peek1 = emStack.Peek(); //First peek
            Console.WriteLine("{0} - {1} - {2} - {3}", peek1.ID, peek1.Name, peek1.Gender, peek1.Salary);
            Console.WriteLine("Items left in the Stack: {0}", emStack.Count);

            Employee peek2 = emStack.Peek();//Second peek
            Console.WriteLine("{0} - {1} - {2} - {3}", peek2.ID, peek2.Name, peek2.Gender, peek2.Salary);
            Console.WriteLine("Items left in the Stack: {0}", emStack.Count);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Contain method: ");

            if (emStack.Contains(E3)) //Check if the stack contains employe nr 3
            {
                Console.WriteLine("Employee is in the Stack");
            }
            else
            {
                Console.WriteLine("Employe is not in the Stack");
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("-----------List-----------");
            List<Employee> MyList = new List<Employee>(); //The list
            MyList.Add(E1); 
            MyList.Add(E2);
            MyList.Add(E3);
            MyList.Add(E4);
            MyList.Add(E5);

            if (MyList.Contains(E5)) //If the list constains Employe nr 5
            {
                Console.WriteLine(E5.Name + " exists in the list");
            }
            else
            {
                Console.WriteLine("Employee does not exists in the list");
            }
            Console.WriteLine("----------------------------------------------");
            Employee find = MyList.Find(s => s.Gender == "M");//Find the first men in the list
            Console.WriteLine("{0} - {1} - {2} - {3}", find.ID, find.Name, find.Gender, find.Salary);

            List<Employee> Men = MyList.FindAll(s => s.Gender == "M");//Find all men in the list

            foreach (Employee item in Men)
            {
                Console.WriteLine(" {0} - {1} - {2} - {3}", item.ID, item.Name, item.Gender, item.Salary);

            }
            Console.WriteLine("------------------------------------------------------------------");








        }
    }
}
