create database Universitate
use Universitate

Create table Facultati
(
	ID_Facultate int not null primary key identity(10,5),
	Denumire varchar(120) not null,
	Rector varchar(120) not null,
	Adresa varchar(120) not null
)

Create table Studenti
(
	ID_Student int not null primary key identity(1,15),
	ID_Facultate int not null foreign key references Facultati(ID_Facultate),
	Nume_Prenume varchar(120) not null,
	Adresa varchar(120) not null,
	Varsta int not null
)

create table Note
(
	ID_Nota int not null primary key identity(50,2),
	ID_Student int not null foreign key references Studenti(ID_Student),
	Data_nota varchar(120) not null,
	Nota int not null
)

insert into Facultati
(Denumire, Rector, Adresa)
values
('Inginerie si mecanica','Vasile Bostan','Str. Bucuresti 56'),
('Filologie si istorie','Mocanu Ion','Str. Alexei Mateevici 28'),
('Matematica si calculatoare','Bagrin Dumitru','Str. Trandafirilor 15')

select ID_Facultate from Facultati
insert into Studenti
(ID_Facultate, Nume_Prenume,Adresa,Varsta)
values
(10,'Peicu Daniel','Cahul',20),
(10,'Bagrin Mihail','Larguta',21),
(15,'Bahnaru Dragos','Tretesti',19),
(15,'Caramela Igor','Chisinau',23),
(20,'Babaianu Savelie','Andrusu',20),
(20,'Arteni Nicolae','Bucuresti',21)

select ID_Student from Studenti
insert into Note
(ID_Student,Data_nota,Nota)
values
(1,'12.10.21',8),
(16,'24.09.21',9),
(31,'18.02.21',6),
(46,'14.11.21',10),
(61,'08.04.21',8),
(76,'05.12.21',9)