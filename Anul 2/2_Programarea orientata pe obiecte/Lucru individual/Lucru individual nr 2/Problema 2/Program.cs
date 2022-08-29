using Problema_2;
Console.Write("Numarul de produse alimentare : ");
int n=int.Parse(Console.ReadLine());
Console.Write("Numarul de produse de uz casnic : ");
int m=int.Parse(Console.ReadLine());
List <Produs>produse=new List<Produs>();
for (int i = 0; i < n; i++)
{
    ProdusAlimentar N1=new ProdusAlimentar();
    N1.Citire();
    produse.Add(N1);
}
for (int i = 0;i < m; i++)
{
    ProdusDeUzCasnic M1=new ProdusDeUzCasnic();
    M1.Citire();
    produse.Add(M1);
}
int PretMax = int.MinValue;
foreach (Produs prod in produse)
{
    if (prod.Pret>PretMax)
    {
        PretMax = prod.Pret;
    }
}
foreach (Produs prod in produse)
{
    if (prod.Pret==PretMax)
    {
        prod.afisareInformatii();
    }
}