using Problema_1;
static double DeterminatiVopsea(IFiguraGeometrica figura)
{
    return figura.Aria();
}
var patrat = new Patrat
    { 
     Latura = 40
    };
var cerc = new Cerc
    {
    Raza = 24
    };
Console.WriteLine(DeterminatiVopsea(patrat));
Console.WriteLine(DeterminatiVopsea(cerc));