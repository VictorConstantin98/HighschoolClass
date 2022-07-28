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
            this.teacher = new Teacher(ssCopyConstructor.teacher);
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
            if(teacher != null)
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

        public void setTeacherDeepCopy(Teacher teacher)
        {
            if(teacher != null)
            {
                this.teacher = new Teacher(teacher);
            }
            else
            {
                if (teacher == null)
                {
                    throw new Exception("Teacher-ul este null. Incercati cu alt teacher.");
                }
            }
        }

        /*
         * Metoda de validare a Teacher-ului
         */
         
        public bool validateTeacherSubject()
        {
            bool rezultatValidare = false;
            foreach (string element in teacher.getLista())
            {
                if (this.nume == element)
                {
                    rezultatValidare = true;
                }
            }
            if(!rezultatValidare)
            {
                throw new Exception("Numele materiei nu corespunde. Incercati cu alt nume.");
            }
            return true;
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
