// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList<string, int> peopleList = new SortedList<string, int>();

        // Allowing user to input names and ages for each person
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the name of person {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the age of {name}: ");
            int age = int.Parse(Console.ReadLine());

            peopleList.Add(name, age);
        }

        // Displaying names and ages in ascending order based on age
        Console.WriteLine("\nNames and Ages in Ascending Order:");
        foreach (var person in peopleList)
        {
            Console.WriteLine($"{person.Key}: {person.Value} years old");
        }

        // Allowing the user to search for a person by name and display their age
        Console.Write("\nEnter the name to search: ");
        string searchName = Console.ReadLine();

        if (peopleList.ContainsKey(searchName))
        {
            Console.WriteLine($"{searchName} is {peopleList[searchName]} years old.");
        }
        else
        {
            Console.WriteLine($"{searchName} not found in the list.");
        }
    }
}

*/
/*
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue<string> waitingLine = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n1. Enqueue (Join the line)");
            Console.WriteLine("2. Dequeue (Get service)");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1, 2, or 3): ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name to enqueue: ");
                    string person = Console.ReadLine();
                    waitingLine.Enqueue(person);
                    DisplayQueue(waitingLine);
                    break;

                case 2:
                    try
                    {
                        string servicedPerson = waitingLine.Dequeue();
                        Console.WriteLine($"{servicedPerson} got the service.");
                        DisplayQueue(waitingLine);
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("Error: The queue is empty. No one to dequeue.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void DisplayQueue(Queue<string> queue)
    {
        Console.WriteLine("Current Queue:");
        foreach (var person in queue)
        {
            Console.WriteLine(person);
        }
    }
}
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contactDictionary = new Dictionary<string, string>();

        // Allowing user to input names and phone numbers for each person
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the name of person {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the phone number for {name}: ");
            string phoneNumber = Console.ReadLine();

            contactDictionary[name] = phoneNumber;
        }

        // Allowing the user to search for a person by name and display their phone number
        while (true)
        {
            Console.Write("\nEnter the name to search (or 'exit' to exit): ");
            string searchName = Console.ReadLine();

            if (searchName.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            if (contactDictionary.ContainsKey(searchName))
            {
                string phoneNumber = contactDictionary[searchName];
                Console.WriteLine($"{searchName}'s phone number is: {phoneNumber}");
            }
            else
            {
                Console.WriteLine($"{searchName} not found in the contact list.");
            }
        }
    }
}
