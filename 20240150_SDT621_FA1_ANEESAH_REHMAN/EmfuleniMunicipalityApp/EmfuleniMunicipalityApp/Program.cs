using System;
using System.Collections.Generic;

namespace EmfuleniMunicipalityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Emfuleni Municipality Service Desk\n");
            List<Resident> residents = new List<Resident>();
            List<ServiceRequest> requests = new List<ServiceRequest>();
            List<ServiceRequest> resolved = new List<ServiceRequest>();

            UtilitiesManager manager = new UtilitiesManager();
            
            // Get the number of residents
            int numResidents;
            while (true)
            {
                Console.Write("Enter number of residents that you want to register: ");
                if (int.TryParse(Console.ReadLine(), out numResidents) && numResidents > 0)
                    break;
                Console.WriteLine("Invalid number. Try again.");
            }

            for (int i = 0; i < numResidents; i++)
            {
                Console.WriteLine($"\nRESIDENT {i + 1}");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Account Number: ");
                string acc = Console.ReadLine();

                double usage;
                while (true)
                {
                    Console.Write("Monthly Utility Usage (kWh or literes): ");
                    if (double.TryParse(Console.ReadLine(), out usage))
                        break;
                    Console.WriteLine("Invalid input. Enter a number.");
                }

                residents.Add(new Resident(name, address, acc, usage));
            }// close for

            // Get the number of service requests
            int numRequests;
            while (true)
            {
                Console.Write("\nHow many service requests do you want to log? ");
                if (int.TryParse(Console.ReadLine(), out numRequests) && numRequests > 0)
                    break;
                Console.WriteLine("Invalid number. Try again.");
            }

            for (int i = 0; i < numRequests; i++)
            {
                Console.WriteLine($"\nREQUEST {i + 1}");

                // Show residents
                for (int r = 0; r < residents.Count; r++)
                {
                    Console.WriteLine($"{r}: {residents[r].Name}");
                }

                // Index input depending on how many residents where registerd
                int index;
                while (true)
                {
                    Console.Write("Select Resident (0 to " + (residents.Count - 1) + "): ");

                    if (int.TryParse(Console.ReadLine(), out index) &&
                        index >= 0 && index < residents.Count)
                        break;

                    Console.WriteLine("Invalid index. Try again.");
                }

                Console.Write("Request Type (e.g., Water Outage, Burts pipe): ");
                string type = Console.ReadLine();

                int priority;
                while (true)
                {
                    Console.Write("Priority (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out priority) && priority >= 1 && priority <= 5)
                        break;
                    Console.WriteLine("Enter a number between 1 and 5.");
                }

                int severity;
                while (true)
                {
                    Console.Write("Severity (1-10): ");
                    if (int.TryParse(Console.ReadLine(), out severity) && severity >= 1 && severity <= 10)
                        break;
                    Console.WriteLine("Enter a number between 1 and 10.");
                }

                int hours;
                while (true)
                {
                    Console.Write("Estimated Resolution Hours: ");
                    if (int.TryParse(Console.ReadLine(), out hours) && hours >= 0)
                        break;
                    Console.WriteLine("Enter a valid number.");
                } // close while

                ServiceRequest req = new ServiceRequest(residents[index], type, priority, severity, hours);

                req.UrgencyScore = manager.CalculateUrgency(req);

                requests.Add(req);
            } // close for

            // Display queue 
            Console.WriteLine("\nREQUEST QUEUE");
            for (int i = 0; i < requests.Count; i++)
            {
                Console.WriteLine($"{i}: {requests[i].RequestType} | Urgency: {requests[i].UrgencyScore}");
            }

            // Process requests 
            while (requests.Count > 0)
            {
                Console.WriteLine("\nRemaining Requests:");
                for (int i = 0; i < requests.Count; i++)
                {
                    Console.WriteLine($"{i}: {requests[i].RequestType}");
                }

                int choice;
                while (true)
                {
                    Console.Write("Enter index of request to process: ");
                    if (int.TryParse(Console.ReadLine(), out choice) &&
                        choice >= 0 && choice < requests.Count)
                        break;

                    Console.WriteLine("Invalid index. Try again.");
                } // close while

                ServiceRequest selected = requests[choice];

                manager.GenerateReport(selected);

                resolved.Add(selected);
                requests.RemoveAt(choice);
            }// close while

            // Summaryy
            manager.ShowSummary(resolved);

            Console.WriteLine("\nAll requests processed.");
        } // close Main
    }// close program
}// close