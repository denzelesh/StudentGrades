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

     static void Main()
    {
         ApplicationHeading();
    }
}

