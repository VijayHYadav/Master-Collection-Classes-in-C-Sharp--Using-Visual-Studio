using System.Collections;

namespace NonGenericClassDemo
{
    partial class ArrayListCollection
    {
        void AddGetPerson()
        {
            ArrayList a1 = new ArrayList();
            Person p1 = new Person("Rob", "William");
            Person p2 = new Person("Jack", "Brow");
            Person p3 = new Person("Julie", "Binn");

            a1.Add(p1);
            a1.Add(p2);
            a1.Add(p3);

            foreach (var item in a1) // todo because I have put it as a var type we have to cast back to Person type.
            {
                Console.WriteLine("First Name is {0}, Last Name is {1}", ((Person)item).FirstName, ((Person)item).LastName);
            }
            // OR
            foreach (Person item in a1)
            {
                Console.WriteLine("First Name is {0}, Last Name is {1}", item.FirstName, item.LastName);
            }
        }
    }
}