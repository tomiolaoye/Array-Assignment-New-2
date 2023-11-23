using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an array of 10 students
        string[] students = { "Student1", "Student2", "Student3", "Student4", "Student5", "Student6", "Student7", "Student8", "Student9", "Student10" };

        // Create a list of 10 student ages
        List<int> studentAges = new List<int> { 20, 18, 21, 19, 22, 18, 20, 19, 21, 23 };

        // Query if a student whose age is 18 is in the list
        int desiredAge = 18;
        bool isStudentFound = studentAges.Contains(desiredAge);

        if (isStudentFound)
        {
            Console.WriteLine($"A student with age {desiredAge} is in the list.");
        }
        else
        {
            Console.WriteLine($"No student with age {desiredAge} found in the list.");
        }
    }
}
