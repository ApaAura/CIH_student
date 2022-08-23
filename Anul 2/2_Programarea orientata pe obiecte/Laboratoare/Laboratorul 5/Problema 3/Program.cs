using Problema_3;
Console.WriteLine("Numarul de apartamente spre vanzare : ");
int n = int.Parse(Console.ReadLine());
List<AnuntApartament> anuntApartament=new List<AnuntApartament>();
for (int i = 0; i < n; i++)
{
    AnuntApartament A = new AnuntApartament();
    A.CitireDate();
    anuntApartament.Add(A);
}
double Max = 0;
AnuntApartament apartamentMax=new AnuntApartament();
for (int i = 0; i < n; i++)
{
    if (Max<anuntApartament[i].Pret)
    {
        Max = anuntApartament[i].Pret;
        apartamentMax = anuntApartament[i];
    }
}
Console.WriteLine("Cel mai scump apartament : ");
apartamentMax.AfisareDate();
Console.ReadKey();