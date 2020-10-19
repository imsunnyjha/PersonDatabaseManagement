using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> listPersonInCity = new List <Person>();
            AddRecord(listPersonInCity);
            RetrieveRecordAgeLessThanSixty(listPersonInCity);
            RetrieveRecordAgeBetweenThirteenAndEighteen(listPersonInCity);
            AverageAgeInList(listPersonInCity);
            CheckForPersonPresent(listPersonInCity);
            SkipPeopleAboveAgeSixty(listPersonInCity);
            RemovePersonFromList(listPersonInCity);
        }

        ///uc1
        private static void AddRecord(List <Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("2016110024", "Karan", "Andheri", 29));
            listPersonInCity.Add(new Person("2016110027", "Tea", "Andheri", 70));
            listPersonInCity.Add(new Person("2016110028", "Bunny", "Andheri", 18));
            listPersonInCity.Add(new Person("2016110033", "Sunny", "Andheri", 23));
            listPersonInCity.Add(new Person("2016110077", "Ajay", "Andheri", 61));
            listPersonInCity.Add(new Person("2016110125", "Saurabh", "Andheri", 26));
        }
        //uc2
        private static void RetrieveRecordAgeLessThanSixty(List<Person> listPersonInCity)
        {
            Console.WriteLine("List of People Less Than Age 60>>>>>>>>>>>");
            foreach(Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " +person.Name + " \t\tAge : " +person.Age);
            }
        }
        //uc3
        private static void RetrieveRecordAgeBetweenThirteenAndEighteen(List<Person> listPersonInCity)
        {
            Console.WriteLine("\nList of People Of age between 13 and 18>>>>>>>>>>>");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age >12 && e.Age<19)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge : " + person.Age);
            }
        }
        //uc4
        private static void AverageAgeInList(List<Person> listPersonInCity)
        {
            Console.WriteLine("\nAverage Age in The List>>>>>>>>>>");
            double ageAverage = listPersonInCity.Average(e=>e.Age);
            Console.WriteLine(ageAverage);
        }
        //uc5
        private static void CheckForPersonPresent(List<Person> listPersonInCity)
        {
            Console.WriteLine("\nChecking whether a person present or not>>>>>>>>>>");
            if (listPersonInCity.Exists(e => e.Name == "Sunny"))
            {
                Console.WriteLine("PRESENT!");
            }
        }
        //uc6
        private static void SkipPeopleAboveAgeSixty(List<Person> listPersonInCity)
        {
            Console.WriteLine("\nSkipping persons whose age is less than 60>>>>>>>>>>>>>>>");
            foreach (Person person in listPersonInCity.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }
        //uc7
        private static void RemovePersonFromList(List<Person> listPersonInCity)
        {
            Console.WriteLine("\nRemoving the person from the system>>>>>>>>>>>>>>>>");
            listPersonInCity.RemoveAll(e => (e.Name == "Karan"));
            if (listPersonInCity.TrueForAll(e => e.Name != "Karan"))
            {
                Console.WriteLine("Karan not present in system");
            }
        }
    }
}
