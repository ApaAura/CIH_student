Program A5;
var a,b,c,d :integer;
i,j,k,m :real;
sir:string;
caract:char;

{ a) suma numerelor reale a,b,c,d;}
function suma(a:integer;b:integer;c:integer;d:integer) : integer;
var sum:integer;
begin
sum:=0;
sum:=a+b+c+d;
suma:=sum;
end;

{ b) media numerelor intregi a,b,c,d; }
function media(i:real;j:real;k:real;m:real):real;
var med:real;
begin
med:=0;
med:=i+j+k+m;
med/=4;
media:=med;
end;

{ c) minimumul din numerele a, b, c, d;}
function minim(a:integer;b:integer;c:integer;d:integer):integer;
var min:integer;
begin
if a<b then min:=a else min:=b;
if min<c then min:=min else min:=c;
if min<d then min:=min else min:=d;
minim:=min;
end;

{ d) numarul de vocale dintr-un sir de caractere;}
function vocale(sir:string):integer;
var nrvocale:integer;
i:integer;
begin
nrvocale:=0;
for i:=1 to length(sir) do
if sir[i]in ['a','e','i','o','u'] then
nrvocale+=1;
vocale:=nrvocale;
end;

{ e) numarul de consoane dintr-un sir de caractere;}
function consoane(sir:string):integer;
var nrconsoane:integer;
i:integer;
begin
for i:=1 to length(sir)do
if sir[i] in ['q','w','r','t','p','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'] then
nrconsoane+=1;
consoane:=nrconsoane;
end;

{ f) radacina ecuatiei ax+b=0;}
function solutii(a:integer;b:integer): real;
var x:real;
begin
x:=-b/a;
solutii:=x;
end;

{ g) cel mai mic divizor al numarului intreg a>0 diferit de 1;}
function divizor(a:integer):integer;
var divizor:integer;
i:integer;
begin
for i:=2 to a do 
if a mod i=0 then divizor:=i;
end;

{ h) cel mai mare divizor comun al numerelor naturale a,b;}
function cmmdc(a:integer;b:integer):integer;
var cmmd:integer;
begin
while a<>b do
if a>b then a:=a-b else b:=b-a;
cmmdc:=a;
end;

{ j) ultima cifra in notatia zecimala a numarului intreg m>0;}
function ucifra(m:integer):integer;
begin
ucifra:=m mod 10;
end;

{ m) numarul de aparitii ale caracterului dat intr-un sir de caractere;}
function caracter(sir:string; ch:char):integer;
var nr:integer;
i:integer;
begin
for i:=1 to length(sir) do 
if sir[i] in [ch] then nr+=1;
caracter:=nr;
end;

begin
{Introducerea datelor }
writeln('Introduceti date:');
write('a = '); readln(a);
write('b = '); readln(b);
write('c = '); readln(c);
write('d = '); readln(d);
write('i = '); readln(i);
write('j = '); readln(j);
write('k = '); readln(k);
write('m = '); readln(m);
write('Introduceti un sir de caractere: '); readln(sir);
write('Introduceti un caracter: '); readln(caract);
{Apelarea functiilor}
writeln('a) Suma numerelor inroduse: '+suma(a,b,c,d));
writeln('b) Minimul dintre numerele introduse este: '+minim(a,b,c,d));
writeln('c) Media numerelor introduse: '+media(i,j,k,m));
writeln('d) Numarul de vocale din sir: '+vocale(sir));
writeln('e) Numarul de consoane din sir: '+consoane(sir));
writeln('f) Radacina ecuatiei: '+solutii(a,b));
writeln('g) Cel mai mic divizor diferit de 1 al numarului '+a+' : '+divizor(a));
writeln('h) Cel mai mare divizor comun al numerelor naturale '+a+' si '+b+' : '+cmmdc(a,b));
writeln('j) Ultima cifra in notatia zecimala a numarului '+m+' : '+ucifra(a));
writeln('m) Numarul de aparitii ale caracterului '+caract+' intr-un sir: '+caracter(sir, caract));
end.