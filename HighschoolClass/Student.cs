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
            this.studentGradeList = new List<Grade>();
            this.dataNasterii= dataNasterii;
        }

        //Implementam metoda din interfata
        public double CalculateGrade()
        {
            throw new NotImplementedException();
        }
    }
}
