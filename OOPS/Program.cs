using System.Reflection;
using OOPS;

// Early binding
Employee employee = new Employee();

int salary = employee.GetSalary(2500);

Console.WriteLine($"Salary is = {salary}");



//Late binding
Assembly assembly = Assembly.GetExecutingAssembly();

Type employeeType =  assembly.GetType("OOPS.Employee");

object employeeInstance =  Activator.CreateInstance(employeeType);

MethodInfo getSalaryMethod = employeeType.GetMethod("GetSalary");

int[] param = new int[1];
param[0] = 4000;

int salary2 =  (int) getSalaryMethod.Invoke(employeeInstance, param.Cast<object>().ToArray());

Console.WriteLine($"Salary is by late binding = {salary2}");
