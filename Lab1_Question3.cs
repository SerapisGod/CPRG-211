using System;
using System.ComponentModel.Design.Serialization;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Question3_Lab1
{
    public class Person
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        public Person(int id, string first, string last, string colour, int personAge, bool working)
        {
            ID = id;
            firstName = first;
            lastName = last;
            favoriteColour = colour;
            age = personAge;
            isWorking = working;
        }
    }

    class Program
    {
        static void Main()
        {
            Person Ian = new Person(1, "Ian", "Brookes", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine($"ID:{Gina.ID} First Name:{Gina.firstName} Last name: {Gina.lastName} and her favorite colour is {Gina.favoriteColour}.");

            Console.WriteLine($" ");
            Console.WriteLine($"Mikes information:");
            Console.WriteLine($"ID: {Mike.ID}");
            Console.WriteLine($"First Name: {Mike.firstName}");
            Console.WriteLine($"Last Name: {Mike.lastName}");
            Console.WriteLine($"Favorite Colour: {Mike.favoriteColour}");
            Console.WriteLine($"Age; {Mike.age}");
            Console.WriteLine($"Is Working: {Mike.isWorking}");

            Ian.favoriteColour = "White";
            Console.WriteLine($" ");
            Console.WriteLine($"Ians Brookes's favorite colour is: {Ian.favoriteColour}");

            Console.WriteLine($" ");
            Console.WriteLine($"Mary's age after ten years will be {Mary.age + 10}");

            List<(Person, Person, string)> relationships = new List<(Person, Person, string)>
            {
                (Gina, Mary, "Sisters"),
                (Ian, Mike, "Brothers")
            };

            foreach (var relationship in relationships)
            {
                Console.WriteLine($"{relationship.Item1.firstName} and {relationship.Item2.firstName} are {relationship.Item3}.");
            }

            List<Person> peopleList = new List<Person> { Ian, Gina, Mike, Mary};

            double averageAge = peopleList.Average(p => p.age);
            Console.WriteLine($"The Average Age: {averageAge}");

            Person youngestPerson = peopleList.OrderBy(p => p.age).First();
            Person oldestPerson = peopleList.OrderByDescending(p => p.age).First();
            Console.WriteLine($"Youngest Person: {youngestPerson.firstName}, Oldest Person: {oldestPerson.firstName}");

            List<string> namesStartingWithM = peopleList.Where(p => p.firstName.StartsWith("M")).Select(p => p.firstName).ToList();
            Console.WriteLine($"Names starting with M: {string.Join(", ", namesStartingWithM)}");

            List<Person> blueLovers = peopleList.Where(p => p.favoriteColour.Equals("Blue")).ToList();
            if (blueLovers.Any())
            {
                Console.WriteLine("The people who love blue are:");
                foreach (var person in blueLovers)
                {
                    Console.WriteLine($"ID: {person.ID}, Name: {person.firstName} {person.lastName}, Age: {person.age}");
                }
            }
            else
            {
                Console.WriteLine("Nobody loves the colour blue.");
            }
        }
    }
    
}
