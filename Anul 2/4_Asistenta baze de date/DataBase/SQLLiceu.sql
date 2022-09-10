create database Liceu
use Liceu

create table Profesori
(
	Cod_Profesor int not null primary key identity(100,1),
	Nume_Profesor varchar(20),
	Data_Nasterii date
)

create table Discipline
(
	Cod_Disciplina int not null primary key identity(1,50),
	Cod_Profesor int not null foreign key references Profesori(Cod_Profesor),
	Nume_Disciplina varchar(20),
	Nr_ore int not null
) 

insert into Profesori 
(Nume_Profesor,Data_Nasterii)
values
('Babaianu Savelie','1980/12/01'),
('Rosca Filadelfia','2000/08/23'),
('Ciobanu Ilie','1998/02/14')

select * from Profesori 
insert into Discipline
(Cod_Profesor, Nume_Disciplina, Nr_ore)
values
(100,'Informatica',80),
(100,'Matematica',120),
(101,'Limba romana',90),
(101,'Dezvoltare pers.', 20),
(101,'Tehnici de com.', 50),
(102,'Fizica', 90)

-- Lista profesorilor si disciplinele predate ordonata dupa numele profesorului
select Nume_Profesor, Nume_Disciplina from Profesori inner join Discipline
	on Profesori.Cod_Profesor = Discipline.Cod_Profesor
	order by Nume_Profesor
-- Lista profesorilor care predau mai mult de o disciplina
select Nume_Profesor, count(*) as 'Numarul de discipline' from Profesori inner join Discipline 
	on Profesori.Cod_Profesor = Discipline.Cod_Profesor
	Group by Profesori.Nume_Profesor having count(*)>1 
-- Numele profesorilor si numarul total de ore predate 
select Nume_Profesor,sum(Nr_ore) as 'Numar total de ore' from Profesori inner join Discipline 
	on Profesori.Cod_Profesor = Discipline.Cod_Profesor
	Group by Profesori.Nume_Profesor

