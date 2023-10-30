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


COLLECTIONS (NON-GENERIC CLASSES)
Hashtable class:
- Represents a collection of key/value pairs that are organized based on
the hash code of the key. It uses the key to access the elements of the collection class.
- Hashtable class is inherited from Object class. 
- Implements the following interfaces:
Icollection, Idictionary, lenumerable, Icloneable, IDeserializationCallback, ISerializable

During the course of this section, I strongly recommend the learners to frequent the following MS link 
for official documentation on non-generic collection classes:
https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8 
Also for a history of .Net framework releases please visit : https://en.wikipedia.org/wiki/.NET Framework version history
If you have been using earlier versions of the framework you could still switch over to your version on the first 
link on top to get the documentation for that version



COLLECTIONS (GENERIC CLASSES)
- Generics were added to version 2.0 of the C# language
- The most common use of generics is to create collection classes known as Generic collection classes.
- The Generic collection classes uses System.Collections.Generic namespace.
- Generics introduce to the .NET Framework the concept of type parameters.
- Type parameters make it possible to design classes and methods that defer the specification of one or 
more types until they are declared and
instantiated by client code.
- By using a generic type parameter T, we can write a single class that other client code can use 
without incurring the risk or cost of  boxing operations, as shown in the next slide

```

CODE EXAMPLES(GENERIC TYPE<T>)

// Declare the generic class.
public class GenericList<T>
{
    public void Add(T input) {Console.WriteLine($"Parameter type = {typeof(T).ToString()}, value = = {input}"); }
}

class TestGenericList
{
    private class ExampleClass {}
    static void Main()
    {
        // Declare a list of type int.
        GenericList<int> list1 = new GenericList<int>();
        list1.Add(1);
        list1.Add(2);

        // Declare a list of type string.
        GenericList<string> list2 = new GenericList<string>();
        list2.Add("hello");
        list2.Add("world!");

        // Declare a list of type ExampleClass.
        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
        list3.Add(new ExampleClass());
    }
}

```

# COLLECTIONS (GENERIC CLASSES)
- Generic classes are the preferred way of creating collection.
- They are type safe and have better overall performance than their non- generic counterparts.
- Generic types should be used to maximize code reuse.
- However we need to study non-generic classes to maintain legacy applications in C#
- You can create your own generic interfaces, classes, methods, events and delegates.
- Generic classes may be constrained to be used on particular data types. (An example code is as in the next slide)
- This increases the number of allowable operations and method calls to those supported by the constraining type and all types in its inheritance hierarchy


### Constraint by Value type:
    You can constrain a generic type to a value type by setting the constraint of the type as follows.
    ```class ConstrainByValueType<T> where T: struct {}```
    Here the struct keyword is used to constrain T to a value type. The object can then be instantiated like new ConstrainByValueType<double>, and you can specify any value type as you want.
### Constraint to Allow Only Reference Types
    You can also constrain the type to allow only reference types. Similar to how you would do it for value types, you would use the class keyword to constrain the type to a reference type.
    ```class ConstrainByReferenceType<T> where T : class {}```


### Interface Type Constraint
You can constrain the generic type by interface, thereby allowing only classes that implement that interface or classes that inherit from classes that implement the interface as the type parameter. The code below constrains a class to an interface.

interface IShape { }
class Square IShape {}
interface IFourSidedShape: IShape { } class Rectangle : IFourSidedShape {} class Small Rectangle : Rectangle { }
class ConstrainByInterface<T> where T : IFourSidedShape {}

The type T above is constrained to the IFourSidedShape interface, which allows only classes that implements this interface (or classes that inherit from a class that 
implements the interface) to access the generic type. Even if the IFourSidedShape inherits from the IShape interface, you can't use Square as the type for T. You can only 
use Rectangle or Small Rectangle type.


### Interface Type Constraint
You can constrain the generic type by interface, thereby allowing only classes that implement that interface or classes that inherit from classes that implement the 
interface as the type parameter. The code below constrains a class to an interface.

```interface IShape { }
class Square IShape {}
interface IFourSidedShape: IShape { } 
class Rectangle : IFourSidedShape {} 
class Small Rectangle : Rectangle { }
```
class ConstrainByInterface<T> where T : IFourSidedShape {}
The type T above is constrained to the IFourSidedShape interface, which allows only classes that implements this interface (or classes that inherit from a class that implements the interface) to access the generic type. Even if the IFourSidedShape inherits from the IShape interface, you can't use Square as the type for T. You can only use Rectangle or Small Rectangle type.


- In the previous slide, we are constraining T to use IRectangle interface and it must have a parameterless public constructor.
- We have two classes which implement IRectangle interface.
- The Small Rectangle class implements this interface but has a public constructor with parameters (and no public parameterless constructor). 
- This doesn't satisfy the condition to use it as the type for the generic class. The BigRectangle class satisfies the condition and can be used as 
the type parameter for the generic class.


