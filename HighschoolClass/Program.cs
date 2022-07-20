using System;
namespace HighschoolClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Afisam doi profesori");
            Console.WriteLine("--------------------");
            Console.WriteLine("\n");

            Teacher teacher1 = new Teacher("Popescu", Gen.Masculin, 10);
            Teacher teacher2 = new Teacher("Ionescu", Gen.Feminin, 15);
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(teacher2.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Comparam cei doi profesori in functie de seniority");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine(teacher1.CompareTo(teacher2));
            Console.WriteLine("\n");

            Console.WriteLine("Adaugam subiecte de predat in lista primului profesor");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");

            teacher1.addSubject("Math");
            teacher1.addSubject("Biology");
            teacher1.addSubject("Literature");
            Console.WriteLine(teacher1.ToString());
            
        }
    }
}
