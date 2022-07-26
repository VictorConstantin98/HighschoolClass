using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal abstract class Person : IPerson
    {
        protected string name;
        protected Gen gen;
        protected DateTime dataNasterii;


        //Accesori
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

        public DateTime getDataNasterii()
        {
            return this.dataNasterii;
        }

        public void setDataNasterii(DateTime dataNasterii)
        {
            this.dataNasterii = dataNasterii;
        }

        //Implementam metoda din interfata

        public int CalculateAge(DateTime dataNasterii)
        {
            dataNasterii = new DateTime();
            var age = DateTime.Now.Year - dataNasterii.Year;
            return age;
        }
    }
}
