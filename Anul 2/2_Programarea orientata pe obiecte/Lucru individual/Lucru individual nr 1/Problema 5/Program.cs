/*
 Creați clasa Fracție ce va conține două proprietăți:
 Numarator (double)
 Numitor (double)
Definiți pentru clasa respectivă metodele:
 Constructorul cu parametri, fără parametri și de copiere.
 Metoda de citire
 Metoda de afisare
 Rezultat – returnează rezultatul Numărător / Numitor
Creați un obiect utilizând constructorul fără parametri, citiți și afișați datele despre acesta,
Un alt obiect utilizând constructorul cu parametri. Doar afișați datele
Și ultimul – Utilizând constructorul de copiere. Acesta va fi copia primului
obiect creat. Afisați datele despre acesta.
 */
using Problema_5;
Fractie fractiaMea = new Fractie();
fractiaMea.Citire();
fractiaMea.Afisare();
Fractie fractiaTa= new Fractie(15,0);
fractiaTa.Afisare();
Fractie fractiaNoastra=new Fractie(fractiaMea);
fractiaNoastra.Afisare();
Console.ReadKey();