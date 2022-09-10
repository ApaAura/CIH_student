Create database Aeroport
USE Aeroport

Create table Aeroporturi 
(
	ID_Aeroport int not Null primary key identity(100,1),
	Adresa varchar(120) not Null,
	Manager varchar(100) not Null,
	Nr_porturi int not Null
)

Create table Curse
(
	ID_Cursa int not Null primary key identity(50,2),
	ID_Aeroport int not Null foreign key references Aeroporturi(ID_Aeroport),
	Destinatie varchar(100) not Null,
	Nr_locuri int not Null,
	Escala bit not Null
)

Create table Pasageri
(
	ID_Pasageri int not Null primary key identity(7,3),
	ID_Cursa int not Null foreign key references Curse(ID_Cursa),
	Nume varchar(50) not Null,
	Prenume varchar(50) not Null,
	Data_Nasterii Date not Null,
	IDNP varchar(13) not Null
)

insert into Aeroporturi
(Adresa, Manager,Nr_porturi)
values
('Bucuresti','Peicu Daniel',8),
('Chisinau', 'Babaianu Savelie',6)

select ID_Aeroport from Aeroporturi
--0 False 1 True
insert into Curse
(ID_Aeroport,Destinatie,Nr_locuri,Escala)
values
(100,'Maldive',190,1),
(100,'Berlin',200,0),
(100,'Amsterdam',160,0),
(101,'Kiev',150,0),
(101,'Tokyo',200,1),
(101,'Toronto',160,1)

select ID_Cursa from Curse
set dateformat dmy
insert into Pasageri
(ID_Cursa,Nume,Prenume,Data_Nasterii,IDNP)
values
(50,'Bagrin','Mihail','12/09/1998','1926890124579'),
(50,'Bagrin','Loredana','03/06/2002','8006543288699'),
(50,'Pasat','Darius','18/01/2005','1227900172992'),
(52,'Echim','Eugen','24/05/1999','6712671267129'),
(52,'Vlas','Maria','19/11/1982','7654456712201'),
(52,'Eftim','Cristina','30/04/1978','1237893219875'),
(54,'Antoniu','Ghenadie','28/09/2000','1122334455667'),
(54,'Panainte','Alex','21/11/1996','5634781233900'),
(54,'Morari','Nicoleta','15/01/1995','5462837546283'),
(56,'Rotaru','Raul','16/02/2003','1421641142164'),
(56,'Asachi','Amalia','17/03/2002','8190471819047'),
(56,'Vieru','Petru','18/04/1999','2970087297008'),
(58,'Camenschi','Teodor','19/05/1982','5621055562105'),
(58,'Vieru','Anastasia','20/06/1977','7143989714398'),
(58,'Anton','Ion','25/07/2006','9972235997223'),
(60,'Maidan','Gheorghe','07/08/2001','3276528327652'),
(60,'Cristea','Mihaela','27/09/1969','1539738153973'),
(60,'Oprea','Valeria','29/10/1988','1850925185092')

--10 Interogari
-- Cursele cu destinatia Tokyo
select * from Curse where Destinatie = 'Tokyo' 
-- Cursele cu escala
select * from Curse where Escala = 1
-- Pasagerii cu numele 'Vieru'
select * from Pasageri where Nume ='Vieru'
-- Cursele cu 160 de locuri si fara escala
select * from Curse where Nr_locuri = 160 and Escala = 0
-- Aeroportul cu numarul minim de portaluri
select * from Aeroporturi where Nr_porturi in (select Min(Nr_porturi) from Aeroporturi)
-- Pasagerii nascuti in 1988
select * from Pasageri where Year(Data_Nasterii) = 1988
-- Pasagerii care merg in Maldive
select * from Pasageri where ID_Cursa in 
		(select ID_Cursa from Curse where Destinatie = 'Maldive')
-- Pasagerii care pleaca in Kiev in ordine descrescatoare dupa anul nasterii
select * from Pasageri where ID_Cursa in 
		(select ID_Cursa from Curse where Destinatie = 'Kiev')
		order by Year(Data_Nasterii) desc
-- Numarul mediu de locuri al avioanleor in fiecare aeroport
select ID_Aeroport, AVG(Nr_locuri) as 'Numar mediu de locuri' 
		from Curse group by ID_Aeroport
-- Pasagerii care zboara la Amsterdam sau la Berlin
select * from Pasageri where ID_Cursa in 
			(select ID_Cursa from Curse where 
					Destinatie = 'Amsterdam' 
						or  
					Destinatie= 'Berlin')

