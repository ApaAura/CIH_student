var r:real;
function Lungimea(r:real):real;
var l:real;
const pi=3.14;
begin
l:=2*pi*r;
Lungimea:=l;
end;

function Aria(r:real):real;
var a:real;
const pi=3.14;
begin
a:=pi*r*r;
Aria:=a;
end;

begin
write('r = '); readln(r);
writeln('Lungimea cercului '+Lungimea(r)+' cm');
writeln('Aria cercului '+Aria(r)+' cm^2');
end.