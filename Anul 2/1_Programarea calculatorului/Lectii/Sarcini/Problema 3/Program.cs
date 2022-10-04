/*
 Scrieţi un program care citeşte de la tastatură elementele mulţimilor A şi B şi afişează pe ecran:
a) intersecţia mulţimilor A şi B;
b) reuniunea mulţimilor A şi B;
c) diferenţa mulţimilor A şi B;
Mulţimile A şi B sunt formate din literele mari ale alfabetului latin.
 */

HashSet<string> sir=new HashSet<string>();
HashSet<string> sirA = new HashSet<string>();

Console.WriteLine("Introduceti multimea A: ");
string linie = Console.ReadLine();
string[] cuvinte = linie.Split(' ', ',');
foreach (string element in cuvinte)
{
    sir.Add(element);
}

Console.WriteLine("Introduceti multimea B: ");
string linie1 = Console.ReadLine();
string[] cuvinte1 = linie.Split(' ', ',');
foreach (string element in cuvinte)
{
    sirA.Add(element);
}

Console.Clear();
HashSet<string> A1 = sir.ToHashSet<string>();
HashSet<string> A2 = sir.ToHashSet<string>();
HashSet<string> A3 = sir.ToHashSet<string>();

Console.WriteLine("Reuniunea: ");
A1.UnionWith(sirA);
foreach (string item in A1)
{ Console.WriteLine(item);}

Console.WriteLine("Intersectia: ");
A2.IntersectWith(sirA);
foreach (string item in A2)
{ Console.WriteLine(item); }

Console.WriteLine("Diferenta: ");
A3.ExceptWith(sirA);
foreach (string item in A3)
{ Console.WriteLine(item); }