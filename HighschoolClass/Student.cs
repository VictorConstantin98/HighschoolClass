using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class Student : Person, IGrade
    {
        private int yearClass;
        private List<Grade> studentGradeList;

        //Constructor explicit 

        public Student(int yearClass, string name, Gen gen, DateTime dataNasterii) : base(name, gen, dataNasterii)
        {
            this.yearClass = yearClass;
            this.name = name;
            this.gen = gen;
            this.dataNasterii = dataNasterii;
            this.studentGradeList = new List<Grade>();
        }
        //Getter lista materiii
        public List<Grade> getListOfGrades()
        {
            return this.studentGradeList;
        }

        //Implementam metoda din interfata
        public double CalculateGrade()
        {
            double medieGenerala;
            double sumaMedii = 0;
            foreach(Grade grade in studentGradeList)
            {
                sumaMedii = sumaMedii + grade.CalculateGrade();
            }
            int numarMaterii;
            numarMaterii = studentGradeList.Count();
            medieGenerala = sumaMedii / numarMaterii;
            return medieGenerala;
        }

        /*
         * Metoda de adaugare materie
         */

        public void adaugareMaterie(SchoolSubject schoolSubjectToAdd)
        {
            Grade gradeToAdd = new Grade(schoolSubjectToAdd);
            studentGradeList.Add(gradeToAdd);
        }

        /*
         * Metoda de adaugare nota la o materie
         */

        public void adaugareNotaLaOMaterie(int notaDeAdaugat, string materieDeAdaugat)
        {
            bool aux = false;
            foreach(Grade grade in studentGradeList)
            {
                if(materieDeAdaugat == grade.getGradeName())
                {
                    grade.add(notaDeAdaugat);
                    aux = true;
                }
            }
            if(aux!=true)
            {
                throw new SubjectNotFoundException();
            }
        }
        
        /*
         * Metoda care returneaza media la o anumita materie
         */

        public double medieNoteLaOAnumitaMaterie(string materieDeVerificat)
        {
            bool aux = false;
            double media = 0;
            foreach(Grade grade in studentGradeList)
            {
                if(materieDeVerificat == grade.getSchoolSubject().getNume())
                {
                    media = grade.CalculateGrade();
                    aux = true;
                }
            }
            if(aux!=true)
            {
                //De aruncat o exceptie custom
            }
            return media;
        }

        /*
         * Metoda statica care verifica daca media studentului este peste 5 si are cel putin o nota la fiecare materie
         */

        public static bool YearStudentEvaluation(Student student)
        {
            bool aux = true;
            try
            {
                if (student.CalculateGrade() >= 5)
                {
                    foreach (Grade grade in student.studentGradeList)
                    {
                        if (grade.getGradesList().Count() < 0)
                        {
                            aux = false;
                        }
                    }
                    if (aux == true)
                    {
                        student.yearClass++;
                        if (student.yearClass > 12)
                        {
                            Console.WriteLine("Studentul " + student.getName() + " a absolvit scoala.");
                            throw new YearOutOfRangeException();
                        }
                        Console.WriteLine("Studentul " + student.getName() + " a trecut clasa.");
                        return true;
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
           
        
        //ToString
        public override string ToString()
        {
            string afisareString = "";
            afisareString = afisareString
                + "\n" + "Clasa: " + yearClass
                + "\n" + "Nume student : " + name
                + "\n" + "Gen: " + gen
                + "\n" + "Data nasteriii: " + dataNasterii.ToShortDateString()
                + "\n" + "Lista note: "
                + "\n";
            foreach(Grade grade in studentGradeList)
            {
                afisareString = afisareString + grade.ToString();
            }
            return afisareString;
        }
    }
}
