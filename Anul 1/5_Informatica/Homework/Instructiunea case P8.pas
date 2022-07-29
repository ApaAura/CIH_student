program P8;
{PROGRAMEAZĂ! Zilele săptămânii luni, marţi, miercuri, …, duminică sunt
notate prin numerele 1, 2, 3, …, 7. Scrieţi un program care citeşte de la tastatură
numărul x şi afişează pe ecran: denumirea zilei si mesajul “Zi de şcoală”, dacă numărului x îi 
corespunde o zi de şcoală şi mesajul “Zi liberă”, dacă numărului x îi corespunde o zi de odihnă.}
var
  x: integer;

begin
  writeln('Introduceti un numar intreg: '); readln(x);
  case x of
    1: writeln('Luni - zi de scoala');
    2: writeln('Marti - zi de scoala');
    3: writeln('Miercuri - zi de scoala');
    4: writeln('Joi - zi de scoala');
    5: writeln('Vineri - zi de scoala');
    6: writeln('Sambata - zi libera');
    7: writeln('Duminica - zi libera');
  else writeln('Saptamana are doar 7 zile');
  end;
end.