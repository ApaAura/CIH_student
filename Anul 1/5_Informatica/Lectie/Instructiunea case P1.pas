program P5;
var
  x: integer;
begin
  writeln('Introduceti un numar de la tastatura: ');
  writeln('1, 5, 10, 50, 100, 500, 1000');
  readln(x);
  case x of
    1: writeln('I');
    5: writeln('V');
    10: writeln('X');
    50: writeln('L');
    100: writeln('C');
    500: writeln('D');
    1000: writeln('M');
    else writeln('Numarul nu poate fi convertit.')
  end;
end.