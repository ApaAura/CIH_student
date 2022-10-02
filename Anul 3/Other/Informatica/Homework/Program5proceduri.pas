Program P5;
type tablou=array[1..100]of real;
var a,b,c:integer;
sir:string;
x: tablou;
n,i:integer;

{a) calculează rădăcinile ecuaţiei ax2+ bx + c = 0;}
procedure radacini(a:integer;b:integer;c:integer);
var delta,x1,x2:real;
begin
delta:=b*b-4*a*c;
if delta<0 then writeln('Ecuatia nu are solutii reale') else 
if delta=0 then writeln('Ecuatia are o solutie dubla: x1=x2='+-b/2*a) else
writeln('Solutiile ecuatiei sunt : '+(-b-sqr(delta))/2*a+' si '+(-b+sqr(delta))/2*a);
end;

{c) încadrează un șir de caractere între simbolurile „#”;}
procedure incadrare(sir:string);
begin
writeln('#'+sir+'#');
end;

{d) ordonează componentele unui tablou array [1..100] of real în ordine crescătoare;}
procedure ord(n:integer; var x:tablou);
var i,j:integer;
aux:real;
ordonat:boolean;
begin
ordonat:=false;
while not ordonat do 
begin ordonat:=true;
for j:=1 to n-1 do
if x[j]>x[j+1] then
begin 
aux:=x[j];
x[j]:=x[j+1];
x[j+1]:=aux;
ordonat:=false;
end;
end;
end;

begin
{Citirea datelor}
writeln('Introduceti coeicientii ecuatiei:');
write('a = '); readln(a);
write('b = '); readln(b);
write('c = '); readln(c);
write('Introduceti un sir : '); readln(sir);
write('Introduceti un numar n = '); readln(n);
write('Introduceti '+n+' elemente ale tabloului'); 
for i:=1 to n do read(x[i]); 
{Apelarea procedurilor}
radacini(a,b,c);
incadrare(sir);
ord(n,x);
write('Tabloul ordonat crescator: ');
for i:=1 to n do write(x[i]+' '); 
end.
