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
            try
            {
                verificareBool = schoolSubject.validateTeacherSubject();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                verificareBool = false;
            }
            Console.WriteLine(verificareBool);
            Console.WriteLine("\n");



            teacher1.addSubject("Math");
            schoolSubject.setTeacher(teacher1);
            verificareBool = schoolSubject.validateTeacherSubject();
            Console.WriteLine(verificareBool);
            Console.WriteLine("\n");


            Console.WriteLine("Calculam data nasterii pentru profesorul 3");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n");
            Teacher teacher3 = new Teacher("Avram", Gen.Feminin, 20);
            teacher3.addSubject("Math");
            teacher3.addSubject("Sport");
            DateTime dataNasterii = new DateTime(1980, 5, 20);
            teacher3.setDataNasterii(dataNasterii);
            int rezultatAge = teacher3.CalculateAge();
            Console.WriteLine(rezultatAge);
            Console.WriteLine("\n");

            Console.WriteLine("Verificam daca profesorul 3 stie sa predea materia sport");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n");
            bool verificareMaterie;
            verificareMaterie = teacher3.validateSchoolSubject("Sport");
            Console.WriteLine(verificareMaterie);
            Console.WriteLine("\n");
            verificareMaterie = teacher3.validateSchoolSubject("Spor");
            Console.WriteLine(verificareMaterie);
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de verificare gen pentru profesorul 3");
            Console.WriteLine("---------------------------------------------------");
            teacher3.setGen(Person.stringToGen("M"));
            Console.WriteLine(teacher3.ToString());
            Console.WriteLine("\n");

            // Pt Ex 5
            // Aceasta ar trebui sa arunce o eroare in cazul in care Teacherul din constructor este NULL
            
            //SetTeacher cu Shallow Copy.

            SchoolSubject schoolSubject5 = new SchoolSubject();
            schoolSubject5.setTeacher(teacher1);
            Console.WriteLine(schoolSubject5.getTeacher().getName());
            Console.WriteLine("\n");

            teacher1.setName("Costi");
            Console.WriteLine(schoolSubject5.getTeacher().getName());
            Console.WriteLine("\n");

            //SetTeacher cu Deep Copy.

            SchoolSubject schoolSubject6 = new SchoolSubject();
            schoolSubject6.setTeacherDeepCopy(teacher1);
            Console.WriteLine(schoolSubject6.getTeacher().getName());
            Console.WriteLine("\n");

            teacher1.setName("Alex");
            Console.WriteLine(schoolSubject6.getTeacher().getName());
            Console.WriteLine("\n");


            Console.WriteLine("Initializam un obiect de tip SchoolSubject cu Teacher null si prindem exceptia");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            SchoolSubject schoolSubject1 = new SchoolSubject();
            try
            {
                schoolSubject1.setTeacherDeepCopy(schoolSubject1.getTeacher());
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
            Console.WriteLine("\n");

            Console.WriteLine("Construim un obiect de tip Grade si îi adaugam doua note in lista");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("\n");

            Grade grade1 = new Grade(schoolSubject3);
            grade1.add(8);
            grade1.add(10);
            Console.WriteLine(grade1.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de modificare a ultimei note din lista");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");

            grade1.changeLast(9);
            Console.WriteLine(grade1.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de returnare a numarului de note din lista");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine(grade1.count());
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda CalculateGrade pentru schoolSubject3");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\n");

            double rezultat = grade1.CalculateGrade();
            Console.WriteLine(rezultat);
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de adaugare materie in student");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\n");

            schoolSubject1 = new SchoolSubject("Math");
            Student student1 = new Student(8, "Ionut", Gen.Masculin, dataNasterii);
            DateTime dataNasteriiIonut = new DateTime(2000, 6, 14);
            SchoolSubject schoolSubject7 = new SchoolSubject("Physics");
            student1.setDataNasterii(dataNasteriiIonut);
            student1.adaugareMaterie(schoolSubject1);
            student1.adaugareMaterie(schoolSubject7);
            Console.WriteLine(student1.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de adaugare a unei note la o materie");
            Console.WriteLine("--------------------------------------------------");

            student1.adaugareNotaLaOMaterie(8, "Math");
            student1.adaugareNotaLaOMaterie(10, "Math");
            student1.adaugareNotaLaOMaterie(10, "Physics");
            student1.adaugareNotaLaOMaterie(9, "Romana");
            Console.WriteLine(student1.ToString());

            Console.WriteLine("Testam metoda de calculare a mediei pentru o anumita materie.");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n");

            double medie;
            medie = student1.medieNoteLaOAnumitaMaterie("Math");
            Console.WriteLine(medie);
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda de calculare a mediei generale");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\n");

            double medieGenerala;
            medieGenerala = student1.CalculateGrade();
            Console.WriteLine(medieGenerala);
            Console.WriteLine("\n");

            Console.WriteLine("Testam metoda statica YearStudentEvaluation");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 1");
            Student.YearStudentEvaluation(student1);
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 2");
            Student studentAbsolvent = new Student(10, "Alex", Gen.Masculin, dataNasterii);
            studentAbsolvent.adaugareNotaLaOMaterie(2, "Matematica");
            studentAbsolvent.adaugareNotaLaOMaterie(3, "Romana");

            try
            {
                Student.YearStudentEvaluation(studentAbsolvent);
            }
            catch(YearOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }



































        }
    }
}
