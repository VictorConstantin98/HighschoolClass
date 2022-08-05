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
            throw new NotImplementedException();
        }

        /*
         * Metoda de adaugare materie
         */
         
        public void adaugareMaterie(SchoolSubject schoolSubjectToAdd)
        {
            Grade gradeToAdd = new Grade(schoolSubjectToAdd);
            studentGradeList.Add(gradeToAdd);
        }


        //ToString
        public override string ToString()
        {
            string afisareString = "";
            afisareString = afisareString
                + "\n" + "Nota materie: " + classGrade
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
