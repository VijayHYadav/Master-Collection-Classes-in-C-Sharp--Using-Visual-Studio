using System.Collections;

namespace NonGenericClassDemo {
    class Program {
        static void Main(string[] args) {

            Employee emp1 = new Employee() { Id = 1, Name = "Steve", Department = "IT", Salary = 4500 };
            Employee emp2 = new Employee() { Id = 2, Name = "Glen", Department = "HR", Salary = 5500 };
            Employee emp3 = new Employee() { Id = 3, Name = "Bill", Department = "Sales", Salary = 7500 };
            Employee emp4 = new Employee() { Id = 4, Name = "Sally", Department = "Ops", Salary = 6000 };

            //Create an array of Employee 
            Employee[] employees = new Employee[3];
            employees[0] = emp1;
            employees[1] = emp2;
            employees[2] = emp3;
            // employees[3] = emp4; // ! Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

            Console.WriteLine("=========================================================================");
            foreach (var item in employees)
            {
                Console.WriteLine($"Array Elements are:ID={item.Id},Name={item.Name},Department={item.Department},Salary={item.Salary}");
            }

            ArrayList arrayList = new ArrayList(2);
            arrayList?.Add(emp1);
            arrayList?.Add(emp2);
            arrayList?.Add(emp3);
            arrayList?.Add(emp4);

            Console.WriteLine("==========================================================================");

            foreach (var item in arrayList!)
            {
                Console.WriteLine($"ArrayList Elements are:ID={((Employee)item).Id},Name={((Employee)item).Name}," +
                    $"Department={((Employee)item).Department},Salary={((Employee)item).Salary}");
            }

        }
    }
}