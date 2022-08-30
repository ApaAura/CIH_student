using Problema_2;
Console.Write("Introduceti numarul de paralelograme: ");
int nr = int.Parse(Console.ReadLine());
List<Paralelogram> paralelograme = new List<Paralelogram>();
for (int i = 0; i < nr; i++)
{
    Paralelogram P1 = new Paralelogram();
    P1.Citire();
    paralelograme.Add(P1);
}
Console.Clear();
Console.WriteLine("Lista tuturor paralelogramelor :");
foreach (var item in paralelograme)
{
    item.Afisare();
}
double Pmax = 0;
double Amax = 0;
Paralelogram maxP = paralelograme[0];
Paralelogram maxA = paralelograme[0];
foreach (var item in paralelograme)
{
    if (item.Perimetru()>Pmax)
    {
        maxP= item;
    }
    if (item.Aria()>Amax)
    {
        maxA = item;
    }
}
Console.WriteLine("Paralelogramul cu perimetrul maxim : ");
maxP.Afisare();
Console.WriteLine("Paralelogramul cu aria maxima : ");
maxA.Afisare();