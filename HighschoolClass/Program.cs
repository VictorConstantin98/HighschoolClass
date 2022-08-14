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
            try
            {
                teacher2.settingSeniority(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
            try
            {
                student1.adaugareNotaLaOMaterie(9, "Romana");
            }
            catch(SubjectNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
            Student studentAbsolvent = new Student(13, "Alex", Gen.Masculin, dataNasterii);
            studentAbsolvent.adaugareMaterie(schoolSubject7);
            studentAbsolvent.adaugareMaterie(schoolSubject2);
            studentAbsolvent.adaugareNotaLaOMaterie(5, "Physics");
            studentAbsolvent.adaugareNotaLaOMaterie(5, "Math");

            try
            {
                Student.YearStudentEvaluation(studentAbsolvent);
            }
            catch(YearOutOfRangeException ex)
            {
                
            }
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 3");
            Student studentCaz3 = new Student(12, "George", Gen.Masculin, dataNasterii);
            studentCaz3.adaugareMaterie(schoolSubject3);
            studentCaz3.adaugareMaterie(schoolSubject1);
            bool rezultatCaz3 = Student.YearStudentEvaluation(studentCaz3);
            Console.WriteLine(rezultatCaz3);
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 4");
            Student studentCaz4 = new Student(12, "Maria", Gen.Feminin, dataNasterii);
            studentCaz4.adaugareMaterie(schoolSubject2);
            studentCaz4.adaugareMaterie(schoolSubject7);
            studentCaz4.adaugareNotaLaOMaterie(2, "Math");
            studentCaz4.adaugareNotaLaOMaterie(3, "Physics");
            bool rezultatCaz4 = Student.YearStudentEvaluation(studentCaz4);
            Console.WriteLine(rezultatCaz4);
            Console.WriteLine("\n");

            Console.WriteLine("Verificam daca notele sunt cuprinse intre 1 si 10 cu metoda add");
            Console.WriteLine("\n");
            Console.WriteLine("Cazul 1: Intre 1 si 10");
            grade1.add(5);
            Console.WriteLine(grade1);
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 2: Mai mare ca 10");
            Console.WriteLine("\n");
            try
            {
                grade1.add(11);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Cazul3: Mai mic decat 1");
            Console.WriteLine("\n");
            try
            {
                grade1.add(0);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Verificam daca notele sunt cuprinse intre 1 si 10 cu metoda changeLast");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 1: Intre 1 si 10");
            Console.WriteLine("\n");
            grade1.changeLast(7);
            Console.WriteLine(grade1);

            Console.WriteLine("Cazul 2: Mai mare ca 10");
            Console.WriteLine("\n");
            try
            {
                grade1.changeLast(11);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Cazul 3: Mai mic ca 1");
            Console.WriteLine("\n");
            try
            {
                grade1.changeLast(0);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");


            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("1) Definim 5 profesori");
            Teacher p1 = new Teacher("Ionescu", Gen.Feminin, 7);
            Teacher p2 = new Teacher("Popescu", Gen.Masculin, 8);
            Teacher p3 = new Teacher(p2);
            Teacher p4 = new Teacher();
            Teacher p5 = new Teacher();

            Console.WriteLine("2) Adaugam cate doua materii fiecarui profesor");
            p1.addSubject("Math");
            p1.addSubject("Physics");

            p2.addSubject("Math");
            p2.addSubject("Biology");

            p3.addSubject("Music");
            p3.addSubject("English");

            p4.addSubject("English");
            p4.addSubject("French");

            p5.addSubject("Chemistry");
            p5.addSubject("Biology");

            Console.WriteLine("3) Setam senioritatile profesorilor");
            p1.settingSeniority(8);
            p2.settingSeniority(10);
            p3.settingSeniority(5);
            p4.settingSeniority(6);
            p5.settingSeniority(7);
            Console.WriteLine("\n");

            Console.WriteLine("Afisam cei 5 profesori");
            Console.WriteLine("----------------------");
            Console.WriteLine("\n");
            Console.WriteLine(p1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(p2.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(p3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(p4.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(p5.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("4) Comparam care dintre P2 si P5 este mai senior");
            Console.WriteLine("\n");
            Console.WriteLine(p2.CompareTo(p5));
            Console.WriteLine("\n");

            Console.WriteLine("5) Adaugam cei 5 profesori intr-o lista");
            List<Teacher> listaProfesori = new List<Teacher>();
            listaProfesori.Add(p1);
            listaProfesori.Add(p2);
            listaProfesori.Add(p3);
            listaProfesori.Add(p4);
            listaProfesori.Add(p5);
            Console.WriteLine("\n");

            Console.WriteLine("6) Definim materii");
            Console.WriteLine("\n");

            SchoolSubject s1 = new SchoolSubject("Math");
            SchoolSubject s2 = new SchoolSubject("Physics");
            SchoolSubject s3 = new SchoolSubject("Biology");
            SchoolSubject s4 = new SchoolSubject("Chemistry");
            SchoolSubject s5 = new SchoolSubject("Music");
            SchoolSubject s6 = new SchoolSubject("French");
            SchoolSubject s7 = new SchoolSubject("German");

            Console.WriteLine("7) Alocam materiilor cate un profesor si validam daca acestia stiu sa le predea");
            Console.WriteLine("\n");

            s1.setTeacherDeepCopy(p1);
            bool verificare1 = s1.validateTeacherSubject();
            Console.WriteLine("Math cu profesorul1" + " > " + verificare1);

            s2.setTeacherDeepCopy(p2);
            bool verificare2;
            try
            {
                verificare2 = s2.validateTeacherSubject();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Physics cu profesorul2" + " > " + ex.Message);
            }

            s3.setTeacherDeepCopy(p2);
            bool verificare3 = s3.validateTeacherSubject();
            Console.WriteLine("Biology cu profesorul3" + " > " + verificare3);

            s4.setTeacherDeepCopy(p3);
            bool verificare4;
            try
            {
                verificare4 = s4.validateTeacherSubject();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Chemistry cu profesorul3" + " > " + ex.Message);
            }

            s5.setTeacherDeepCopy(p4);
            bool verificare5;
            try
            {
                verificare5 = s5.validateTeacherSubject();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Music cu profesorul4" + " > " + ex.Message);
            }

            s6.setTeacherDeepCopy(p4);
            bool verificare6 = s6.validateTeacherSubject();
            Console.WriteLine("French cu profesorul4" + " > " + verificare6);


            s7.setTeacherDeepCopy(p5);
            bool verificare7;
            try
            {
                verificare7 = s7.validateTeacherSubject();
            }
            catch (Exception ex)
            {
                Console.WriteLine("German cu profesorul5" + " > " + ex.Message);
            }
            Console.WriteLine("\n");

            Console.WriteLine("8) Modificam materia Math cu un alt profesor din lista care stie sa predea Math");
            Console.WriteLine("\n");
            s1.setTeacherDeepCopy(p2);
            bool verificare8 = s1.validateTeacherSubject();
            Console.WriteLine("Profesorul2 cu materia Math" + " > " + verificare8);
            Console.WriteLine("\n");

            Console.WriteLine("9) Sortam profesorii din lista dupa senioritate");
            Console.WriteLine("\n");
            listaProfesori.Sort();
            foreach (Teacher element in listaProfesori)
            {
                Console.WriteLine(element.getSeniority());
            }
            Console.WriteLine("\n");

            Console.WriteLine("10) Definim SchoolSubject Romanian si cautam un profesor care poate sa o predea");
            Console.WriteLine("\n");
            SchoolSubject s8 = new SchoolSubject("Romanian");
            Teacher p6 = new Teacher("Mihaescu", Gen.Feminin, 5);
            Console.WriteLine("Profesorul " + p6.getName() + " a fost angajat sa predea " + s8.getNume());
            Console.WriteLine("\n");

            foreach (Teacher element in listaProfesori)
            {
                if(listaProfesori.Contains(p6))
                {
                    throw new Exception("Nu s-a gasit niciun profesor care sa predea materia Romana. Anagajati unul!");
                }
                else
                {
                    s8.setTeacherDeepCopy(p6);
                }
            }
            listaProfesori.Add(p6);
            Console.WriteLine(s8.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("11) Definim materia English si ii alocam profesorul cu cea mai mare senioritate");
            Console.WriteLine("\n");
            SchoolSubject s9 = new SchoolSubject("English");
            if(p3.getSeniority() > p4.getSeniority())
            {
                throw new Exception("Profesorul 3 are senioritatea mai mica decat profesorul 4 si nu stie sa predea Engleza");
            }
            else
            {
                s9.setTeacherDeepCopy(p4);
            }
            Console.WriteLine(s9.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("12) Adaugam toate materiile intr-o lista");
            List<SchoolSubject> listaMaterii = new List<SchoolSubject>();
            listaMaterii.Add(s1);
            listaMaterii.Add(s2);
            listaMaterii.Add(s3);
            listaMaterii.Add(s4);
            listaMaterii.Add(s5);
            listaMaterii.Add(s6);
            listaMaterii.Add(s7);
            listaMaterii.Add(s8);
            listaMaterii.Add(s9);
            Console.WriteLine("\n");






































        }
    }
}
