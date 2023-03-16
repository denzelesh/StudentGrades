class studentGrades
{
    // Grading Percentages 
    const int gradeA = 70;
    const int gradeB = 60;
    const int gradeC = 50;
    const int gradeD = 40;
    const int gradeF = 0;
    
    static void ApplicationHeading()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   App 03 - Student Grades");
        Console.WriteLine("         By Denzel Eshun");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   This application will convert");
        Console.WriteLine("   student marks to grades");
        Console.WriteLine("   and provide a results summary");
        Console.WriteLine("-----------------------------------");
    }
    
    static void CalculateGrades()
    {
        Console.WriteLine("");
        Console.WriteLine("Enter marks for 10 students:");
        Console.WriteLine("");

        // Variable Declaration & List Creation
        List<string> studentNames = new List<string>();
        List<int> studentMarks = new List<int>();

        // Loop to take all grades from teacher (user)
        for (int entryNumber = 1; entryNumber <= 10; entryNumber++)
        {
            Console.Write("Enter mark for student {0}: ", entryNumber);
            int mark;
            // Parse to check the right data type has been entered
            if (int.TryParse(Console.ReadLine(), out mark))
            {
                studentMarks.Add(mark);
            }
            else
            {
                Console.WriteLine("Incorrect input. Please enter a number.");
                entryNumber--;
            }
        }
    }

     static void Main() // running main loops
    {
         ApplicationHeading();
         CalculateGrades()
    }
}

