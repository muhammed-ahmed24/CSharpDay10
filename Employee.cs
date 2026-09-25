using System;

namespace Day10CSharp
{
    public class Employee : IComparable<Employee>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            Name = string.Empty;
        }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public virtual int CompareTo(Employee other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
        }

        public virtual object Clone()
        {
            return new Employee(Id, Name, Salary);
        }

        public override string ToString()
        {
            return $"[Employee] Id: {Id}, Name: '{Name}', Salary: {Salary:C}";
        }
    }
}
