using Problema_2;
List <Persoana> persoane= new List <Persoana>();
Elev Elev = new Elev();
Elev Elev2 = new Elev();
Profesor Profesor = new Profesor();
Profesor Profesor2 = new Profesor();
Elev.Citire();
persoane.Add (Elev);
Elev2.Citire();
persoane.Add(Elev2);
Profesor.Citire();
persoane.Add(Profesor);
Profesor2.Citire();
persoane.Add(Profesor2);
Console.Clear();
Console.WriteLine("Lista tuturor persoanlor : ");
foreach (Persoana item in persoane)
{
    item.Afisare();
}
