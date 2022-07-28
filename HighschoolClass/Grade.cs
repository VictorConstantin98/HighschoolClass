using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class Grade : IGrade
    {
        private SchoolSubject schoolSubject;
        private List<int> gradesList = new List<int>();

        public Grade(SchoolSubject schoolSubject)
        {
            this.schoolSubject = schoolSubject;
            this.gradesList = new List<int>();
        }

        /*
         * Metoda de adaugare a unei note
         */

        public void add(int gradeToAdd)
        {
            gradesList.Add(gradeToAdd);
        }

        /*
         * Metoda de modificare a ultimei note din lista
         */

        public void changeLast(int gradeToModify)
        {
           // gradesList.RemoveAt(gradesList.Count - 1);
           // gradesList.Add(gradeToModify);
            gradesList[gradesList.Count - 1] = gradeToModify;
        }

        /*
         * Metoda care intoarce numarul total de note
         */

        public int count()
        {
            return gradesList.Count;
        }

        //Implementam metoda din interfata
        public double CalculateGrade()
        {
            double totalGrades;
            totalGrades = gradesList.Average();
            return totalGrades;
        } 

        //ToString
        public override string ToString()
        {
            string gradeString = "";
            gradeString = gradeString + schoolSubject + "Grades: ";
            foreach(int element in gradesList)
            {
                gradeString = gradeString + element.ToString() + " ";
            }
            return gradeString;
        }

    }
}
