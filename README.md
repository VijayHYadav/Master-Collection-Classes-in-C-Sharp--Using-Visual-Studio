### INTERFACE IN C#

An interface contains definitions for a group of related functionalities
that a class can implement.

An interface in C# contains only the definition of the methods, properties, and events, but not the implementation.

It is left to the class that implements the interface by providing implementation for all the members of the interface.

From another perspective, interface could be viewed as a blueprint that all the classes inheriting (or implementing) the interface should follow.

1. The class can inherit from multiple (more than one) interfaces (multiple inheritance)
2. The implementing classes for the interfaces must implement the method(define the method body) whose signature is defined in the interface
3. The implementing class can have its own methods as well(as implementing the interface methods)

###### Other features of an interface:
- Like classes interfaces can also contain properties, methods, events and delegates (but no fields) with only declaration and no
implementation
- By default, interface members are public and so they don't allow explicit access modifiers
- When a class implements(inherits) from an interface, it must provide implementation for all interface members. We get a compile error otherwise.
- Interfaces can also inherit from other interfaces. A class inheriting (or implementing) this interface is required to implement all the members of the entire interface inheritance chain
- An Interface reference variable can point to a derived class object however, the interfaces
can't be instantiated.


### ABSTRACT CLASSES
- A key skill in object-oriented programming is the ability to factor out common features to a higher level in the class hierarchy
- Higher up the class hierarchy the classes become more general and abstract.
- Some classes high up the hierarchy are so general that they are considered more as a framework for other classes than a class from which objects will be directly created.

- An abstract class represents a generic concept in a class hierarchy. It is insufficiently defined to be useful by itself and contains a partial 
description (methods) that are inherited by all of its descendants in the class hierarchy.
- An abstract class contains abstract methods which must be overridden.

- An abstract class cannot be instantiated and usually contains one or more abstract methods, which have no definition.
- There is no code defined for an abstract method, and so it can’t be directly invoked.
- An abstract class might also contain methods that are not abstract, meaning that method definition is provided as usual.
- An abstract class can contain data declaration as usual.

###### <em>An abstract class cannot be instantiated. It represents a concept on which other classes can build their definitions.</em>

- A class is declared as abstract by including the abstract modifier in the class header.
- In abstract classes, the abstract modifier must be applied to each abstract method.
- Any class that contains one or more abstract methods must be declared as abstract.
- Note: because a subclass must provide an implementation for an abstract method, the method must have either public or protected visibility.


REFLECTION IN C#
Reflection is a way to inspect the assembly meta data in at runtime. It is used to find all types in an assembly and/or dynamically invoke methods in an assembly
Applications:
1. The properties window in a win forms or asp.net web applications, where a control is dragged and dropped on forms, uses reflection to
show all the properties of the control(say button) under context. 
2. We can achieve late binding by using reflection to dynamically create an instance of a type, about which we don't have any knowledge at compile time. This way, reflection allows us to use code that's not available at compile time.

- Reflection also means "asking an object questions about itself." It could also mean asking the runtime questions about an object. 
- There are many possible scenarios where you need to do that, but here is one
- Let's say, you are asked to write a method named GetEmployee, which will receive an Employee class object. The method should set 
the name of the Employee's department and return that object to the caller.

REFLECTION IN C#
If you are new programmer, you could declare the method (with some comments):
```
public Employee GetEmployee(object employee)
{
    // You need to make sure before you do anything with the 
    //argument that it *is* indeed an object of the Employee class. 
    // How would you do that?
    // This is an example where you need to know stuff about an // 
    //object. So, you ask the object or use one of the operators that 
    //allows you to reflect on the object's type.
}
```

### Section 4: Non-Generic Collection Classes(ArrayList)

COLLECTIONS (NON-GENERIC CLASSES)
- ArrayList
    - Implements the IList interface using an array whose size is dynamically increased as required.
    - An implementation of IList interface is available at the MS- documentation at https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist?view=netframework-4.8
    - An arraylist represents an ordered collection of an object that can be indexed individually.
    - Although similar to an array, the difference is in the ability to add/remove items from a list at a specified position using an index.
    - It also allows dynamic memory allocation, searching and sorting items in the list.

MICROSOFT DOCUMENTATION
During the course of this section, I strongly recommend the learners to frequent the following MS link for official documentation on non-generic collection classes:
https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8 Also for a history of .Net framework releases please visit : https://en.wikipedia.org/wiki/.NET Framework version history
If you have been using earlier versions of the framework you could still switch over to your version on the first link on top to get the documentation for that version


14. Arrays and Non-Generic Classes
Learning Outcome:
To demonstrate that Arrays are fixed in size and can't resize dynamically Compare this with ArrayList which can be resized dynamically at runtime
To display the Array and ArrayList collection on the console

• Lesson Plan:
- 1.Create an array of Employee type with a size (say3)
- 2.Add 4 items to the array.
- 3.Compile the app and show it compiles.
- 4.Run the app, it fails with an exception.
- 5.Create an array list with a size (say2).
- 6.Add some Employee objects more than the size .
- 7.Compile and run and show it grows dynamically at runtime without any exception.