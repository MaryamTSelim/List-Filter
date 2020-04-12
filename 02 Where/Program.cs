using System;
using System.Collections.Generic;
namespace _02_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee> {new Employee("Maryam",1000), new Employee("Esraa", 1200), new Employee("Basant", 1500),
                                                        new Employee("Reem",1200),new Employee("Mona",1300),new Employee("Mariam",1400)};
            Func<Employee, Employee> func = delegate (Employee e) { return e.Salary >= 1300 ? e.Clone() : null; };
            List<Employee> res = MyWhere<Employee>(emps, func);
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\nPress any key to Exit");
            Console.ReadLine();
        }

         static List<T> MyWhere<T>(List<T> emps, Func<T, T> func)
        {
            List<T> res = new List<T>();
            foreach (var e in emps)
            {
                var check = func(e)!=null?true:false;
                if (check)
                {
                    res.Add(e);
                }
            }

            return res;
        }

        
    }
}
