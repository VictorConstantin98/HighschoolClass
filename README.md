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

1. Sa se modifice proprietatea classGrade din Student in yearClass(reprezinta ce clasa este studentul) 
2. Sa se implementeze o metoda statica in Student YearStudentEvaluation (care primeste un student ca parametru) si verifica daca media studentului este peste 5 si daca are cel putin o nota la fiecare materie. Daca media anuala este peste 5 atunci studentul trece in urmatorul an. (yearClass se incrementeaza) si se afiseaza un mesaj la consola "Studentul <nume> a trecut clasa". 
In caz ca yearClass trece de 12 atunci se afiseaza ca elevul a absolvit scoala si se arunca o exceptie custom.
4. In clasa profesor de implementeaza o metoda de setare a senoriotatii.
5. In student Sa se realizeze un get pentru lista de materii (Grade) la care este inscris studentul.


Se va realiza la Program urmatoarele utilizand metodele curente.
1. Se definesc 5 profesori dupa cum urmeaza:
		- Primi doi cu constructorul explicit;
		- Al treilea cu constructor de copiere;
		- Al patrulea si al cincelea cu constructorul implicit;
2. Fiecarui profesor va putea preda 2 materii. { P1 (Math, Physics) P2(Math,Biology), P3(Music,English), P4(English,French), P5(Chemistry,Biology)}
3. Pentru fiecare profesor se seteaza o senioritate. 
4. Sa se aleaga care dintre P2 si P5 este mai senior pentru a preda Biologie (Se compara P2 si P5 care dintre cei doi este mai senior).
5. Sa se adauge cei 5 profesori intr-o lista. 
6. Sa se defineasca urmatoarele materii (SchoolSubject) (Math, Physics,Biology,Chemistry, Music, French, German);
7. Fiecaruia dintre materii sa se i se aloce un profesor si sa se valideze ca profesorul respectiv stie sa predea respectiva materie;
8. Profesorul care preda Math pleaca in concediu, trebuie sa se aloce un alt profesor sa prea Math (Sa se modifice Materia Math cu un alt profesor din Lista care poate preda Math). 
9. Sa se ordoneze profesorii din lista dupa senioritte (explica ce metoda ai folosit, de ce si cu ce te-ai ajutat)
10. Sa se defineasca SchoolSubject Romanian si sa caute un profesor care poate sa o predea, in caz contrar se angajeaza un nou profesor (P6) care preda Romana si se adauga in lista de profesor respectiv sa predea aceasta materie
11. Sa se defineasca materia English si sa se aloce profesorul care cea mai mare senioritate si poate sa predea respectiva materie. 
12. Sa se adauge toate materiile intr-o lista. 
13. Sa se creeze 5 studenti (S1,S2,S3,S4,S5) toti in aceasi clasa (classGrade)
14. Inscrie toti studentii la urmatoarele materiir (Math,Physics,Biologie) (adaugand school subjects)
15. Sa se adauge materiile optionale dupa cum urmeaza:
	Student 4: Musica si Engleza
	Student 5: Engleza si Franceza
	Student 2,3: Chemistry
16. Sa se adauge studentii intr-o lista 
17. Sa se adauge cate o nota la matematica fiecarui student.
18. Sa se adauge cate 2 note la Physics.
19. Sa se incerce sa se adauge o nota la Musica fiecarui student. (Ce se intampla? cum tratam situatia)
20. Sa se adauge 3 note fiecarui student la Biologie. 
21. Sa se adauge nota 11 studentului 5 la Engleza;
22. Sa se afiseze media fiecarei materii pentru studentul 5;
23. Sa se adauge note la Chemistry pentru 2 si 3 ;  (2 note);
24. Sa se afiseze media generala a fiecarui student; 
25. Sa se realizeze evaluarea anuala pentru fiecare student (4 trebuie sa pice pentru ca nu au note la Engleza si 5 la Franceza, Ar mai trebui unul sa pice pentru ca are note mici)
26. Sa se sorteze studentii in lista dupa nota generala.

 
27. In Clasa School sa se realizez: La adaugrea unei materii in lista sa se valideze ca exista si profesor asignat materiei (nu e null profesul din School Subject) si ca acesta se afla in lista de profesori. 
28. In Class School sa se realizeze metoda de inscriere a unei elev la o materie din lista pe baza numelui materiei
29. In Class School sa se realizeze o metoda care da o nota unui elev la o anumita materie (parametrii de intrare ar fi numele elevului, materia si nota). Metoda trebuie sa caute elevul sa-i puna nota la respectiva materie;
30. In Class School sa se realizeze o metoda ce intoarce media generala a unui elev dat (parametru numele elevului)
31. In Class School sa se realizeze o metoda ce intoarce elevul cu cea mai mare medie. 
	(Optional: Sa se implementeze din metodele (cerintele) facute in program in School; Eg; Sa stearga un profesor si atunci sa se realoce un alt profesor; Sa se aloce un profesor cu cea mai mare senioritate; Sa se promoveze clasa, etc.)

32. Sa se comenteze tot programul din main si sa se realizeze o structura repetitiva infinit de tip consola ce asteapta de la utilizator instructiuni; (Sa se caute pe net cum scri de la tastatura)
		In structura repetitiva de tip consola utilizatorul poate sa faca urmatoarele lucruri in functie de ce comanda da: 
			1. Sa se afiseze un Help cu ce instructiuni poate da catre calculator; 
			2. Sa se adauge un Profesor in scoala; 
			3. Sa modifice materiile cunoscute de un anumit profesor ( sa adauge o noua materie pe care un profesor o poate preda)
			4. Sa modifice numele unui profesor din lista. 
			5. Sa vizualizezei la ecran toti profesorii inscrisi in scoala impreuna cu toate datele lor;
			6. Sa adauge o materie in scoala (alocand si un profesor din cei inscrisi in scoala);  
			7. Sa vizualizezi la ecran toate materiile din scoala impreuna cu toate datele lor;
			6. Sa adauge un elev in scoala; 
			7. Sa inscrie un elev la o materie din scoala;
			8. Sa ii dea note unui elev la o anumita materie;
			9. Sa vizualizezi toti elevii din scoala impreuna cu notele si materiile lor; 
			10. Sa vizualizeze media generala a unui elev;
			11. Sa vizualizeze elevul premiant (elevul cu cea mai mare medie); 
			12. Sa iasa din programul consola cu o anumita comanda (sa iasa din loop cu o comanda);
					(Optional sa se implementeze alte metode la liber din toate celelalte cerinte; Eg; Sa se stearga un profesor dat, sa evalueze un elev daca trece clasa; Sa plece un profesor in concediu; Sa se stearga un elev; etc. Sa se evalueaze toti elevii, etc.)
					
				


			
	