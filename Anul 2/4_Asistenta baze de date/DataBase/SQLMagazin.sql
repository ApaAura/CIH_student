create database Magazin
USE Magazin
Create table Magazine
(
	ID_Magazin int not null primary key identity(100,1),
	Adresa varchar(120) not null,
	Manager varchar(120) not null,
	Nr_Angajati int not null
)

create table Angajati
(
	ID_Angajat int not null primary key identity(50,2),
	ID_Magazin int not null foreign key references Magazine(ID_Magazin),
	Nume varchar(50) not Null,
	Prenume varchar(50) not Null,
	Data_Nasterii Date not Null,
	IDNP varchar(13) not Null,
	Post varchar(50) not null
)

create table Produse
(
	ID_Produs int not null primary key identity(15,1),
	ID_Magazin int not null foreign key references Magazine(ID_Magazin),
	Categorie varchar(50) not null,
	Denumire varchar(50) not null,
	Termen_de_valibilitate int not null,
	Pret int not null
)

insert into Magazine
(Adresa, Manager, Nr_Angajati)
values
('Bucuresti','Peicu Daniel',20),
('Chisinau', 'Babaianu Savelie',45)

set DateFormat dmy

insert into Angajati
(ID_Magazin, Nume, Prenume, Data_Nasterii, IDNP, Post)
values
(100,'Bagrin','Mihail','12/09/1998','1926890124579','Contabil'),
(100,'Bagrin','Loredana','03/06/2002','8006543288699','Responsabil de stoc'),
(100,'Pasat','Darius','18/01/2005','1227900172992','Consultant'),
(100,'Echim','Eugen','24/05/1999','6712671267129','Casier'),
(100,'Vlas','Maria','19/11/1982','7654456712201','Paznic'),
(101,'Antoniu','Ghenadie','28/09/2000','1122334455667','Casier'),
(101,'Panainte','Alex','21/11/1996','5634781233900','Consultant'),
(101,'Morari','Nicoleta','15/01/1995','5462837546283','Responsabil de stoc'),
(101,'Rotaru','Raul','16/02/2003','1421641142164','Casier'),
(101,'Vieru','Petru','18/04/1999','2970087297008','Paznic')

insert into Produse
(ID_Magazin, Categorie, Denumire, Termen_de_valibilitate ,Pret)
values
(100,'Produs alimentar', 'Paine feliata', 3, 7),
(101,'Produs alimentar', 'Paine feliata', 3, 9),
(100,'Uz casnic', 'Detergent Vanish', 700, 64),
(101,'Uz casnic', 'Detergent Vanish', 700, 58),
(100,'Vestimentatie', 'Sosete', 0, 21),
(101,'Vestimentatie', 'Sosete', 0, 18),
(100,'Produse de ingrijire','Sapun', 0, 39),
(101,'Produse de ingrijire','Sapun', 0, 40)

--Order by desc 
--Magazile in ordine descrescatoare dupa numarul de angajati
select * from Magazine
		order by Nr_Angajati desc
--Order by asc
--Produsele in ordire crescatoare dupa pret
select * from Produse
		order by Pret asc
--max
--Produsul cu cel mai mare termen de valabilitate
select * from Produse where Termen_de_valibilitate in 
        (select Max (Termen_de_valibilitate) from Produse)
--min
--Cea mai ieftina paine
select * from Produse where Denumire like '%Paine%' and Pret in
		(Select Min (Pret) from Produse)
--sum
--Pretul total la produsele din magazinul cu ID-ul 100
select Sum (Pret) as 'Pret total' from Produse where ID_Magazin = 100
