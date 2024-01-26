using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Lab1
{
    public class Person
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int Age { get; set; }
        public bool isWorking { get; set; }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{firstName} {lastName }");

            Console.WriteLine($"Person ID: {ID}, and their favorite colour is: {favoriteColour}");
        }

        public void ChangeColourToWhite()
        {
            favoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return Age + 10;
        }

        public string DisplayAllInfo()
        {
            return $"Persons ID:{ID}, FirstName:{firstName}, LastName:{lastName}, Favorite colour:{favoriteColour}, Age:{Age}, isWorking:{isWorking}";
        }

    }

    public class Relation
    { 
        public string RelationshipType { get; set; }
        public Relation(string relationshipType)
        {
            RelationshipType = relationshipType;
        }
        public void ShowRelationship(Person person1,  Person person2)
        {
            Console.WriteLine($"{person1.firstName} is {RelationshipType} of {person2.firstName}");
        }
    }

    class Program
    {
        static void Main(string[] args )
        {
            Person person = new Person()
            {
                ID = 640982,
                firstName = "Mountain",
                lastName = "Drew",
                favoriteColour = "Blue",
                Age = 28,
                isWorking = true


            };

            person.DisplayPersonInfo();

            person.ChangeColourToWhite();
            person.DisplayPersonInfo();

            int ageInTenYears = person.GetAgeInTenYears();
            Console.WriteLine($"The persons age in ten years will be {ageInTenYears}");

            person.DisplayAllInfo();

            string allInfo = person.DisplayAllInfo();
            Console.WriteLine($"{allInfo}");

            Console.ReadLine();


            Person person1 = new Person
            {
                ID = 321,
                firstName = "Joe",
                lastName = "Blow",
                favoriteColour = "red",
                Age = 19,
                isWorking = true
            };

            Person person2 = new Person
            {
                ID = 456,
                firstName = "Bob",
                lastName = "Flow",
                favoriteColour="green",
                Age = 20,
                isWorking = true
            };

            person1.DisplayPersonInfo();
            person2.DisplayPersonInfo();    


            Relation brotherRelation = new Relation("Brother");

            brotherRelation.ShowRelationship(person1 , person2);

            Console.ReadLine();
        }

    }
  
}
