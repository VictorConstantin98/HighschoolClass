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
                Console.WriteLine(ex.Message);
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
            Console.WriteLine("---------------------------------------------------------------");
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
            Console.WriteLine("----------------------");
            Teacher p1 = new Teacher("Ionescu", Gen.Feminin, 7);
            Teacher p2 = new Teacher("Popescu", Gen.Masculin, 8);
            Teacher p3 = new Teacher(p2);
            Teacher p4 = new Teacher();
            Teacher p5 = new Teacher();

            Console.WriteLine("2) Adaugam cate doua materii fiecarui profesor");
            Console.WriteLine("----------------------------------------------");
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
            Console.WriteLine("-----------------------------------");
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
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine(p2.CompareTo(p5)); //Sa imi afiseze la ecran profesorul mai senior
                                                 //si care va preda

            if(p2.CompareTo(p5) > 0)
            {
                Console.WriteLine(p2.ToString() + "\n\n" + "Profesorul 2 este mai senior");
            }
            else
            {
                if(p2.CompareTo(p5) == 0)
                {
                    Console.WriteLine("Profesorul 2 are aceeasi senioritate ca profesorul 5");
                }
                else
                {
                    if(p2.CompareTo(p5) < 0)
                    {
                        Console.WriteLine(p5.ToString() + "\n\n" + "Profesorul 5 este mai senior");
                    }
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("5) Adaugam cei 5 profesori intr-o lista");
            Console.WriteLine("---------------------------------------");
            List<Teacher> listaProfesori = new List<Teacher>();
            listaProfesori.Add(p1);
            listaProfesori.Add(p2);
            listaProfesori.Add(p3);
            listaProfesori.Add(p4);
            listaProfesori.Add(p5);
            Console.WriteLine("\n");

            Console.WriteLine("6) Definim materii");
            Console.WriteLine("------------------");
            Console.WriteLine("\n");

            SchoolSubject s1 = new SchoolSubject("Math");
            SchoolSubject s2 = new SchoolSubject("Physics");
            SchoolSubject s3 = new SchoolSubject("Biology");
            SchoolSubject s4 = new SchoolSubject("Chemistry");
            SchoolSubject s5 = new SchoolSubject("Music");
            SchoolSubject s6 = new SchoolSubject("French");
            SchoolSubject s7 = new SchoolSubject("German");

            Console.WriteLine("7) Alocam materiilor cate un profesor si validam daca acestia stiu sa le predea");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("\n");

            //De facut cu lista de profesorii (nu stim cati profesori cate materii)


            p4.setName("Georgescu");
            p5.setName("Alexandrescu");

            s1.setTeacherDeepCopy(p1);
            s2.setTeacherDeepCopy(p2);
            s3.setTeacherDeepCopy(p3);
            s4.setTeacherDeepCopy(p4);
            s5.setTeacherDeepCopy(p5);
            s6.setTeacherDeepCopy(p3);
            s7.setTeacherDeepCopy(p4);

            //listaProfesori.ForEach(a => Console.WriteLine(a.ToString()));

            foreach (Teacher profesor in listaProfesori)
            {
                if(profesor.validateSchoolSubject(s1.getNume()))
                {
                    s1.setTeacher(profesor);
                }
                if(profesor.validateSchoolSubject(s2.getNume()))
                {
                    s2.setTeacher(profesor);
                }
            }
            List<SchoolSubject> listaMaterii = new List<SchoolSubject>();
            listaMaterii.Add(s1);
            listaMaterii.Add(s2);
            listaMaterii.Add(s3);
            listaMaterii.Add(s4);
            listaMaterii.Add(s5);
            listaMaterii.Add(s6);
            listaMaterii.Add(s7);

            foreach(SchoolSubject materie in listaMaterii)
            {
                foreach(Teacher profesor in listaProfesori)
                {
                    if(profesor.validateSchoolSubject(materie.getNume()))
                    {
                        materie.setTeacher(profesor);
                        Console.WriteLine("Profesorul " + profesor.getName() + " stie sa predea materia " + materie.getNume() + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Profesorul " + profesor.getName() + " nu stie sa predea materia " + materie.getNume() + "\n");
                    }
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("8) Modificam materia Math cu un alt profesor din lista care stie sa predea Math");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            //De cautat un alt profesor decat cel care a plecat in concendiu
            Teacher teacherConcediu = s1.getTeacher();
            teacherConcediu.setName("Popescu");
            foreach(Teacher profesor in listaProfesori)
            {
                if(profesor.validateSchoolSubject(s1.getNume()))
                {
                    if(!profesor.Equals(teacherConcediu))
                    {
                        s1.setTeacher(profesor);
                        Console.WriteLine("Profesorul " + teacherConcediu.getName() + " a plecat in concediu, iar materia " + s1.getNume() + " o preda acum profesorul " + profesor.getName());
                    }
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("9) Sortam profesorii din lista dupa senioritate");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n");
            listaProfesori.Sort();
            foreach (Teacher element in listaProfesori)
            {
                Console.WriteLine(element.getSeniority());
            }
            Console.WriteLine("\n");

            Console.WriteLine("10) Definim SchoolSubject Romanian si cautam un profesor care poate sa o predea");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            SchoolSubject s8 = new SchoolSubject("Romanian");
            listaMaterii.Add(s8);
            //De cautat daca un profesor din lista stie Romana
            Teacher p6 = new Teacher("Mihaescu", Gen.Feminin, 5);
            Console.WriteLine("\n");

            bool auxVerificare = false;
            foreach (Teacher profesor in listaProfesori)
            {
                if(profesor.validateSchoolSubject(s8.getNume()))
                {
                    s8.setTeacher(profesor);
                    auxVerificare = true;
                    Console.WriteLine("Niciun profesor din lista nu stie sa predea materia " + s8.getNume());
                    break;
                }
            }
            
            if(auxVerificare == false)
            {
                s8.setTeacher(p6);
                listaProfesori.Add(p6);
                Console.WriteLine("Profesorul " + p6.getName() + " a fost angajat sa predea materia " + s8.getNume() + "\n");
            }
            Console.WriteLine("\n");

            Console.WriteLine("11) Definim materia English si ii alocam profesorul cu cea mai mare senioritate");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("\n");

            //De refacut. De cautat profesorul care are cea mai mare senioritate si stie sa predea engleza din lista. -- TO DO
              //In conditiile in care nu stiu ca p3 si p4 stiu sa predea Engleza
            SchoolSubject s9 = new SchoolSubject("English");
            listaMaterii.Add(s9);

            var maxSeniority = listaProfesori.Max(p => p.getSeniority());
            foreach(Teacher profesor in listaProfesori)
            {
                if(profesor.getSeniority() == maxSeniority)
                {
                    if(profesor.validateSchoolSubject(s9.getNume()))
                    {
                        s9.setTeacher(profesor);
                        Console.WriteLine("Profesorul " + profesor.getName() + " cu senioritatea " + profesor.getSeniority() + " preda materia " + s9.getNume());
                    }
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("12) Adaugam toate materiile intr-o lista");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n");
            listaMaterii = new List<SchoolSubject>();
            listaMaterii.Add(s1);
            listaMaterii.Add(s2);
            listaMaterii.Add(s3);
            listaMaterii.Add(s4);
            listaMaterii.Add(s5);
            listaMaterii.Add(s6);
            listaMaterii.Add(s7);
            listaMaterii.Add(s8);
            listaMaterii.Add(s9);
            Console.WriteLine(listaMaterii.Count());
            Console.WriteLine("\n");
            

            Console.WriteLine("13) Cream 5 studenti");
            Console.WriteLine("--------------------");
            Console.WriteLine("\n");

            DateTime dataNastereElev1 = new DateTime(1995, 10, 23);
            Student e1 = new Student(10, "Alex", Gen.Masculin, dataNastereElev1);
            Console.WriteLine(e1.ToString());
            Console.WriteLine("\n");

            DateTime dataNastereElev2 = new DateTime(1996, 11, 18);
            Student e2 = new Student(10, "Costi", Gen.Masculin, dataNastereElev2);
            Console.WriteLine(e2.ToString());
            Console.WriteLine("\n");

            DateTime dataNastereElev3 = new DateTime(1995, 5, 22);
            Student e3 = new Student(10, "Ioana", Gen.Feminin, dataNastereElev3);
            Console.WriteLine(e3.ToString());
            Console.WriteLine("\n");

            DateTime dataNastereElev4 = new DateTime(1996, 1, 30);
            Student e4 = new Student(10, "Maria", Gen.Feminin, dataNastereElev4);
            Console.WriteLine(e4.ToString());
            Console.WriteLine("\n");

            DateTime dataNastereElev5 = new DateTime(1996, 7, 14);
            Student e5 = new Student(10, "Robert", Gen.Masculin, dataNastereElev5);
            Console.WriteLine(e5.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("14) Inscriem studentiii la materii");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n");

            List<Student> listaStudenti = new List<Student>();
            listaStudenti.Add(e1);
            listaStudenti.Add(e2);
            listaStudenti.Add(e3);
            listaStudenti.Add(e4);
            listaStudenti.Add(e5);

            foreach(Student student in listaStudenti)
            {
                student.adaugareMaterie(s1);
                student.adaugareMaterie(s2);
                student.adaugareMaterie(s3);
                Console.WriteLine(student.getName() + " > " + s1.getNume() + " " + s2.getNume() + " " + s3.getNume());
            }
            Console.WriteLine("\n");


            Console.WriteLine("15) Adaugam materii optionale studentilor");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n");

            //Materii optionale elev4: Muzica si Engleza
            e4.adaugareMaterie(s5);
            e4.adaugareMaterie(s9);

            //Materiii optionale elev5: Engleza si Franceza
            e5.adaugareMaterie(s9);
            e5.adaugareMaterie(s6);

            //Materie optionala elev2 si elev3: Chimie
            e2.adaugareMaterie(s4);
            e2.adaugareMaterie(s4);

            Console.WriteLine("16) Adaugam studentii intr-o lista");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n");
            /*List<Student> listaStudenti = new List<Student>();
            listaStudenti.Add(e1);
            listaStudenti.Add(e2);
            listaStudenti.Add(e3);
            listaStudenti.Add(e4);
            listaStudenti.Add(e5);
            Console.WriteLine(listaStudenti.Count());*/
            Console.WriteLine("\n");

            Console.WriteLine("17) Adaugam cate o nota la matematica fiecarui student");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\n");
            //De adaugat cu ajutorul listei
            foreach(Student elev in listaStudenti)
            {
                elev.adaugareNotaLaOMaterie(8, "Math");
            }
            Console.WriteLine("\n");

            Console.WriteLine("18) Adaugam cate doua note la Fizica");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n");

             //Adaugam 8 si 5 la Fizica fiecarui student din lista

            /*foreach(Student elev in listaStudenti)
            {
                elev.adaugareNotaLaOMaterie(8, "Physics");
                elev.adaugareNotaLaOMaterie(5, "Physics");
            }*/

            e1.adaugareNotaLaOMaterie(7, "Physics");
            e1.adaugareNotaLaOMaterie(8, "Physics");

            e2.adaugareNotaLaOMaterie(3, "Physics");
            e2.adaugareNotaLaOMaterie(10, "Physics");

            e3.adaugareNotaLaOMaterie(6, "Physics");
            e3.adaugareNotaLaOMaterie(7, "Physics");

            e4.adaugareNotaLaOMaterie(8, "Physics");
            e4.adaugareNotaLaOMaterie(3, "Physics");

            e5.adaugareNotaLaOMaterie(10, "Physics");
            e5.adaugareNotaLaOMaterie(6, "Physics");
            Console.WriteLine("\n");

            Console.WriteLine("19) Incercam sa adaugam cate o nota la Muzica fiecarui student");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\n");

            foreach(Student student in listaStudenti)
            {
                try
                {
                    student.adaugareNotaLaOMaterie(8, s5.getNume());
                    Console.WriteLine("Elevul " + student.getName() + " a fost inscris la materia " + s5.getNume() + " si are nota 8.");
                }
                catch(SubjectNotFoundException ex)
                {
                    Console.WriteLine("Elevul " + student.getName() + " nu a fost inscris la materia " + s5.getNume() + ": " + ex.Message);
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("20) Adaugam 3 note fiecarui student la Biologie");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n");
            
            foreach(Student student in listaStudenti)
            {
                student.adaugareNotaLaOMaterie(5, s3.getNume());
                student.adaugareNotaLaOMaterie(8, s3.getNume());
                student.adaugareNotaLaOMaterie(10, s3.getNume());
                Console.WriteLine("Studentul " + student.getName() + " are notele 5, 8 si 10 la materia " + s3.getNume());
            }
            Console.WriteLine("\n");

            Console.WriteLine("21) Adaugam nota 11 studentului5 la Engleza");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n");

            try
            {
                e5.adaugareNotaLaOMaterie(11, "English");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");

            Console.WriteLine("22) Afisam media fiecarei materii pentru studentul5");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n");

            double medieMaterii;

            foreach(SchoolSubject materie in listaMaterii)
            {
                try
                {
                    medieMaterii = e5.medieNoteLaOAnumitaMaterie(materie.getNume());
                    Console.WriteLine("Studentul " + e5.getName() + " are urmatoarea medie la materia " + materie.getNume() + ": " + medieMaterii + "\n");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }

            Console.WriteLine("23) Adaugam cate 2 note elevilor 2 si 3 la materia Chemistry");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\n");

            /*//Pentru elevul2
            e2.adaugareNotaLaOMaterie(3, "Chemistry");
            e2.adaugareNotaLaOMaterie(6, "Chemistry");

            //Pentru elevul3
            e3.adaugareNotaLaOMaterie(10, "Chemistry");
            e3.adaugareNotaLaOMaterie(9, "Chemistry");
            Console.WriteLine("\n");*/

            Console.WriteLine("24) Afisam media generala a fiecarui student");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\n");

            //Media generala a studentului1
            double medieGeneralaE1;
            medieGeneralaE1 = e1.CalculateGrade();
            Console.WriteLine("Media generala a elevului1: " + medieGeneralaE1);

































        }
    }
}
