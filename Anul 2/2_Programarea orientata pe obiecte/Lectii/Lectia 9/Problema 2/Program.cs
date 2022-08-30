using Problema_2;
List <Animal> animale=new List<Animal> ();

Pisica pisicaMea = new Pisica{Porecla = "Barsik"};
animale.Add (pisicaMea);
Pisica pisicaTa = new Pisica { Porecla = "Tom" };
animale.Add (pisicaTa);
Caine caineleMeu = new Caine { Porecla = "Ciarli" };
animale.Add(caineleMeu);
Caine caineleTau = new Caine { Porecla = "Bruno" };
animale.Add(caineleTau);
foreach (Animal animal in animale)
{
    animal.Vorbeste();
}
