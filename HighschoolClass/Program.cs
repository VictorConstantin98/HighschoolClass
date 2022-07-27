using System;
namespace HighschoolClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Afisam doi profesori");
            Console.WriteLine("--------------------");

            Teacher teacher1 = new Teacher("Popescu", Gen.Masculin, 10);
            Teacher teacher2 = new Teacher("Ionescu", Gen.Feminin, 15);
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine(teacher2.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Comparam cei doi profesori in functie de seniority");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine(teacher1.CompareTo(teacher2));
            Console.WriteLine("\n");

            Console.WriteLine("Adaugam subiecte de predat in lista primului profesor");
            Console.WriteLine("-----------------------------------------------------");

            teacher1.addSubject("Math");
            teacher1.addSubject("Biology");
            teacher1.addSubject("Literature");
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Stergem Math din lista");
            Console.WriteLine("----------------------");

            teacher1.deleteSubject("Math");
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Verificam vechimea celui de-al doilea profesor");
            Console.WriteLine("----------------------------------------------");
            teacher2.addSubject("Geography");
            teacher2.addSubject("Music");
            teacher2.addSubject("Art");
            teacher2.settingSeniority(-1);
            Console.WriteLine(teacher2.ToString());

            try
            {
                teacher1.settingSeniority(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Verificam daca profesorul 1 stie sa predea materia Math");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\n");
            SchoolSubject schoolSubject = new SchoolSubject("Math");
            bool verificareBool;
            verificareBool = schoolSubject.validateTeacherSubject("Math");
            Console.WriteLine(verificareBool);
            Console.WriteLine("\n");

            Console.WriteLine("Calculam data nasterii pentru profesorul 3");
            Console.WriteLine("-----------------------------------------");
            Teacher teacher3 = new Teacher("Avram", Gen.Feminin, 20);
            teacher3.addSubject("Math");
            teacher3.addSubject("Sport");
            DateTime dataNasterii = DateTime.Now;
            teacher3.CalculateAge(dataNasterii);
            teacher3.setDataNasterii(dataNasterii);
            Console.WriteLine(teacher3.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Verificam daca profesorul 3 stie sa predea materia sport");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n");
            bool verificareMaterie;
            verificareMaterie = teacher3.validateSchoolSubject("Sport");
            Console.WriteLine(verificareMaterie);
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de verificare gen pentru profesorul 3");
            Console.WriteLine("---------------------------------------------------");
            teacher3.setGen(Person.stringToGen("M"));
            Console.WriteLine(teacher3.ToString());
            Console.WriteLine("\n");

            // Pt Ex 5
            // Aceasta ar trebui sa arunce o eroare in cazul in care Teacherul din constructor este NULL
            Console.WriteLine("Initializam un obiect de tip SchoolSubject cu Teacher null si prindem exceptia");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("\n");
            SchoolSubject schoolSubject1 = new SchoolSubject();
            schoolSubject1.setTeacher(schoolSubject1.getTeacher());
            Console.WriteLine(schoolSubject1.ToString());
            try
            {
                schoolSubject1.setTeacher(schoolSubject1.getTeacher());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Deep copy schoolSubject2 in schoolSubject3 prin copy constructor");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("\n");
            SchoolSubject schoolSubject2 = new SchoolSubject("Math");
            SchoolSubject schoolSubject3 = new SchoolSubject(schoolSubject2);
            schoolSubject3.setTeacher(schoolSubject3.getTeacher());
            Console.WriteLine(schoolSubject3.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Implementam si testam copy constructor pentru clasa Teacher");
            Console.WriteLine("-----------------------------------------------------------");
            Teacher teacher4 = new Teacher(teacher1);
            Console.WriteLine(teacher4.ToString());


            






            





















        }
    }
}
