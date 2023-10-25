using System.Reflection;
using OOPS;

Employee employee = new Employee();
Type T = employee.GetType();

Console.WriteLine($"The full name of the type is {T.FullName}");
Console.WriteLine($"The name of the type is {T.Name}");
Console.WriteLine($"The namespace is {T.Namespace}");

PropertyInfo[] properties = T.GetProperties();

Console.WriteLine("Each of the properties of the type T has the following details:");

foreach (PropertyInfo property in properties)
{
    Console.WriteLine($"Name = {property.Name}, Type = {property.PropertyType.Name}");
}

MethodInfo[] methods = T.GetMethods();

Console.WriteLine("Each of the methods of the type T has the following details:");

foreach (MethodInfo method in methods)
{
    Console.WriteLine($"Name = {method.Name}, Return Type = {method.ReturnType.Name}");
}

ConstructorInfo[] constructors = T.GetConstructors();

Console.WriteLine("Each of the constructor of the type T has the following details:");

foreach (ConstructorInfo constructor in constructors)
{
    Console.WriteLine($"Name = {constructor.Name}, Parameters = {constructor}");
}

FieldInfo[] fields = T.GetFields();

Console.WriteLine("Each of the fields of the type T has the following details:");

foreach (FieldInfo field in fields)
{
    Console.WriteLine($"Name = {field.Name}");
}