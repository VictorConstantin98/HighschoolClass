using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class SchoolSubject
    {
        private readonly string nume;
        private Teacher teacher;

        public SchoolSubject() 
        {
            this.teacher = null;
        }

        //Accesori
        public string getNume()
        {
            return this.nume;
        }

        public Teacher getTeacher()
        {
            return this.teacher;
        }

        public void setTeacher (Teacher teacher)
        {
            this.teacher = teacher;
        }

        /*
         * Metoda de validare a Teacher-ului
         */
         
        public bool validateTeacherSubject(string numeMaterie)
        {
            if(numeMaterie == this.nume)
            {
                return true;
            }
            else
            {
                return false;
                throw new Exception("Numele materiei este invalid. Verificati cu alt nume.");
            }
        }

        //ToString
        public override string ToString()
        {
            string schoolSubjectString = "";
            schoolSubjectString = schoolSubjectString + "Nume materie: " + nume;
            return schoolSubjectString;
        }



    }
}
