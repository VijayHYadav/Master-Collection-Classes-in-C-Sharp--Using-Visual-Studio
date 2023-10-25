using OOPS;

TypeCheck typeCheck = new TypeCheck();
Employee emp = new  Employee();
typeCheck.GetEmployee(emp);

Console.WriteLine($"{emp.Department}");