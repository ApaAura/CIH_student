using Problema_1;
List<Angajat> angajati = new List<Angajat>();   
Angajat A1=new Angajat("Hargi", "Teodor", "Relatii cu publicul", 3500);
Angajat A2=new Angajat("Acri", "Ana", "Copywriting", 4500);
Angajat A3 = new Angajat("Dogaru", "Alice", "Design", 2500);
angajati.Add(A1);
angajati.Add(A2);
angajati.Add(A3);
double Max = int.MinValue;
foreach (Angajat item in angajati)
{
    if (item.Salariu>Max)
    {
         Max = item.Salariu;
    }
}
foreach (Angajat item in angajati)
{
    if (item.Salariu==Max)
    {
        item.AfisareDate();
    }
}
