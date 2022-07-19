using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal abstract class Person : IPerson
    {
        private string name;
        private Gen gen;


        //Getteri & setteri
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public Gen getGen()
        {
            return this.gen;
        }

        public void setGen(Gen gen)
        {
            this.gen = gen; 
        }
        //Implementam metoda din interfata
        public int CalculateAge()
        {
            throw new NotImplementedException();
        }
    }
}
