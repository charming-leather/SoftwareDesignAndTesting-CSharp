using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipalityApp
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public int EstimatedHours { get; set; }
        public double UrgencyScore { get; set; }

        public ServiceRequest(Resident resident, string requestType, int priority, int severity, int hours)
        {
            Resident = resident;
            RequestType = requestType;
            PriorityLevel = priority;
            SeverityLevel = severity;
            EstimatedHours = hours;
        }
    }
}
