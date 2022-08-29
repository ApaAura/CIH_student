/*
 Elaboraţi un program prin intermediul căruia vor fi administrate hotelurile dintr-o ţară.
Despre un hotel se cunosc următoarele date:
 Nume hotel, adresa,
 Numărul de stele,
 Numărul de odăi (camere)
 Costul minim pentru o cameră
 Costum maxim pentru o cameră
De la tastatură se citesc datele despre n hoteluri.
Elaboraţi un program prin intermediul căruia la ecran se vor afişa datele despre:
 Hotelul cu cea mai scumpă cameră
 Hotelurile ce au mai mult de 4☆
 */
using Problema_4;
Console.Write("Introduceti numarul de hoteluri : ");
int n = int.Parse(Console.ReadLine());
List <Hotel> Hoteluri = new List <Hotel>();
Hotel Hotel1= new Hotel();
for (int i = 0; i < n; i++)
{
    Hotel1 = new Hotel();
    Hotel1.Citire();
    Hoteluri.Add(Hotel1);
}
double PretMaxim = 0;
foreach (var item in Hoteluri)
{
    if (item.PretMax>PretMaxim)
    {
        PretMaxim = item.PretMax;
    }
}
Console.Clear();
Console.WriteLine("---------------------------------");
Console.WriteLine("Hotelul cu pretul maxim : ");
Console.WriteLine("---------------------------------");
foreach (var item in Hoteluri)
{
    if (item.PretMax==PretMaxim)
    {
        item.Afisare();
    }
}
Console.WriteLine("---------------------------------");
Console.WriteLine("Hotelul ce au mai mult de 4 Stele : ");
Console.WriteLine("---------------------------------");
foreach (var item in Hoteluri)
{
    if (item.NrStele>=4)
    {
        item.Afisare();
    }
}

