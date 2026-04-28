using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmfuleniMunicipalityApp
{
    public class UtilitiesManager
    {
        public double CalculateUrgency(ServiceRequest request)
        {
            // Urgencyy
            return (request.PriorityLevel * 2) + request.SeverityLevel - (request.EstimatedHours * 0.1);
        }

        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine("\nSERVICE REPORT");

            request.Resident.DisplayResident();

            Console.WriteLine("Request Type: " + request.RequestType);
            Console.WriteLine("Priority: " + request.PriorityLevel);
            Console.WriteLine("Severity: " + request.SeverityLevel);
            Console.WriteLine("Estimated Hours: " + request.EstimatedHours);
            Console.WriteLine("Urgency Score: " + request.UrgencyScore);
        }

        public void ShowSummary(List<ServiceRequest> resolvedRequests)
        {
            Console.WriteLine("\nSUMMARY ");

            foreach (var req in resolvedRequests)
            {
                Console.WriteLine(req.RequestType + " | Urgency: " + req.UrgencyScore);
            }

            var highest = resolvedRequests.OrderByDescending(r => r.UrgencyScore).FirstOrDefault();

            if (highest != null)
            {
                Console.WriteLine("\nHighest Urgency Request: " + highest.RequestType +
                                  " (" + highest.UrgencyScore + ")");
            }
        }
    }
}