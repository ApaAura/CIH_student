/*
 Scrieţi un program care citeşte de la tastatură elementele mulţimilor A şi B şi afişează pe ecran:
a) intersecţia mulţimilor A şi B;
b) reuniunea mulţimilor A şi B;
c) diferenţa mulţimilor A şi B;
Mulţimile A şi B sunt formate din literele mari ale alfabetului latin.
 */

HashSet<int> numere=new HashSet<int>();
HashSet<int> numere1 = new HashSet<int>();

Console.WriteLine("Introduceti numarul de elemente al multimii A: ");
int nr=int.Parse(Console.ReadLine());
Console.WriteLine($"Introduceti {nr} elemente:");
for (int i = 0; i < nr; i++)
{
    int element = int.Parse(Console.ReadLine());
    numere.Add(element);
}

Console.WriteLine("Introduceti numarul de elemente al multimii B: ");
int nr1=int.Parse(Console.ReadLine());
Console.WriteLine($"Introduceti {nr} elemente:");
for (int i = 0; i < nr1; i++)
{
    int element1 = int.Parse(Console.ReadLine());
    numere.Add(element1);
}

Console.Clear();
HashSet<int> A1 = numere.ToHashSet<int>();
HashSet<int> A2 = numere.ToHashSet<int>();
HashSet<int> A3 = numere.ToHashSet<int>();

Console.WriteLine("Reuniunea: ");
A1.UnionWith(numere1);
foreach (int item in A1)
{ Console.WriteLine(item);}

Console.WriteLine("Intersectia: ");
A2.IntersectWith(numere1);
foreach (int item in A2)
{ Console.WriteLine(item); }

Console.WriteLine("Diferenta: ");
A3.ExceptWith(numere1);
foreach (int item in A3)
{ Console.WriteLine(item); }