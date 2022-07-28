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
        private List<string> possibleSchoolSubjectsToTeach = new List<string>();

        //Accesori
        public string getName()
        {
            return this.name;
        }

        private Gen getGen()
        {
            return this.gen;
        }

        public List<string> getLista()
        {
            return this.possibleSchoolSubjectsToTeach;
        }

        public void setLista(List<string> possibleSchoolSubjectsToTeach)
        {
            this.possibleSchoolSubjectsToTeach = possibleSchoolSubjectsToTeach;
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
            this.dataNasterii = dataNasterii;
        }

       //Copy constructor
       public Teacher(Teacher teacherCopyConstructor)
        {
            this.name = teacherCopyConstructor.name;
            this.gen = teacherCopyConstructor.gen;
            this.seniority = teacherCopyConstructor.seniority;
            this.possibleSchoolSubjectsToTeach = teacherCopyConstructor.possibleSchoolSubjectsToTeach;
            this.dataNasterii = teacherCopyConstructor.dataNasterii;
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
            if(seniority >= 1)
            {
                this.seniority = seniority;
            }
            else
            {
                if(seniority <= 0)
                {
                    //throw new Exception("Vechimea profesorului nu corespunde.");
                }
            }
        }

        /*
         * Metoda de parcurgere a listei
         */

        public void verificareElementeLista(string elementDeVerificat)
        {
            foreach(string element in possibleSchoolSubjectsToTeach)
            {
                Console.WriteLine(element);
            }
        }

        /*
         * Metoda care verifica daca profesorul stie sa predea o anumita materie data
         */
        public bool validateSchoolSubject(string schoolSubject)
        {
            foreach(string element in possibleSchoolSubjectsToTeach)
            {
                if(element == schoolSubject)
                {
                    return true;
                }
            }
            return false;
        }

        //ToString

        public override string ToString()
        {
            string teacherString = "";
            teacherString = teacherString
                + "\n" + "Name: " + name
                + "\n" + "Gen: " + gen
                + "\n" + "Seniority: " + seniority 
                + "\n" + "Data nasterii: " + dataNasterii.ToShortDateString() 
                + "\n" + "School subject: ";
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
