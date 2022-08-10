using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class YearOutOfRangeException : Exception
    {
        public YearOutOfRangeException() : base("Elevul a absolvit scoala.")
        {
        }
    }
}
