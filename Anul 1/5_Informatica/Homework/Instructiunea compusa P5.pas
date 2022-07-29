{Scrieţi un program care citeşte de la tastatură numărul întreg n, 1 ≤ n ≤ 9, şi
afişează pe ecran “figurile” formate din cifrele 1, 2, 3, …, n, după cum urmează
1
12
123
1234
...
1234...n

123456...n
...
1234
123
12
1}
var
  i, j, n: integer;
begin
  writeln('Introduceti un numar natural:'); readln(n);
  for i := 1 to n do 
  begin
    for j := 1 to i do 
    begin
      write(j);
    end;
    writeln();
  end;
  writeln();
  
  for i := n downto 1 do 
  begin
    for j := 1 to i do 
    begin
      write(j);
    end;
    writeln();
  end;
  writeln();
end.