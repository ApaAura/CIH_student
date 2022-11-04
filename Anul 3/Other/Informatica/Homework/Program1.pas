var a,b:real;
//varianta 1
function Perimetrul(a:real;b:real):real;
var P:real;
begin
P:=a+a+b+b;
Perimetrul:=P;
end;

function Aria(a:real;b:real):real;
var Ar:real;
begin
Ar:=a*b;
Aria:=Ar;
end;

//varianta 2
function Media(a:real;b:real):real;
var Med:real;
begin
Med:=(a+b)/2;
Media:=Med;
end;

function SumaPatratelor(a:real;b:real):real;
var suma:real;
begin
suma:=a*a+b*b;
SumaPatratelor:=suma;
end;

begin
write('a = '); readln(a);
write('b = '); readln(b);
writeln('Periemtrul = '+Perimetrul(a,b));
writeln('Aria = '+Aria(a,b));
writeln('Media = '+Media(a,b));
writeln('Suma patratelor = '+SumaPatratelor(a,b));
end.