### When to Use Generic Collections
- Using generic classes is usually recommended, as we gain the immediate benefit of type safety
- We don't have to derive from a base collection class and implement type specific members for achieving type safety
- Generic collection types perform better than the corresponding nongeneric collection types, because with generics there is no need to box the elements.


# Generic Collection Classes (List<T>)


List<T>
- List<T> is a generic type of collection so it will allow to store only strongly typed objects i.e. an elements of same data type
- Implements eight different interfaces : ICollection<T>, IEnumerable<T> IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection
IEnumerable, IList
- Represents list of objects that can be accessed by index. Provides methods to search, sort and manipulate lists.
- It is different from the arrays. A List<T> can be resized dynamically but arrays cannot.
- List<T> class is the generic equivalent of ArrayList class by implementing the IList<T> generic interface.
- List<T> class can accept null as a valid value for reference types and it also allows duplicate elements.
- If the Count becomes equals to Capacity, then the capacity of the List increased automatically by reallocating 
the internal array. The existing elements will be copied to the new array before the addition of the new element.
- List<T> class is not sorted by default and elements are accessed by zero-based index.


List<T> Commonly Used Methods:

- Add => Add an element at the end of the List<T>
- AddRange =>Adds elements of the specified collection at the end of a List<T>.
- Insert => Inserts an element at any specified index
- IndexOf => Finding the position of a particular object
- Contains => Checks to see if a list contains an item
- Exists => Checks if a list satisfies a specified condition
- Find Finds the first match based on a specific condition(predicate function)
- Remove => Removes the first occurence of the specified element.
- TrimExcess => Sets the capacity to the actual number of elements in the List<T> if that number is less than a threshold value.


List<T> Properties:
- Capacity => The number of elements that the List<T> can contain before it needs resizing (The initial capacity of List<T> is 0.) 
- Count => The number of elements contained in the List<T>
The Capacity can be trimmed to be equal to the number of elements in the collection (represented by Count property) by using 
TrimExcess method as shown in the demo in Visual Studio

# HashSet<T> Class
- The collections we learnt so far like List<T>, ArrayList simply allow adding values to an object of these types and allow duplication of
elements, i.e. they don't check for any duplication
- To avoid such duplication, .NET framework provides a collection name set This is a collection type with distinct items
Set has two types: HashSet and SortedSet

Q. What is the difference between a HashSet and a SortedSet?
Ans. Although both the types store unique or distinct items, if you prefer performance over ordered collection, then the choice 
should be HashSet. On the other hand, if you want the items sorted after insertion in the collection and are ready to take a performance hit, 
then choose SortedSet.


### HashSet<T> Commonly Used Methods
- Add(T) => Adds the specified element to a set
- Clear() =>Removes all elements from a HashSet<T> object 
- Contains(T) => Determines if a HashSet<T> object contains the specified element
- ExceptWith(IEnumerable<T>) =>Removes all matching elements in the specified collection from the current HashSet<T> object 
- IntersectWith(IEnumerable<T>) =>Modifies the current HashSet<T> object to contain only elements that are present in that object and the specified collection
- IsProperSubsetOf(<T>) => Determines if a HashSet<T> object is a proper subset of the specified collection
- IsProperSupersetOf(<T>) => Determines if a HashSet<T> object is a proper superset of the specified collection.
- Remove(T) => Removes the specified element from HashSet<T> object 
- Remove Where(Predicate<T>) => Removes all elements that match the conditions defined by the specified predicate 
from a HashSet<T> collection (Example shown in Visual Studio)
- SymmetricExceptWith(IEnumerable<T>) => Modifies the current HashSet<T> object to contain elements present in that 
object or in the specified collection, but not both
- UnionWith(IEnumerable<T>) => Modifies the current HashSet<T> object to contain elements that are present in tself, the specified collection, or both.
Besides the above methods, the count property is available


# SortedSet<T> Class
- This is a generic collection type with distinct items which are maintained in ascending sort order.
- It also provides many mathematical set operations: union, intersection and difference.
- Because it sorts the set, the performance takes a hit as compared to the HashSet<T> discussed previously.
- A SortedSet<T> should be used when you need a sorted collection of unique elements.


# SortedSet<T> Commonly Used Methods
#### As you may expect, there are many methods which are used both in the HashSet<T> and SortedSet<T> as below:
- Add<T>, 
- Clear(), 
- Contains(T), 
- ExceptWith(IEnumerable<T> 
- IntersectWith(IEnumerable<T>), 
- IsProper SupersetOf(<T>),
- IsProper SubsetOf(<T>), 
- Remove(T), 
- Remove Where(Predicate<T>), 
- SymmetricExceptWith(IEnumerable<T>), 
- UnionWith(IEnumerable<T>)

#### The following two methods, however, are for SortedSet<T> and not available in HashSet<T>
1. GetViewBetween(T,T) => Returns a view of a subset in SortedSet<T> 
2. Reverse() => Reverses the set to a descending order
Besides the above, Overlaps(IEnumerable<T>) determines if the 
current SortedSet<T> object and a specified collection share common elements