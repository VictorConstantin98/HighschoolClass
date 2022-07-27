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

        //Constructori
        public SchoolSubject(string nume)
        {
            this.nume = nume;
        }
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
         
        /*public bool validateTeacherSubject(string numeMaterie)
        {
            {
                foreach(string element in teacher.getLista())
                {
                    if(nume == numeMaterie)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("Numele materiei nu corespunde. Incercati cu alt nume.");
                    }
                }
                return false;
            }
        }*/

        //ToString
        public override string ToString()
        {
            string schoolSubjectString = "";
            schoolSubjectString = schoolSubjectString + "Nume materie: " + nume + "\n" + "Teacher: " + teacher; 
            return schoolSubjectString;
        }



    }
}
