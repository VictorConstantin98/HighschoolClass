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
            this.teacher = new Teacher();
        }
        public SchoolSubject() 
        {
            this.teacher = null;
        }

        //CopyConstructor
        public SchoolSubject(SchoolSubject ssCopyConstructor)
        {
            this.nume = ssCopyConstructor.nume;
            this.teacher = ssCopyConstructor.teacher;
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
            if(this.teacher != null)
            {
                this.teacher = teacher;
            }
            else
            {
                if(this.teacher == null)
                {
                    //throw new Exception("Teacher-ul este null. Incercati cu alt teacher.");
                }
            }
        }

        /*
         * Metoda de validare a Teacher-ului
         */
         
        public bool validateTeacherSubject(string numeMaterie)
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
                        return false;
                        throw new Exception("Numele materiei nu corespunde. Incercati cu alt nume.");
                    }
                }
                return true;
            }
        }

        //ToString
        public override string ToString()
        {
            string schoolSubjectString = "";
            schoolSubjectString = schoolSubjectString + "Nume materie: " + nume + "\n" + "Teacher: " + teacher + "\n"; 
            return schoolSubjectString;
        }



    }
}
