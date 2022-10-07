/*
Elaboraţi un program care citeşte de la tastatură două propozitii şi afişează pe ecran:
a) cuvintele care se întâlnesc cel puţin în una dintre propozitii; - intersectia
b) cuvintele care apar în ambele propozitii; - reuniunea
c) cuvintele care apar în prima şi nu apar în a doua propozitie. - diferenta

Notă: O propoziție conține cuvinte separate prin spațiu, alți separatori nu se
vor folosi. La sfârșitul propozitiei nu se pune punct.
 */
HashSet<string> A = new HashSet<string>();
HashSet<string> B = new HashSet<string>();

//citim datele de la tastatura si introducem elementele in multime
Console.WriteLine("Introduceti o propozitie: ");
string linie = Console.ReadLine();
string[] cuvinte = linie.Split(' ', ',');
foreach (string element in cuvinte)
{
    A.Add(element);
}

Console.WriteLine("Introduceti a doua propozitie: ");
string linie1 = Console.ReadLine();
string[] cuvinte1 = linie.Split(' ', ',');
foreach (string element in cuvinte)
{
    B.Add(element);
}

//crearea a 3 mutimi pentru efectuarea opratiilor 
HashSet<string> A1 = A.ToHashSet<string>();
HashSet<string> A2 = A.ToHashSet<string>();
HashSet<string> A3 = A.ToHashSet<string>();

//cuvintele care apar doar intr-o propozitie
Console.WriteLine("Intersectia: ");
A2.IntersectWith(B);
foreach (string item in A2)
{ Console.WriteLine(item); }

//cuvintele care apar in ambele propozitii
Console.WriteLine("Reuniunea: ");
A1.UnionWith(B);
foreach (string item in A1)
{ Console.WriteLine(item); }

//cuvintele din prima si nu sunt in a 2 
Console.WriteLine("Diferenta: ");
A3.ExceptWith(B);
foreach (string item in A3)
{ Console.WriteLine(item); }