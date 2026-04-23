
using sectionBQ1;
using System;
using System.Collections.Generic;
using System.Linq;

public class UtilitiesManager
{
    private List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
    private int nextRequestId = 1;

    public void AddServiceRequest(Resident resident, string requestType, int priorityLevel,
                                  int severityLevel, int estimatedResolutionHours)
    {
        var request = new ServiceRequest( resident, requestType,
                                         priorityLevel, severityLevel,
                                         estimatedResolutionHours);

        request.UrgencyScore = CalculateUrgencyScore(request);
        serviceRequests.Add(request);
    }

    // FIXED: public + returns double
    public double CalculateUrgencyScore(ServiceRequest request)
    {
        double priorityWeight = 10.0 / request.PriorityLevel;

        return (priorityWeight * request.SeverityLevel)
             + (request.Resident.MonthlyUtilityUsage / 100);
    }

    public void DisplayPendingRequests()
    {
        var pending = serviceRequests
            .Where(r => !r.IsProcessed)
            .OrderByDescending(r => r.UrgencyScore)
            .ToList();

        Console.WriteLine("\n=== PENDING SERVICE REQUESTS ===");

        for (int i = 0; i < pending.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pending[i].Resident.Name} - " +
                              $"{pending[i].RequestType} - " +
                              $"Urgency: {pending[i].UrgencyScore:F2}");
        }
    }

    public ServiceRequest ProcessRequest(int index)
    {
        var pending = serviceRequests
            .Where(r => !r.IsProcessed)
            .OrderByDescending(r => r.UrgencyScore)
            .ToList();

        if (index >= 1 && index <= pending.Count)
        {
            var request = pending[index - 1];
            request.IsProcessed = true;
            return request;
        }

        return null;
    }

    public void GenerateServiceReport(ServiceRequest request)
    {
        Console.WriteLine("\n=== SERVICE REPORT ===");
        Console.WriteLine($"Resident: {request.Resident.Name}");
        Console.WriteLine($"Address: {request.Resident.Address}");
        Console.WriteLine($"Account: {request.Resident.AccountNumber}");
        Console.WriteLine($"Usage: {request.Resident.MonthlyUtilityUsage:F2}");
        Console.WriteLine($"Request Type: {request.RequestType}");
        Console.WriteLine($"Priority: {request.PriorityLevel}");
        Console.WriteLine($"Severity: {request.SeverityLevel}");
        Console.WriteLine($"Estimated Hours: {request.EstimatedResolutionHours}");
        Console.WriteLine($"Urgency Score: {request.UrgencyScore:F2}");
        Console.WriteLine("Household Impact:" + (request.Resident.MonthlyUtilityUsage > 500 ? " HIGH" : " LOW"));
        Console.WriteLine("Status: PROCESSED");
    }

    public void GenerateFinalSummary()
    {
        var processed = serviceRequests.Where(r => r.IsProcessed).ToList();

        Console.WriteLine("\n=== FINAL MUNICIPAL SUMMARY ===");
        Console.WriteLine($"Total Processed: {processed.Count}");

        if (processed.Any())
        {
            var highest = processed
                .OrderByDescending(r => r.UrgencyScore)
                .First();

            Console.WriteLine("Highest Urgency:");
            Console.WriteLine($"{highest.Resident.Name}");
            Console.WriteLine($"{highest.RequestType}");
            Console.WriteLine($"Score: {highest.UrgencyScore:F2}");
            Console.WriteLine("Household Impact:" + (highest.Resident.MonthlyUtilityUsage > 500 ? " HIGH" : " LOW"));
        }
    }

    public bool HasPendingRequests()
    {
        return serviceRequests.Any(r => !r.IsProcessed);
    }
}