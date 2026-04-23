using sectionBQ1;
using System;

namespace sectionBQ1
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public double EstimatedResolutionHours { get; set; }
        public double UrgencyScore { get; set; }
        public bool IsProcessed { get; set; }

        public ServiceRequest( Resident resident, string requestType, int priorityLevel,
                            int severityLevel, int estimatedResolutionHours)
        {
            Resident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedResolutionHours;
            IsProcessed = false;
        }
    }
}