using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class SubjectNotFoundException : Exception
    {
        public SubjectNotFoundException() :base("Materia nu corespunde. Incercati cu alta materie")
        {
        }
    }
}
