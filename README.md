1. Implementeaza 2 Constructori pentru clasa Teacher
2. Implementeaza o metoda de ToString pentru Teacher
3. Implementeaza IComparable pentru clasa Teacher. (Doi profesori se compara si ordoneaza dupa vechime)
4. Implementeaza o metoda de adaugare subiecte posibile de predat in lista (possibleSchoolSubjectsToTeach)
5. Implementeaza o metoda care sterge din lista subiecte in functie de numele dat ca parametru (un anumit subiect dat)
6. Implementeaza o metoda de setare a senioritati cu validare ca are cel putin 1 an de senioritate, in caz contrar se arunca o exceptie

1. Implementeaza o validare a Teacher-ului din School Subject care verifca daca teacher-ul poate sa predea materia respectiva (variabila readonly nume a School Subject cu lista de materii posibile din teacher). Daca in lista de materii posibile nu se afla numele subiectului atunci se arunca o eroare. 
2. Sa se adauge o variabila data nastere de tip DateTime in Person si sa se implementeze calculeaza varsta. 
3. Sa se adauge o metoda in Teacher o metoda care verifica daca stie sa predea o anumita materie data.


1. Implementeaza o metoda statica care transforma stringul M,F,N in Gen Masculin, Feminin, Neutru si returneaza respectivul Gen. Pentru orice alt string se arunca o exceptie Custom. 
2. Implementeaza constructorii pentru School Subject (cu parametrul nume si cu fara parametrii (la cel fara parametrii teacherul este null)
3. Implementeaza o metoda care adauga care seteaza (aloca) un Teacher in SchoolSubject. (prin deep copy si nu shallow copy)
4. Implementeaza un constructor de copiere pentru clasa Teacher 
5. Alocarea Teacherului face verificarea de exceptie ArgumentNullException (se verifica daca argumentul/parametrul este null) (Exista un cod comentat in Program care ar trebui sa arunce eroare)
6. Implementeaza Constructor pentru Grade cu parametru SchoolSubject
7. Implementeaza o metoda de adaugare a unei note (aceasta metoda se numeste simplu add)
8. Implementeaza o metoda de modificare ultima nota (aceasta metoda se numeste simplu changeLast)
9. Implementeaza operatorul index ([]) care intoarce nota de la respectiva pozitie;
10.Implementeaza o metoda care intoarce numarul total de note (aceasta metoda se numeste count); -- To Do
11. Implementeaza metoda CalculateGrade care intoarce media notelor de la respectiva materie
12. -- To DO Implementeaza validarea notelor oriunde acestea se modifica pentru a nu putea fi decat intre 1 si 10. In caz contrar se arunca o excepti ArgumentOutOfRange si mesajul cu ce fel de note trebuie adaugate ca validarea sa fie buna


1. Sa sa implementeze Constructorul cu toti parametrii ai clasei Peron. Trebuie sa fie Protected;
2. Sa se implementeze pentru clasa Student Constructorul cu toti parametrii mai putin Lista. (Sa se foloseasca constructorul din clasa de baza ca si ajutor)(conceptul de base)
3. Sa se implemeteze o metodata de adaugare Materie (SchoolSubject) in Student. (Prin intermediul listei Grade din student) (Conceptul de asignare a unei materii unui student)
4. Sa se implementeze o metodata care adauga o nota la o anumita materie unui student (Numele materiei este data ca parametru)
5. Sa se implementeze o metoda care returneaza media la o anumita materie a studentului. 
6. sa se implementeze o metoda care implementeaza CalculateGrade (aceasta trebuie sa intoarca media studentului la toate materiile) 


 
