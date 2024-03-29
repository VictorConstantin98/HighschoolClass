﻿using System;
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

        //Constructor implicit
        public Person()
        {

        }

        //Constructor explicit
        public Person(string name, Gen gen, DateTime dataNasterii)
        {
            this.name = name;
            this.gen = gen;
            this.dataNasterii = dataNasterii;
        }

        //Copy constructor
        public Person(Person personCopyConstructor)
        {
            this.name = personCopyConstructor.name;
            this.gen = personCopyConstructor.gen;
            this.dataNasterii = personCopyConstructor.dataNasterii;
        }

        //Implementam metoda din interfata
        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - this.dataNasterii.Year;
            return age;
        }

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

        /*
         * Metoda statica stringToEnum
         */

        public static Gen stringToGen(string genString)
        {
            if (genString == "M")
                return Gen.Masculin;
            if (genString == "F")
                return Gen.Feminin;
            if (genString == "N")
                return Gen.Neutru;
            else
                throw new Exception("Litera genului nu corespunde. Incercati cu alta litera");
        }
    }
}
