using Problema_1;
Grupa grupa1 = new Grupa();
grupa1.Nume = "AAW2022";
grupa1.Elevi.Add(new Elev { Nume = "Ivanov", Prenume = "Dorin" });
grupa1.Elevi.Add(new Elev { Nume = "Acciu", Prenume = "Eugen" });
grupa1.Elevi.Add(new Elev{ Nume = "Noni", Prenume = "Silviu" });

Grupa grupa2 = new Grupa();
grupa2.Nume = "PAPP2021";
grupa2.Elevi.Add(new Elev{Nume = "Rumeus", Prenume = "Dumitru" });
grupa2.Elevi.Add(new Elev{Nume = "Perju", Prenume = "Alexandru" });
grupa2.Elevi.Add(new Elev{Nume = "Radu", Prenume = "Andrei" });

Grupa grupa1Grupa2 = grupa1 + grupa2;
Console.WriteLine("Grupa rezultata: ");
Console.WriteLine("Nume: " + grupa1Grupa2.Nume); 
Console.WriteLine("Elevi: ");
foreach (Elev elev in grupa1Grupa2.Elevi)
{
    Console.WriteLine(elev.Nume + " " + elev.Prenume);
}
