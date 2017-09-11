using System.Collections.Generic;

namespace Composite
{
    class Employee
    {
        private string Name { get; set; }
		private int Age { get; set; }
        private string Department { get; set; }
        private decimal Salary { get; set; }
        private List<Employee> Subordinates { get; set; }

        public Employee(string name, string department, decimal salary) {
            Name = name;
            Department = department;
            Salary = salary;
            Subordinates = new List<Employee>();
        }

        public void AddSubordinate(Employee emp) {
            Subordinates.Add(emp);
        }

        public void RemoveSubordinate(Employee emp) {
            Subordinates.Remove(emp);
        }

        public List<Employee> GetSubordinates() {
            return Subordinates;
        }

        public override string ToString() => $"Name: {Name}, Department: {Department}, Salary: {Salary}";
    }
}
