using Problema_1;
Console.Write("Introduceti numarul de trapeze : ");
int nr=int.Parse(Console.ReadLine());
List <Trapez_isoscel> trapez =new List<Trapez_isoscel>();
for (int i = 0; i < nr; i++)
{
    Trapez_isoscel trapez_Isoscel = new Trapez_isoscel();
    trapez_Isoscel.Citire();
    trapez.Add(trapez_Isoscel);
}
Console.Clear();
Console.WriteLine("Lista tuturor trapezelor :");
foreach (var item in trapez)
{
    item.Afisare();
}
double Pmax = 0;
double Amax = 0;
Trapez_isoscel maxP = trapez[0];
Trapez_isoscel maxA = trapez[0];
foreach (var item in trapez)
{
    if (item.Perimetrul() > Pmax)
    {
        maxP = item;
    }
    if (item.Aria() > Amax)
    {
        maxA = item;
    }
}
Console.WriteLine("Trapezul cu perimetrul maxim : ");
maxP.Afisare();
Console.WriteLine("Trapezul cu aria maxima : ");
maxA.Afisare();