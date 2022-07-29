program P10;
{Se considera 3 segmente de dreapta cu lungimile a,b,c. Scrieti un program
care verifica daca din aceste segmente poate fi construit un triunghi. In caz afirmativ 
programul va afisa tipul triunghiului si aria acestuia.}
var
  a, b, c, sp, aria: real;

begin
  write('a='); readln(a);
  write('b='); readln(b);
  write('c='); readln(c);
  {Verificam daca segmentele formeza triunghi}
  if(not((a + b > c) and (a + c > b) and (b + c > a))) then 
    writeln('Segmentele nu formeza triunghi')
  else begin
    sp := (a + b + c) / 2;
    aria := sqrt(sp * (sp - a) * (sp - b) * (sp - c));
    {Verificam tipul triughiului}
    if((a = b) and (b = c)) then
      write('Triunghiul este echilateral, Aria= ', aria)
    else
    if((a <> b) and (b <> c)) then
      write('Triunghiul este scalen, Aria= ', aria)
      else
    if(((a = b) and (b <> c)) or ((a = c) and (c <> b)) or ((c = b) and (b <> a))) then
      write('Triunghiul este isoscel, Aria= ', aria)
  end;
end.