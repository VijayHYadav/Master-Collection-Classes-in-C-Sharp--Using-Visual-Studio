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
        }
    }
}