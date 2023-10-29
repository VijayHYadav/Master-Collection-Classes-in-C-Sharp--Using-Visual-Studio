namespace Generic_Classes
{
    public class List_Methods_Demo
    {
        static void Main() {
            Person person1 = new Person() { FirstName = "Johnny", LastName = "Walker" };
            Person person2 = new Person() { FirstName = "Ricky", LastName = "Ponting" };
            Person person3 = new Person() { FirstName = "Glen", LastName = "Smith" };
            Person person4 = new Person() { FirstName = "Tom", LastName = "Smith" };

            //create an Array of Person type
            Person[] pArray = new Person[3];
            //pArray[0] = person1;
            //pArray[1] = person2;
            //pArray[2] = person3;

            //pArray[3] = person4;

            List<Person> pList = new List<Person>(3);
            pList.Add(person1);
            pList.Add(person2);
            pList.Add(person3);
            pList.Add(person4);

            pList.Insert(1, person4);
            foreach (var p in pList)
            {
                Console.WriteLine($"First Name = {p.FirstName}, Last Name = {p.LastName}");
            }

            // ! part 2
            Console.WriteLine(pList.IndexOf(person4));
            Console.WriteLine(pList.IndexOf(person4,2));
            Console.WriteLine(pList.IndexOf(person4, 2, 3));
            if(pList.Contains(person1))
            {
                Console.WriteLine("person1 object exists in the list");
            }
            else
            {
                Console.WriteLine("person1 object doesn't exist in the list");
            }

            // ! part 3
            if(pList.Exists(p=>p.FirstName.StartsWith("G")))
            {
                Console.WriteLine("the condition is satisfied");
            }
            else
            {
                Console.WriteLine("the condition is not satisfied");
            }

            Person person = pList.Find(x => x.LastName == "Ponting");
            Console.WriteLine($"First Name = {person.FirstName}");

            person = pList.FindLast(x => x.LastName == "Smith");
            Console.WriteLine($"First Name = {person.FirstName},Last Name = {person.LastName}");
            Console.WriteLine("Find All Method .............");

            List<Person> pFindAll = pList.FindAll(x => x.LastName == "Smith");
            foreach (var p in pFindAll)
            {
                Console.WriteLine($"First Name = {p.FirstName}, Last Name = { p.LastName}");
            }

            Console.WriteLine("Now the elements of pLIst");
            foreach (var p in pList)
            {
                Console.WriteLine($"First Name = {p.FirstName}, Last Name = { p.LastName}");
            }

            //Find Index
            int index = pList.FindIndex(p => p.LastName == "Smith");
            Console.WriteLine($"The index with FindIndex is = {index}");
        }
    }
}