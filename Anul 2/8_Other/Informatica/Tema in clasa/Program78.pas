program P1;
{Suma componentelor variabilei x de tip Vector}
{Numar fix de componente}
type
  Vector = array [1..5]of real;

var
  x: Vector;
  i: integer;
  s: real;

begin
  writeln('Dati 5 numere:');
  for i := 1 to 5 do readln(x[i]);
  writeln('Ati introdus: ');
  for i := 1 to 5 do writeln(x[i]);
  s := 0;
  for i:=1 to 5 do s:=s+x[i];
  writeln('Suma=' + s);
  readln;
end.
