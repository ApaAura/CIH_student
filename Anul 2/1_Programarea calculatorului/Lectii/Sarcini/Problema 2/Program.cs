/*
Elaboraţi un program care citeşte de la tastatură două propozitii şi afişează pe ecran:
a) cuvintele care se întâlnesc cel puţin în unul dintre propozitii;
b) cuvintele care apar în ambele propozitii;
c) cuvintele care apar în prima şi nu apar în a doua propozitie.

Notă: O propoziție conține cuvinte separate prin spațiu, alți separatori nu se
vor folosi. La sfârșitul propozitiei nu se pune punct.
 */
HashSet<string> A = new HashSet<string>();
HashSet<string> B = new HashSet<string>();

Console.WriteLine("Introduceti o propozitie: ");
string linie = Console.ReadLine();
string[] cuvinte = linie.Split(' ', ',');
foreach (string element in cuvinte)
{
    A.Add(element);
}

Console.WriteLine("Introduceti o propozitie: ");
string linie1 = Console.ReadLine();
string[] cuvinte1 = linie.Split(' ', ',');
foreach (string element in cuvinte)
{
    B.Add(element);
}

Console.Clear();
HashSet<string> A1 = A.ToHashSet<string>();
HashSet<string> A2 = A.ToHashSet<string>();
HashSet<string> A3 = A.ToHashSet<string>();

Console.WriteLine("Reuniunea: ");
A1.UnionWith(B);
foreach (string item in A1)
{ Console.WriteLine(item); }

Console.WriteLine("Intersectia: ");
A2.IntersectWith(B);
foreach (string item in A2)
{ Console.WriteLine(item); }

Console.WriteLine("Diferenta: ");
A3.ExceptWith(B);
foreach (string item in A3)
{ Console.WriteLine(item); }