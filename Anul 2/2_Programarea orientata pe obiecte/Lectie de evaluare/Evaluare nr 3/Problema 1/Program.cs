using Problema_1;
List <Angajat> angajati=new List <Angajat> ();
TeamLeader T1=new TeamLeader ();
DataScientist D1=new DataScientist ();
T1.Citire();
angajati.Add (T1);
D1.Citire();
angajati.Add(D1);
double SalariuMax = 0;
foreach (Angajat item in angajati)
{
    if (item.Salariu>SalariuMax)
    {
        SalariuMax = item.Salariu;
    }
}
foreach (Angajat item in angajati)
{
    if (item.Salariu==SalariuMax)
    {
        item.Info();
    }
}