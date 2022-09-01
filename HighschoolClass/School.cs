using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighschoolClass
{
    internal class School
    {
        private List<Student> listaStudentiScoala;
        private List<Teacher> listaProfesoriScoala;
        private List<SchoolSubject> listaMateriiScoala;

        //Constructor
        public School()
        {
            this.listaStudentiScoala = new List<Student>();
            this.listaProfesoriScoala = new List<Teacher>();
            this.listaMateriiScoala = new List<SchoolSubject>();
        }

        //Metoda de adaugat elemente in lista de elevi
        public void addInStudenti(Student student)
        {
            listaStudentiScoala.Add(student);
        }

        //Metoda de adaugat elemente in lista de profesori

        public void addInProfesori(Teacher teacher)
        {
            listaProfesoriScoala.Add(teacher);
        }

        //Metoda de adaugat elemente in lisita de materii

        public void addInMaterii(SchoolSubject grade)
        {
            listaMateriiScoala.Add(grade);
        }

        //Getteri

        public List<Student> getListaStudentiScoala()
        {
            return this.listaStudentiScoala;
        }

        public List<Teacher> getListaProfesoriScoala()
        {
            return this.listaProfesoriScoala;
        }

        public List<SchoolSubject> getListaMateriiScoala()
        {
            return this.listaMateriiScoala;
        }

        //lista elevi
        //lista profesori
        //lista materii

        //o metoda de initializare(constructor) -> toti
        //metode care sa imi adauge elemente in fiecare lista(elevi, profesori, materii)*
    }
}
