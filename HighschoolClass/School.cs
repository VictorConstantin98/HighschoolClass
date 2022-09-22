using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class School
    {
        private List<Student> listaStudentiScoala;
        private List<Teacher> listaProfesoriScoala;
        private List<SchoolSubject> listaMateriiScoala;

        //Constructor
        public School()
        {
            this.listaStudentiScoala = new List<Student>();
            this.listaProfesoriScoala = new List<Teacher>();
            this.listaMateriiScoala = new List<SchoolSubject>();
        }

        //Metoda de adaugat elemente in lista de elevi
        public void addElementsInStudentList(Student student)
        {
            listaStudentiScoala.Add(student);
        }

        //Metoda de adaugat elemente in lista de profesori

        public void addElementsInTeacherList(Teacher teacher)
        {
            listaProfesoriScoala.Add(teacher);
        }

        //Metoda de adaugat elemente in lisita de materii

        public void addElementsInSchoolSubjectList(SchoolSubject schoolSubjectToAdd)
        {
            if(schoolSubjectToAdd.getTeacher() != null)
            {
                listaMateriiScoala.Add(schoolSubjectToAdd);
            }
            else
            {
                Console.WriteLine("Profesorul " + schoolSubjectToAdd.getTeacher().getName() + " este null si nu poate preda materia " + schoolSubjectToAdd.getNume());
            }
        }

        //Metoda de inscris elevi la o materie pe baza numelui materiei

        public void addStudentToSchoolSubject(SchoolSubject schoolsubjetToAttend, Student studentToAdd)
        {
            foreach(SchoolSubject materie in listaMateriiScoala)
            {
                foreach(Student student in listaStudentiScoala.ToList())
                {
                    if (materie.getNume() == schoolsubjetToAttend.getNume())
                    {
                        student.adaugareMaterie(schoolsubjetToAttend);
                        listaStudentiScoala.Add(studentToAdd);
                    }
                    else
                    {
                        Console.WriteLine("Studentul " + student.getName() + " nu s-a inscris la materia " + materie.getNume());
                    }
                }
            }
        }

        //Metoda de adaugat nota unui elev la o materie
        public void addGradesToStudentsSchoolSubjects(string studentsName, string schoolSubjectsGrade, int gradeToAdd)
        {
            foreach(Student student in listaStudentiScoala)
            {
                if(student.getName() == studentsName)
                {
                    student.adaugareNotaLaOMaterie(gradeToAdd, schoolSubjectsGrade);
                }
            }
        }

        //Metoda care intoarce media generala a unui student(parametru numele studentului)
        public double studentsFinalGrade(string studentsName)
        {
            double studentsFinalGrade = 0;
            foreach(Student student in listaStudentiScoala)
            {
                if(student.getName() == studentsName)
                {
                    studentsFinalGrade = student.CalculateGrade();
                }
            }
            return studentsFinalGrade;
        }

        //Metoda care intoarce elevul cu cea mai mare medie

        public double stundetsMaxFinalGrade(string numeElev)
        {
            double maxStundetsGrade = 0;
            foreach(Student student in listaStudentiScoala)
            {
                maxStundetsGrade = listaStudentiScoala.Max(s => s.CalculateGrade());
                if(maxStundetsGrade != 0)
                {
                    Console.WriteLine("Elevul " + student.getName() + " are cea mai mare medie: " + maxStundetsGrade);
                }
            }
            return maxStundetsGrade;
        }

        //Getteri

        public List<Student> getListaStudentiScoala()
        {
            return this.listaStudentiScoala;
        }

        public List<Teacher> getListaProfesoriScoala()
        {
            return this.listaProfesoriScoala;
        }

        public List<SchoolSubject> getListaMateriiScoala()
        {
            return this.listaMateriiScoala;
        }

        //Parcurgere lista studenti scoala
        public void iterateInSchoolStudentsList()
        {
            foreach(Student student in listaStudentiScoala)
            {
                Console.WriteLine(student);
            }
        }

        //To String

        public override string ToString()
        {
            string schoolString = "";
            foreach(Student student in listaStudentiScoala)
            {
                schoolString = schoolString + student.ToString() + "\n";
            }
            foreach(Teacher teacher in listaProfesoriScoala)
            {
                schoolString = schoolString + teacher.ToString() + "\n";
            }
            foreach(SchoolSubject schoolSubject in listaMateriiScoala)
            {
                schoolString = schoolString + schoolSubject.ToString() + "\n";
            }
            return schoolString;
        }


    }
}
