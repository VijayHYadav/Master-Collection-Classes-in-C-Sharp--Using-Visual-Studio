namespace OOPS
{
    public class TypeCheck
    {
        public Employee GetEmployee(object employee)
        {
            // You ask the argument you received - hey argument, what's your type?
            // You can check the class of the supplied object by calling
            // the method GetType() method on the argument
            if (employee.GetType() == typeof(Employee))
            {
                var theEmployee = employee as Employee; // cast
                theEmployee.Department = "HR";
                return theEmployee;
            }
            else
            {
                return null;
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}