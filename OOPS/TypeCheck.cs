namespace OOPS
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public string testString = "";
        public int testInt = 0;

        public Employee()
        {
            this.Id = 0;
            this.Salary = 0;
        }

        public Employee(int id, string name, string department)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
        }

        public void Print()
        {
            Console.WriteLine("I am the print method");
        }

        public int Add()
        {
            int a = 9;
            int b = 8;
            Console.WriteLine("I am the print method");
            return (a + b);
        }

        public int GetSalary(int salary)
        {
            return salary;
        }
    }
}