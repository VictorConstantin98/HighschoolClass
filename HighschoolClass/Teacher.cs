using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class Teacher : Person
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
        public Teacher(int seniority, List<string> possibleSchoolSubjectsToTeach, string name, Gen gen)
        {
            this.seniority = seniority;
            this.possibleSchoolSubjectsToTeach = new List<string>();
            this.name = name; 
            this.gen = gen;
        }

        
    }
}
