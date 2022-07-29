program P8;
{Scrieţi un program care citeşte de la tastatură n numere întregi şi afişează pe
ecran:
c) suma tuturor numerelor citite de la tastatură;
d) media aritmetică a numerelor citite de la tastatură.}
var
  i, n, x, s: integer; m: real;
begin
  writeln('Introduceti numarul de elemente:'); readln(n);
  writeln('Introduceti elementele:');
  s := 0;
  for i := 1 to n do 
  begin
    readln(x);
    s := s + x;
  end; 
  m := s / n;
  writeln('Suma numerelor: ', s, ' Media numerelor: ', m);
end.