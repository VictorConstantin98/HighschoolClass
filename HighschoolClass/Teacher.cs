using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class Teacher : Person, IComparable
    {
        private int seniority;
        private List<string> possibleSchoolSubjectsToTeach;

        //Accesori
        public string getName()
        {
            return this.name;
        }

        private Gen getGen()
        {
            return this.gen;
        }

        //Constructor implicit
        public Teacher()
        {

        }

        //Constructor explicit
        public Teacher(string name, Gen gen, int seniority)
        {
            this.name = name;
            this.gen = gen;
            this.seniority = seniority;
            this.possibleSchoolSubjectsToTeach = new List<string>();
        }

        /*
         * Metoda de adaugat subiecte de predat in lista
         */

        public void addSubject(string subjectToAdd)
        {
            possibleSchoolSubjectsToTeach.Add(subjectToAdd);
        }

        /*
         * Metoda de sters subiecte din lista
         */

        public void deleteSubject(string subjectToDelete)
        {
            possibleSchoolSubjectsToTeach.Remove(subjectToDelete);
        }

        /*
         * Metoda de setare a senioritatii
         */

        public void settingSeniority(int seniority)
        {
            if(this.seniority >= 1)
            {
                this.seniority = seniority;
            }
            else
            {
                if(this.seniority <= 0)
                {
                    throw new Exception("Vechimea profesorului nu corespunde.");
                }
            }
        }

        //ToString

        public override string ToString()
        {
            string teacherString = "";
            teacherString = teacherString + "Name: " + name + "\n" + "Gen: " + gen + "\n" + "Seniority: " + seniority + "\n" + "School subject: ";
            foreach(string element in possibleSchoolSubjectsToTeach)
            {
                teacherString = teacherString + element.ToString() + " ";
            }
            return teacherString;
        }
        //Implement CompareTo
        public int CompareTo(object? obj)
        {
            if (this.seniority > ((Teacher)obj).seniority)
                return 1;
            if (this.seniority < ((Teacher)obj).seniority)
                return -1;
            if (this.seniority == ((Teacher)obj).seniority)
                return 0;
            return 0;
        }
    }
}
