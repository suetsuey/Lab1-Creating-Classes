using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonLabFall23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beeals", 28, "Yellow", true);

            // Display Gina's information
            string ginasInfo = person2.DisplayPersonInfo();
            Console.WriteLine(ginasInfo);

            // Display Mike's information
            string mikesInfo = person3.ToString();
            Console.WriteLine(mikesInfo);

            // Change Ian's favorite color to white
            person1.ChangeFavoriteColor();

            // Display Ian's information
            string IansInfo = person1.DisplayPersonInfo();
            Console.WriteLine(IansInfo);

            // Person.ChangeFavoriteColor(person1);

            // Display Mary's age in 10 years
            int marysAgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine("Mary Beal's Age in 10 years: " + marysAgeTenYears);

            // Create Relation instances (linking Person instances together)
            Relation relation1 = new Relation("Sisterhood", person2, "Sisterhood", person4);
            Relation relation2 = new Relation("Brotherhood", person1, "Brotherhood", person3);

            // Display first relation
            Console.WriteLine(relation1.ToString());
            Console.WriteLine(relation2.ToString());

            // Create and populate list of people
            List<Person> personList = new List<Person>();

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);

            // Determine average age
            int sum = 0;

            // Get sum of everyone's age
            foreach (Person person in personList)
            {
                sum += person.Age;
            }

            // Divide sum by number of people.
            // One operand for / operator must be double for result to be double.
            double average = sum / (double) personList.Count;

            // Display average age
            Console.WriteLine("Average age is: " + average);

            // Display youngest person
            int minAge = 122;
            string youngestName = "";
            foreach (Person person in personList)
            {
                if (person.Age < minAge)
                {
                    minAge = person.Age;
                    youngestName = person.FirstName;
                }
            }
           
            Console.WriteLine("The youngest person is: " + youngestName);

            // Display oldest person
            int maxAge = 0;
            string oldestName = "";
            foreach (Person person in personList)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestName = person.FirstName;
                }
            }
            Console.WriteLine("The oldest person is: " + oldestName);

            // Display Mike's information
            Console.WriteLine(mikesInfo);

            // Display Mike's information
            string marysInfo = person4.ToString();
            Console.WriteLine(marysInfo);

            // Display Mike's information
            Console.WriteLine(mikesInfo);
        }
    }
}
