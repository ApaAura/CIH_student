/*
Elaborați un program care citește de la tastatură o propozitie și afișează la ecran
cuvintele distincte ale propozitiei.
Notă: Propoziția conține cuvinte separate prin spațiu, alți separatori nu se vor
folosi. La sfârșitul propozitiei nu se pune punct.
De exemplu:
Date de intrare: Aceasta zi este o zi de laborator zi pe care o astept cu
nerabdare
Date de ieșire:
Aceasta
zi
este
o
de
laborator
pe
care
astept
cu
nerabdare
 */

HashSet<string> setCuvinte=new HashSet<string>();
Console.WriteLine("Introduceti un sir de caractere: ");
string propozitie=Console.ReadLine();
string[] cuvinte = propozitie.Split(' ',',');
foreach (string element in cuvinte)
{
    setCuvinte.Add(element);
}
Console.Clear();
Console.WriteLine("Cuvintele distincte din propozitie sunt: ");
foreach (string element in setCuvinte)
{
    Console.WriteLine(element);
}