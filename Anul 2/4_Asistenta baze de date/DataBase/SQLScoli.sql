create database Scoli
use Scoli 

create table Scoli
(
	Cod_Scoala int not null primary key identity (50,5),
	Adresa varchar(30),
	Director varchar(30)
)

create table Profesori
(
	Cod_Profesor int not null primary key identity(100,1),
	Cod_Scoala int not null foreign key references Scoli(Cod_Scoala),
	Nume_Profesor varchar(20),
	Data_Nasterii date,
	Grad int not null
)

create table Discipline
(
	Cod_Disciplina int not null primary key identity(1,50),
	Cod_Profesor int not null foreign key references Profesori(Cod_Profesor),
	Nume_Disciplina varchar(20),
	Nr_ore int not null
) 

insert into Scoli
(Adresa, Director)
values
('Cahul','Melinceanu Danut'),
('Rosu', 'Calmoi Maria')

select * from Scoli
insert into Profesori
(Cod_Scoala,Nume_Profesor,Data_Nasterii,Grad)
values
(50,'Babaianu Savelie','1980/12/01',1),
(50, 'Rosca Filadelfia','2000/08/23',2),
(50,'Ciobanu Ilie','1998/02/14',1),
(55,'Tornea Victor','1990/07/19',3),
(55,'Eremia Ana','2000/12/18',2),
(55,'Tanase Alina','1999/10/31',1)

select * from Profesori
insert into Discipline 
(Cod_Profesor,Nume_Disciplina,Nr_ore)
values
(100,'Informatica',80),
(100,'Matematica',120),
(101,'Limba romana',90),
(101,'Dezvoltare pers.', 20),
(102,'Tehnici de com.', 50),
(103,'Fizica', 90),
(104,'Istoria',100),
(104,'Chimia',30),
(105,'Baze de date',80)

-- 5 interogari UPDATE
update Discipline set Nr_ore = 120 where Nume_Disciplina like '%Informatica%'--Schimbam numarul de ore la diciplinele care contin subsirul 'Informatica' in denumire
update Profesori set Data_Nasterii='1997/12/19' where Cod_Profesor = 101 -- schimba data nasterii la profesorul cu ID-ul =55
update Profesori set Grad =10 where Cod_Profesor = 103 -- Schimbam gradul profesorrului cu ID = 103
update Scoli set Director = 'Apareci Aurica' where Cod_Scoala = 50 -- Modificam directorul la scola cu Id-ul 50
-- 5 interogari DELETE
delete from Discipline where Nr_ore<100--strgere discipline care au mai putin de 100 ore
delete from Profesori where Cod_Profesor = 103--stergere profesor cu ID = 103, posibile erori daca nu sunt sterse disciplinele profesorului cu ID-ul da
delete from Discipline where Nume_Disciplina like '%ate%'--sterge disciplinele care au in denumire subsirul 'ate'
delete from Profesori where Data_Nasterii not between DateAdd(YY,-40,GetDate()) and DateAdd(YY,-20, GETDATE()) --stergere profesori cu virsta necuprinsa intre 20 si 40 ani
