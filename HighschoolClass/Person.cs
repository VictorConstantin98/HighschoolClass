using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal abstract class Person : IPerson
    {
        private enum gender { Masculin, Feminin, Neutru };
        private string name;

        //Implementam metoda din interfata
        public int CalculateAge()
        {
            throw new NotImplementedException();
        }
    }
}
