using System;

namespace Day10CSharp
{
    public class Manager : Employee, IComparable<Manager>
    {
        public string Department { get; set; }

        public Manager() : base()
        {
            Department = string.Empty;
        }

        public Manager(int id, string name, decimal salary, string department)
            : base(id, name, salary)
        {
            Department = department;
        }

        public int CompareTo(Manager other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
        }

        public override object Clone()
        {
            return new Manager(Id, Name, Salary, Department);
        }

        public override string ToString()
        {
            return $"[Manager] Id: {Id}, Name: '{Name}', Salary: {Salary:C}, Department: '{Department}'";
        }
    }
}
