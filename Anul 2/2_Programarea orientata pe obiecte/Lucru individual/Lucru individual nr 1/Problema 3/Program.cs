/*
 Elaboraţi un program prin intermediul căruia vor fi gestionate automobilele
dintr-un salon auto. Despre un automobil se cunosc următoarele date:
 marca,
 anul ediţiei,
 culoarea,
 preţul,
 capacitatea motorului,
 consumul la 100 km.
De la tastatură se citesc datele despre n automobile.
Elaboraţi un program prin intermediul căruia la ecran se vor afişa datele despre:
 Automobilul cu cea mai mare capacitate a motorului
 Automobilul cu cel mai mic raport preț / anul ediției.
 */
using Problema_3;
Console.Write("Introduceti numarul de automobile : ");
int n = int.Parse(Console.ReadLine());
List<Automobil> automobile = new List<Automobil>();
Automobil masinuta = new Automobil();
for (int i = 0; i < n; i++)
{
    masinuta = new Automobil();
    masinuta.Citire();
    automobile.Add(masinuta);
}
double RaportCalitate = double.MaxValue;
double CapacitateMaxima = 0;
foreach (var item in automobile)
{
    if (item.Capacitate>CapacitateMaxima)
    {
        CapacitateMaxima = item.Capacitate;
    }
    if (item.Pret / item.AnulEditiei < RaportCalitate)
    {
        RaportCalitate = item.Pret / item.AnulEditiei;

    }
}
Console.Clear();
Console.WriteLine("--------------------------------------");
Console.WriteLine("Automobilul cu capacitatea maxima : ");
Console.WriteLine("--------------------------------------");
foreach (var item in automobile)
{
    if (item.Capacitate==CapacitateMaxima)
    {
        item.Afisare();
    }
}
Console.WriteLine("--------------------------------------");
Console.WriteLine("Automobilul cu cel mai mic raport pret / anul editiei : ");
Console.WriteLine("--------------------------------------");
foreach (var item in automobile)
{
    if (item.Pret / item.AnulEditiei==RaportCalitate)
    {
        item.Afisare();
    }
}
