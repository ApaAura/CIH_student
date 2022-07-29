{REZOLVĂ! Utilizând instrucţiunea while, scrieţi un program care citeşte de
la tastatură numărul natural nenul N şi afişează pe ecran:
a) ultima cifră a numărului N;
b) prima cifră a numărului N;
c) suma cifrelor numărului N;
d) produsul cifrelor numărului N;}
var
  n, x,first, last, suma, produs: integer;
begin
  writeln('Introduceti un numar natural: '); readln(n);
  suma := 0;
  produs := 1;
  first := 0;
  last := 0;
  while(n <> 0) do 
  begin
    x := n mod 10;
    IF (last=0) then last:=x;
    first:= x;
    suma += x;
    produs *= x;
    n:=n div 10;
  end;
  writeln('a) Ultima cifra a numarului este ', last );
  writeln('b) Prima cifra a numarului este ', first );
  writeln('c) Suma cifrelor numarului este ', suma );
  writeln('d) Produsul cifrelor numarului este ', produs );
end.