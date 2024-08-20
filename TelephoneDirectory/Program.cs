using System;
using System.Collections.Generic;

namespace TelephoneDirectory
{
    // Class representing a Person
    public class Person
    {
        // Properties
        public int Id { get; set; }  // Unique identifier for each person
        public string Name { get; set; }  // Name of the person
        public List<Telephone> TelephoneNumbers { get; set; }  // List of telephone numbers associated with the person

        // Constructor
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
            TelephoneNumbers = new List<Telephone>();  // Initialize the list of telephone numbers
        }

        // Method to add a telephone number to the person's list
        public void AddTelephoneNumber(string number)
        {
            TelephoneNumbers.Add(new Telephone(number));  // Add a new telephone number to the list
        }

        // Method to display the person's details and their telephone numbers
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine("Telephone Numbers:");
            foreach (var telephone in TelephoneNumbers)
            {
                Console.WriteLine($"- {telephone.Number}");
            }
        }
    }

    // Class representing a Telephone
    public class Telephone
    {
        // Properties
        public string Number { get; set; }  // Telephone number

        // Constructor
        public Telephone(string number)
        {
            Number = number;
        }
    }

    // Main program
    class Program
    {
        static List<Person> directory = new List<Person>();  // List to store people in the telephone directory
        static int currentId = 1;  // Counter for unique person IDs

        static void Main(string[] args)
        {
            while (true)
            {
                // Display the menu options
                Console.WriteLine("Telephone Directory");
                Console.WriteLine("1. Add a new person");
                Console.WriteLine("2. Add a telephone number to an existing person");
                Console.WriteLine("3. Display all entries");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                // Read user input via Switch or If Else Statement 
                string choice = Console.ReadLine();

               /* switch (choice)
                {
                    case "1":
                        AddNewPerson();  // Option to add a new person
                        break;
                    case "2":
                        AddTelephoneToExistingPerson();  // Option to add a telephone number to an existing person
                        break;
                    case "3":
                        DisplayAllEntries();  // Option to display all entries in the directory
                        break;
                    case "4":
                        return;  // Exit the program
                    default:
                        Console.WriteLine("Invalid option. Please choose between 1-4.");
                        break;
                }*/
            if (choice == "1")
                {
                    AddNewPerson();
                }
            else if (choice == "2") {
                    AddTelephoneToExistingPerson();
                    else if (choice == "3") {
                        DisplayAllEntries(){
                            else if (choice == "4")
            }
                        else {Console.WriteLine("Wrong Text Entered") }
        }

        // Method to add a new person to the directory
        static void AddNewPerson()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Person newPerson = new Person(currentId++, name);  // Create a new person with a unique ID
            directory.Add(newPerson);

            Console.WriteLine($"Person added with ID: {newPerson.Id}\n");
        }

        // Method to add a telephone number to an existing person
        static void AddTelephoneToExistingPerson()
        {
            Console.Write("Enter person ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Person person = directory.Find(p => p.Id == id);
                if (person != null)
                {
                    Console.Write("Enter telephone number: ");
                    string number = Console.ReadLine();

                    person.AddTelephoneNumber(number);  // Add the telephone number to the person's list
                    Console.WriteLine("Telephone number added.\n");
                }
                else
                {
                    Console.WriteLine("Person not found.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid number.\n");
            }
        }

        // Method to display all entries in the directory
        static void DisplayAllEntries()
        {
            Console.WriteLine("Directory Entries:");
            foreach (var person in directory)
            {
                person.DisplayPersonInfo();  // Display each person's details
                Console.WriteLine();
            }
        }
    }
}
