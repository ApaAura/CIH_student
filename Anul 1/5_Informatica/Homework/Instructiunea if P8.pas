program P8;
{Denumirea zilelor saptamanii sunt codificate in urmatorul mod. Scrieti un program ce 
citeste de la tastatura numarul corespunzator fiecarei zile.}
var
  x: integer;

begin
  writeln('Introduceti un numar de la 1 la 7: '); readln(x);
  if (x = 1) then writeln('Luni')
  else
  if(x = 2) then writeln('Marti')
  else
  if(x = 3) then writeln('Miercuri')
  else
  if(x = 4) then writeln('Joi')
  else
  if(x = 5) then writeln('Vineri')
  else
  if(x = 6) then writeln('Sambata')
  else 
  if(x = 7) then writeln('Duminica')
  else
  if ((x > 7) or (x < 1)) then writeln('Din pacate saptamana are doar 7 zile ');
end.