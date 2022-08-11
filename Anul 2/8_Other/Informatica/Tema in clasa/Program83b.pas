program P83_b;
{Numarul de spatii intr-un sir de caractere}
var
  S: string;
  i, j: integer;

begin
  writeln('Dati sirul de caractere:');
  repeat
    readln(S);
    i := 0;
    for j := 1 to length(S) do
      if S[j] = ' ' then i := i + 1;
    writeln('Numarul de spatii= ', i);
  until S = 'Sfarsit';
end.