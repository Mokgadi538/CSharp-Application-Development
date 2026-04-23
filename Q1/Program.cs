using System;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "";
            int subject1, subject2, subject3;

            // Student Name Validation
            do
            {
                Console.Write("Enter student name: ");
                studentName = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    Console.WriteLine("Name cannot be empty, please enter a valid name.");
                }

            } while (string.IsNullOrWhiteSpace(studentName));

            // Subject 1 Validation
            Console.Write("Enter mark for Subject 1: ");
            while (!int.TryParse(Console.ReadLine(), out subject1))
            {
                Console.Write("Subject cannot be empty, please enter numbers only for Subject 1: ");
            }

            // Subject 2 Validation
            Console.Write("Enter mark for Subject 2: ");
            while (!int.TryParse(Console.ReadLine(), out subject2))
            {
                Console.Write("Subject cannot be empty, please enter numbers only for Subject 2: ");
            }

            // Subject 3 Validation
            Console.Write("Enter mark for Subject 3: ");
            while (!int.TryParse(Console.ReadLine(), out subject3))
            {
                Console.Write("Subject cannot be empty, please enter numbers only for Subject 3: ");
            }

            // Calculations
            int totalMarks = subject1 + subject2 + subject3;
            double averageMarks = totalMarks / 3.0;
            string result = averageMarks >= 50 ? "PASS" : "FAIL";

            // Classification of Performance
            string grade;
            if (averageMarks >= 75)
                grade = "Distinction";
            else if (averageMarks >= 50)
                grade = "Pass";
            else
                grade = "Not Achieved";

            // Performance Feedback
            string feedback;
            if (averageMarks >= 75)
                feedback = "Excellent performance!";
            else if (averageMarks >= 50)
                feedback = "Good job, keep improving.";
            else
                feedback = "You need to work harder.";

            // Output
            Console.WriteLine();
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Average Marks: " + averageMarks.ToString("0.0"));
            Console.WriteLine("Result: " + result);

            // Feedback and Grade Output
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Feedback: " + feedback);

            Console.WriteLine("Result Issued At: " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));
        }
    }
}