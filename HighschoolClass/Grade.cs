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

        //Implementam metoda din interfata
        public double CalculateGrade()
        {
            throw new NotImplementedException();
        }

        public Grade(SchoolSubject schoolSubject)
        {
            this.schoolSubject = schoolSubject;
            this.gradesList = new List<int>();
        }
    }
}
