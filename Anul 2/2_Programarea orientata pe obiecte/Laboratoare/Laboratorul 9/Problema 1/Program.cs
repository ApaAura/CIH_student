using Problema_1;
List <Cladire> cladiri =new List <Cladire> ();
InstitutieDeInvatamant N1=new InstitutieDeInvatamant();
N1.Citire();
cladiri.Add (N1);
Hotel N2=new Hotel();
N2.Citire();
cladiri.Add(N2);
Spital N3=new Spital();
N3.Citire();
cladiri.Add(N3);

double pretMaxim = 0;
Cladire cladirePretMax = new Cladire();

foreach (Cladire cladire in cladiri)
{
    if (cladire.Pret > pretMaxim)
    {
        pretMaxim = cladire.Pret;
        cladirePretMax = cladire;
    }
}
Console.WriteLine($"Cladirea cu pretul maxim de constructie: {cladirePretMax.Nume}");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("\nMaterialele necesare pentru a construi cladirile:");
foreach (Cladire cladire in cladiri)
{
    Console.WriteLine(cladire.Nume);
    cladire.Materiale();
    Console.WriteLine();
}

