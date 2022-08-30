using Problema_3;
List<Anunt> anunturi=new List<Anunt>(); 
AnuntAutomobil Anunt1=new AnuntAutomobil();
Anunt1.Citire();
anunturi.Add(Anunt1);
AnuntAutomobil Anunt11 = new AnuntAutomobil();
Anunt11.Citire();
anunturi.Add(Anunt11);
AnuntApartament Anunt2=new AnuntApartament();
Anunt2.Citire();
anunturi.Add(Anunt2);
AnuntApartament Anunt22 = new AnuntApartament();
Anunt22.Citire();
anunturi.Add(Anunt22);
AnuntSmartphone Anunt3=new AnuntSmartphone();
Anunt3.Citire();
anunturi.Add(Anunt3);
AnuntSmartphone Anunt33 = new AnuntSmartphone();
Anunt33.Citire();
anunturi.Add(Anunt33);
Console.Clear();
Console.WriteLine("Lista tuturor anunturilor : ");
Anunt1.Informatii();
Anunt11.Informatii();
Anunt2.Informatii();
Anunt22.Informatii();
Anunt3.Informatii();
Anunt33.Informatii();
Console.WriteLine();
Console.WriteLine("Anuntul cu cele mai scumpe servcii :");
List <Anunt> AnuntPretMax = new List<Anunt>();
double Max = int.MinValue;
foreach (Anunt anunt in anunturi)
{
    if (anunt.Pret > Max)
    {
        Max = anunt.Pret;
    }
}
foreach (Anunt anunt in anunturi)
{
    if (anunt.Pret==Max)
    {
        anunt.Informatii();
    }
}
