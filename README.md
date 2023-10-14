### INTRODUCTION TO COLLECTION CLASSES IN C#

What are collections and why are they needed in C#?
A C# collection is a group of multiple objects. Collection classes are specialized classes for data storage and retrieval.
The following namespaces may be used to add, remove and modify individual elements or a range of elements in a collection:
1. System. Array (Arrays collection can't be resized dynamically at run-
time)
2. System.Collections
3. System.Collections.Generic
4. System.Collections.Concurrent
5. System.Collections.Specialized

In fact Arrays do not fall strictly under collection classes as though they are a collection, they don't possess the main two characteristics for
collection classes:
1. They are fixed in size and can't be resized dynamically(at runtime) 
2. You can not access, insert or remove items by the array index
Of the collections namespaces mentioned previously, the following two are the most often used:

1. Non-generic (System.Collections namespace)
2. Generic (System.Collections.Generic namespace)

###### <em>Generic classes are the preferred way of creating collection. They are type safe and have better overall performance than their non-generic counterparts. </em>


#### Conclusion:
In concluding, we have seen the concept of collections in C# and the possible application areas that use them. We have also seen that arrays, though a collection are not useful because of their limitations. We have also got introduced to generic and non-generic classes with a comparision between the two. We have also seen the reason of always working with generic-collections over (no-generic one) if we have the choice. We have briefly touched upon the concept of concurrent and specialized collection classes
