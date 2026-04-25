using sectionBQ1;
using System;
using System.Collections.Generic;

namespace sectionBQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome To Emfuleni Municipality Service Management System ===");
            Console.WriteLine("This system helps manage utility service requests for residents.");
            Console.WriteLine(               );

            var manager = new UtilitiesManager();
            var residents = new List<Resident>();

            // Add residents
            Console.Write("Enter number of residents you want to register: ");

            int numResidents = ReadInt();

            for (int i = 1; i <= numResidents; i++)
            {
                Console.WriteLine("" +
                    $"(--- Resident {i} ---)");

                Console.Write("Name: ");
                string name = ReadString();

                Console.Write("Address: ");
                string address = ReadString();

                Console.Write("Account Number: ");
                string account = ReadString();

                Console.Write("Monthly Utility Usage (kWh): ");
                int usage = ReadInt();

                Console.WriteLine();

                residents.Add(new Resident(name, address, account, usage));
            }

            // Add service requests
            Console.Write("Enter number of service requests you want to register: ");
            int numRequests = ReadInt();

            for (int i = 1; i <= numRequests; i++)
            {
                Console.WriteLine($"Service Request {i} ");

                Console.Write($"Select resident (1-{residents.Count}): ");
                int resIndex = ReadInt() - 1;

                // Index Validation
                if (resIndex < 0 || resIndex >= residents.Count)
                {
                    Console.WriteLine("Invalid resident selection. Try again.");
                    i--;
                    continue;
                }

                Console.Write("Request Type (e.g., Water Leak, Power Outage,Burst Pipe): ");
                string type = ReadString();

                Console.Write("Priority Level (1-5, 1=URGENT): ");
                int priority = ReadInt();

                Console.Write("Severity Level (1-10): ");
                int severity = ReadInt();

                Console.Write("Estimated Resolution Hours: ");
                int hours = ReadInt();

                manager.AddServiceRequest(residents[resIndex], type, priority, severity, hours);
            }

            // Process requests
            while (manager.HasPendingRequests())
            {
                manager.DisplayPendingRequests();

                Console.Write("Select request number to process (0 to skip): ");
                int choice = ReadInt();

                if (choice == 0)
                    break;

                var processed = manager.ProcessRequest(choice);

                if (processed != null)
                {
                    manager.GenerateServiceReport(processed);
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

            // Conclution and show summary
            manager.GenerateFinalSummary();
        }


        // Reads and returns a valid integer from the user
        static int ReadInt()
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                    return value;

                Console.Write("Invalid number, try again: ");
            }
        }

        static string ReadString()
        {
            string? input = Console.ReadLine();

            return input ?? "";
        }
    }
}