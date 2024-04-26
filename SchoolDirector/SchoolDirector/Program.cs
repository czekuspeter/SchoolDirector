using System;

namespace SchoolDirector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDirector vilmos = new SchoolDirector("Vezető Vilmos", new DateTime(2010, 10, 10), 22, 500000);
            SchoolDirector ida = new SchoolDirector("Irányító Ida", new DateTime(2011, 11, 11), 11, 450000);

            Console.WriteLine(vilmos);
            Console.WriteLine(ida);

            if (vilmos.YearsTeaching > ida.YearsTeaching)
            {
                Console.WriteLine("Vezető Vilmos hosszabb időt volt tanár, mint Irányító Ida!");
            }
            else if (vilmos.YearsTeaching < ida.YearsTeaching)
            {
                Console.WriteLine("Irányító Ida hosszabb időt volt tanár, mint Vezető Vilmos!");
            }
            else
            {
                Console.WriteLine("A két vezető ugyan annyi időt volt tanár!");
            }

            SchoolDirectorRepo repo = new SchoolDirectorRepo();
            repo.Add(vilmos);
            repo.Add(ida);

            Console.WriteLine($"Az igazgatók átlagfizetése: {repo.AverageSalary():C}");
            Console.WriteLine($"A legtapasztaltabb igazgató: {repo.GetMostExperiencedDirectorName()}");

            Console.ReadKey();
        }
    }
}