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
        public Teacher(string name, Gen gen, int seniority, List<string> possibleSchoolSubjectsToTeach)
        {
            this.name = name;
            this.gen = gen;
            this.seniority = seniority;
            this.possibleSchoolSubjectsToTeach = new List<string>();
        }

        //ToString

        public override string ToString()
        {
            string teacherString = "";
            teacherString = teacherString + "Name: " + name + "\n" + "Gen: " + gen + "\n" + "Seniority: " + seniority + "\n" + "School subject: ";
            foreach(string element in possibleSchoolSubjectsToTeach)
            {
                teacherString = teacherString + "\n" + element.ToString();
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
