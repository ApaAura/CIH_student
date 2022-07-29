Program P8;
//a) 1 + 3 + 5 + 7 +… și 1·3·5·7·…;
//b) 2 + 4 + 6 + 8 +… și 2·4·6·8·…;
var
  i, n, y, z, a, b: integer;
begin
  writeln('Introduceti un  numar natural: '); readln(n);
  y := 0; a := 0;
  z := 1; b := 1;
  for i := 1 to n do 
  begin
    if(i mod 2 <> 0) then begin
      y :=y + i;
      z :=z * i;
    end;
    if(i mod 2 = 0) then begin
      a :=a+ i;
      b :=b* i;
    end;
  end;
  writeln('a) Suma: ', y, ' Produsul: ', z);
  writeln('b) Suma: ', a, ' Produsul: ', b);
end.



//3+6+9+12+..
var
  i, n, y : integer;
begin
  writeln('Introduceti un  numar natural: '); readln(n);
  y := 0; 
  for i := 1 to n do 
  begin
    if(i mod 2 <> 0) then begin
      y :=y + i;
    end;
  end;
  writeln('a) Suma: ', y);
end.