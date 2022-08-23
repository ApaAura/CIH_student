using Problema_3;
Fractie fractiaMea = new Fractie();
fractiaMea.Citire();
fractiaMea.Afisare();
Fractie fractiaTa = new Fractie(15, 0);
fractiaTa.Afisare();
Fractie fractiaNoastra = new Fractie(fractiaMea);
fractiaNoastra.Afisare();
Console.ReadKey();