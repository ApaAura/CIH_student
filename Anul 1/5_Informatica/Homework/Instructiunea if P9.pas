program P9;
{Scrieti un program care calculeaza solutiile ecuatiei patrate.
Numerele reale a,b,c se citesc de la tastatura.}
var
  a, b, c, delta, x1, x2, x3: real;

begin
  write('a='); read(a);
  write('b='); read(b);
  write('c='); read(c);
  delta := b * b - 4 * a * c;
  x1 := (-b - sqrt(delta)) / (2 * a);
  x2 := (-b + sqrt(delta)) / (2 * a);
  x3 := -b / 2 * a;
  if(delta > 0) then 
    write('Ecuatia are 2 solutii distincte: ', x1, ' si ', x2)
  else
  if(delta < 0) then 
    write('Ecuatia nu are solutii.')
  else 
  if(delta = 0) then
    write('Ecuatia are 2 solutii egale:', x3)
end.