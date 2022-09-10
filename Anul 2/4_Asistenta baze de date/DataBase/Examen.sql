create database Hotel
Use Hotel

Create table Client 
(
	Cod_Client int not null primary key identity(100,1),
	NPclient varchar(50) not null,
	IDNPclient varchar(13) not null,
	Telefon varchar(30) not null
)

Create table ServiciiHoteliere
(
	Cod_Serviciu int not null primary key identity(50,1),
	Cod_Client int not null foreign key references Client(Cod_Client),
	Denumirea varchar(30) not null,
	Pret int not null,
	DurataServicii int not null
)

insert into Client 
(NPclient, IDNPclient, Telefon)
values
('Apareci Aurica','1234567890123', '068329256'),
('Babaianu Savelie','9876543219876', '069123567'),
('Manica Marius', '3456782345678', '078456789')

select * from  Client
insert into ServiciiHoteliere
values
(100, 'Cazare', 2400, 5),
(100, 'Restaurant', 1000, 5),
(101, 'Cazare', 1200, 2),
(101, 'Fitness', 500, 1),
(102, 'Cazare', 2000, 2),
(102, 'Spa', 600, 1)

-- Lista clientilor care au beneficiat de serviciul 'Fitness' si al caror numar de telefon incepe cu '069'
select * From Client where Cod_Client in 
									(select Cod_Client from ServiciiHoteliere where Denumirea like '%Fitness%')
-- Costul cheltuielilor si durata sederii a clientilor care incep cu litera 'M'
select NPclient,SUM(DurataServicii) as 'Durata sederii',SUM(Pret) as 'Costul sederii' 
from Client inner join ServiciiHoteliere on Client.Cod_Client = ServiciiHoteliere.Cod_Client 
where NPclient like 'M%' group by NPclient
-- Lista clientilor si suma serviciilor achitate
select NPclient,SUM(Pret) as 'Costul sederii' 
from Client inner join ServiciiHoteliere on Client.Cod_Client = ServiciiHoteliere.Cod_Client 
group by NPclient
