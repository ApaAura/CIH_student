Program P1;
var n:integer;
sir:string;

{calculează suma S(n) = 1 + 3 + 5 + ... + (2n – 1)}
function suma(n:integer): integer;
begin
if n=1 then suma:=1
else suma:=suma(n-1)+(2*n-1);
end;

{calculează produsul P(n) = 1 * 4 *7 * ... *(3n – 2)}
function produs1(n:integer) :integer;
begin
if n=1 then produs1:=1
else produs1:=produs1(n-1)*(3*n-2);
end;

{inversează un șir de caractere}
function inversare(sir:string):string;
var lungime, i:integer;
aux: char;
begin
lungime:=Length[sir];
for i:=0 to n-1 do
aux:=sir[i];
sir[i] :=sir[lungime-i-1];
sir[lungime-i-1]:=aux;
end;

{calculează produsul P(n) = 2 * 4 * 6 * ... * 2n}
function produs2(n:integer):integer;
begin
if n=1 then produs2:=1
else if n=2 then produs2:=2 else
produs2:=produs2(n-1)*(2*n);
end;

begin
writeln('Introduceti un numar: '); readln(n);
writeln('Introduceti un sir de caractere'); readln(sir);
writeln('a) '+suma(n));
writeln('b) '+produs1(n));
writeln('c) '+inversare(sir));
writeln('d) '+produs2(n));
end.