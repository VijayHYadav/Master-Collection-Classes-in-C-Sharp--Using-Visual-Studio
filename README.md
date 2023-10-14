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