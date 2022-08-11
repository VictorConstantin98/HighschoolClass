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

        /// suprascrincarcare operator
        /// definerea operatior pentru clasa respectiva
        /// 

        /*ublic int this[int key]
        { 
            get +> GetVa
            
        }*/
        /*Operatori:
        ++
        +
        +=
        ==*/


        //Accesori
        public SchoolSubject getSchoolSubject()
        {
            return this.schoolSubject;
        }

        public List<int> getGradesList()
        {
            return this.gradesList;
        }

        /*
         * Metoda ce returneaza numele lui grade
         */

        public string getGradeName()
        {
            return schoolSubject.getNume();
        }

        /*
         * Metoda de adaugare a unei note
         */

        public void add(int gradeToAdd)
        {
            if(gradeToAdd >=1 && gradeToAdd <=10)
            {
                gradesList.Add(gradeToAdd);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Notele trebuie sa fie intre 1 si 10");
            }
        }

        /*
         * Metoda de modificare a ultimei note din lista
         */

        public void changeLast(int gradeToModify)
        {
           // gradesList.RemoveAt(gradesList.Count - 1);
           // gradesList.Add(gradeToModify);
           if(gradeToModify >=1 && gradeToModify <=10)
            {
                gradesList[gradesList.Count - 1] = gradeToModify;
            }
           else
            {
                throw new ArgumentOutOfRangeException("Notele trebuie sa fie intre 1 si 10");
            }
            
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
            gradeString = gradeString + "\n";
            return gradeString;
        }

        
    }
}
