using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class Student : Person, IGrade
    {
        private int classGrade;
        private List<Grade> studentGradeList;

        //Constructor explicit 

        public Student(int classGrade, string name, Gen gen, DateTime dataNasterii) : base(name, gen, dataNasterii)
        {
            this.classGrade = classGrade;
            this.name = name;
            this.gen = gen;
            this.dataNasterii = dataNasterii;
            this.studentGradeList = new List<Grade>();
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
                //De aruncat o exceptie custom
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

        //ToString
        public override string ToString()
        {
            string afisareString = "";
            afisareString = afisareString
                + "\n" + "Media studentului: " + classGrade
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
