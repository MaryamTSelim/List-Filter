using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Where
{
    class Employee
    {
        public string Name { set; get; }
        public int Salary { set; get; }
        public Employee(string name , int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"Name : {this.Name}\tSalary : {this.Salary}";
        }
        public Employee Clone()
        {
            return new Employee(this.Name, this.Salary);
        }
    }
}
