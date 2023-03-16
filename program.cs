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
    Console.WriteLine("");
        Console.WriteLine("Student Grades:");
        Console.WriteLine("");

        // Loop runs to create a tally of all the grade achieved
        int numOfGradeA = 0, numOfGradeB = 0, numOfGradeC = 0, numOfGradeD = 0, numOfGradeF = 0;
        for (int i = 0; i < studentMarks.Count; i++)
        {
            string grade;
            int mark = studentMarks[i];
            string studentName = string.Format("Student {0}", i + 1);
            studentNames.Add(studentName);

            if (mark >= gradeA)
            {
                grade = "A";
                numOfGradeA++;
            }
            else if (mark >= gradeB)
            {
                grade = "B";
                numOfGradeB++;
            }
            else if (mark >= gradeC)
            {
                grade = "C";
                numOfGradeC++;
            }
            else if (mark >= gradeD)
            {
                grade = "D";
                numOfGradeD++;
            }
            else
            {
                grade = "F";
                numOfGradeF++;
            }
            // Multiple placeholders used for each argument passed
            Console.WriteLine("{0}: {1} ({2})", studentName, mark, grade);
        }

        Console.WriteLine("");
        Console.WriteLine("Results Summary:");
        Console.WriteLine("");

        // Representing grades awarded as percentages
        Console.WriteLine("A: {0}%", (double)numOfGradeA / studentMarks.Count * 100);
        Console.WriteLine("B: {0}%", (double)numOfGradeB / studentMarks.Count * 100);
        Console.WriteLine("C: {0}%", (double)numOfGradeC / studentMarks.Count * 100);
        Console.WriteLine("D: {0}%", (double)numOfGradeD / studentMarks.Count * 100);
        Console.WriteLine("F: {0}%", (double)numOfGradeF / studentMarks.Count * 100);

        int minimumMark = studentMarks[0];
        int maximumMark = studentMarks[0];
        int totalMarks = studentMarks[0];

        // Calcualtiong the values for mean and maximum mark
        for (int finalStudentMarks = 1; finalStudentMarks < studentMarks.Count; finalStudentMarks++)
        {
            int mark = studentMarks[finalStudentMarks];
            totalMarks += mark;

            if (mark > maximumMark)
            {
                maximumMark = mark;
            }
            
            if (mark < minimumMark)
            {
                minimumMark = mark;
            }
        }

        double meanMark = (double)totalMarks / studentMarks.Count;

        // Displaying grade data
        Console.WriteLine("");
        Console.WriteLine("Minimum Mark Is: {0}", minimumMark);
        Console.WriteLine("Maximum Mark Is: {0}", maximumMark);
        // 'F2' Used to make output a flaoting point number 2 decimal places, for accuracy.
        Console.WriteLine("Mean Mark Is: {0:F2}", meanMark); // 
        Console.WriteLine("");

    }

     static void Main() // running main loops
    {
         ApplicationHeading();
         CalculateGrades()
    }
}

