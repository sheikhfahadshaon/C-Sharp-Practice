public class LINQPractice
{
    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public void GetEvenNumbers()
    {
        var evenNumbers =
                        from num in numbers
                        where num % 2 == 0
                        select num;


        Console.WriteLine(evenNumbers.GetType());

        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    public void MethodSyntaxWithAnonymousClass()
    {
        var students = new[]{
                new {Name = "Shaon", Dept = "CSE", Cgpa = 3.4 },
                new {Name = "Shakil", Dept = "English", Cgpa = 3.50 } ,
                new {Name = "Hasnat", Dept = "Merchandizing", Cgpa = 3.70 }
            };

        var cgLowerThan3_5 = students
                                 .Where(s => s.Cgpa <= 3.50)
                                 .Select(s => 10.0 * s.Cgpa / 4.0)
                                 .OrderByDescending(cg => cg);

        var studentsHavingLowerCg = students
                                    .Where(s => s.Cgpa <= 3.50)
                                    .OrderByDescending(s => s.Cgpa);


        //cg in descending order
        foreach (var cg in cgLowerThan3_5)
        {
            Console.Write(cg + " ");
        }
        Console.WriteLine();


        //name of the students having lower cg
        foreach (var student in studentsHavingLowerCg)
        {
            Console.Write(student.Name + " ");
        }
        Console.WriteLine();
    }
}