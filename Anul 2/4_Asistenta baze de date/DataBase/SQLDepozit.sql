create database Depozit
Use Depozit

Create table Depozite
(
	ID_Depozit int not null primary key identity(100,100),
	Adresa varchar(120) not null
)

Create table Angajati
(
	ID_Angajat int not null primary key identity(12,2),
	ID_Depozit int not null foreign key references Depozite(ID_Depozit),
	Nume_Prenume varchar(100) not null,
	IDNP varchar(13) not null,
	Functie varchar(50) not null
)

create table Marfuri
(
	ID_Marfa int not null primary key identity(50,2),
	ID_Depozit int not null foreign key references Depozite(ID_Depozit),
	Denumire_marfa varchar(50) not null,
	Stoc int not null,
	Pret int not null,
	Unitate varchar(20) not null
)

create table Vanzari
(
	ID_Vanzare int not null primary key identity(10,5),
	ID_Marfa int not null foreign key references Marfuri(ID_Marfa),
	Cantitate int not null,
	Data_vanzare Date not null
)

insert into Depozite
(Adresa)
values
('Chisinau'),
('Cahul')

select * from Depozite 
insert into Angajati
(ID_Depozit, Nume_Prenume, IDNP, Functie)
values
(100, 'Babaianu Savelie',	'1234567890126',	'Director'),
(100, 'Bahnaru Dragos',		'9087654321123',	'Responsabil stoc'),
(100, 'Vadim Postica',		'3456782345678',	'Hamal'),
(200, 'Obreja Nicolaie',	'4561368924567',	'Director'),
(200, 'Caracaci Sorin',		'6719452017817',	'Responsabil stoc'),
(200, 'Leu Maxim',			'9087123456890',	'Sofer')

insert into Marfuri
(ID_Depozit,Denumire_marfa,Stoc,Pret,Unitate)
values
(100, 'Banane', 100, 30, 'kg'),
(100, 'Bomboane', 150, 60, 'kg'),
(100, 'Cartofi', 1000, 8, 'kg' ),
(100, 'Paine', 80, 9, 'buc'),
(200, 'Nisip', 1000, 700, 't'),
(200, 'Gresie', 500, 120, 'm^2'),
(200, 'Scandura', 300, 796, 'm^3'),
(200, 'Armatura', 600, 330, 'm')

set dateformat dmy
Select * from Marfuri
insert into Vanzari
(ID_Marfa, Cantitate, Data_vanzare)
values
(50, 50, '01.12.2021'),
(54, 150, '01.08.2019'),
(58, 80, '14.04.2020'),
(60, 200, '04.12.2018'),
(56, 30, '23.08.2021'),
(64, 30, '09.02.2021')

-- interogarea, ce returneaza lista produselor procurate si valoarea lor;
select Marfuri.ID_Marfa, Marfuri.Denumire_marfa,SUM(Vanzari.Cantitate) as 'Cantitate vanduta', SUM(Marfuri.Pret*Vanzari.Cantitate) as 'Cost total'
from Marfuri inner join Vanzari on Marfuri.ID_Marfa = Vanzari.ID_Marfa group by Marfuri.ID_Marfa, Marfuri.Denumire_marfa
--  interogarea, ce returneaza lista produselor, numele carora incepe cu litera 'B';
select * from Marfuri where Denumire_marfa like 'B%' or Denumire_marfa like 'b%'
-- interogarea, ce returneaza valoarea procurarilor facute in prima zi a lunii.
select Marfuri.ID_Marfa, Marfuri.Denumire_marfa,SUM(Vanzari.Cantitate) as 'Cantitate vanduta', SUM(Marfuri.Pret*Vanzari.Cantitate) as 'Cost total'  
from Marfuri inner join Vanzari on Marfuri.ID_Marfa = Vanzari.ID_Marfa 
where Day(Data_vanzare) = 1
group by Marfuri.ID_Marfa, Marfuri.Denumire_marfa