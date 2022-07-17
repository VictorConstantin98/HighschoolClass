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

        //Implementam metoda din interfata
        public double CalculateGrade()
        {
            throw new NotImplementedException();
        }
    }
}
