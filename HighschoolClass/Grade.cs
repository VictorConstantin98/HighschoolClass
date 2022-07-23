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
        private List<int> gradesLst;

        //Implementam metoda din interfata
        public double CalculateGrade()
        {
            throw new NotImplementedException();
            
        }
    }
}
