CREATE DataBase Masini
USE Masini

CREATE table Branduri
(
	Anul_Fondarii int not Null,
	Fondator varchar(120) not Null,
	Nume_brand varchar(120) not null,
	ID_Brand int not Null primary key identity(100,1)
)

Create table Saloane
(
	ID_Salon int not Null primary key identity(10,10),
	ID_Brand int not Null foreign key references Branduri(ID_Brand),
	Adresa varchar(256) not Null,
	Nr_etaje int not Null,
	Capacitate_Max int not Null,
)

Create table Masini 
(
	ID_Masina int not Null primary key identity(50,5),
	ID_Salon int not Null foreign key references Saloane(ID_Salon),
	Model varchar(100) not Null,
	Culoare varchar(50) not Null,
	Putere_Motor int not Null
)

Create table Departamente
(
	ID_Departament int not Null primary key identity(1,5),
	ID_Salon int not Null foreign key references Saloane(ID_Salon),
	Nume_Departament varchar(100) not Null,
	Posuri_Vacante varchar(50) not Null
)

Create table Angajati
(
	ID_Angajat int not Null primary key identity(10,1),
	ID_Departament int not Null foreign key references Departamente(ID_Departament),
	Nume_Prenume varchar(100) not Null,
	Data_Nasterii int not Null,
	Adresa varchar(50) not Null,
	Post_Ocupat varchar(50) not Null,
	Salariu int not Null
)

insert into Branduri
( Anul_Fondarii, Fondator, Nume_brand)
values
(1845,'Charles Martin', 'Ford'),
(2000, 'Thomas Edison','Toyota')
