program P83_a;
{Siruri de caractere de tip string}
type
  Nume = string[8];
  Prenume = string[5];
  NumePrenume = string;

var
  N: Nume;
  P: Prenume;
  NP: NumePrenume;
  L: integer;

begin
  N := 'Munteanu'; L := length(N); writeln(N, L:4);
  P := 'Mihai'; L := length(P); writeln(P, L:4);
  NP := N + ' ' + P; L := length(NP); writeln(NP, L:4);
  N := 'Olaru'; L := length(N); writeln(N, L:4);
  P := 'Ion'; L := length(P); writeln(P, L:4);
  NP := N + ' ' + P; L := length(NP); writeln(NP, L:4);
  readln;
end.