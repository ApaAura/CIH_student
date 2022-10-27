Program P11;
var a,b,c:integer;

function TR(a:integer;b:integer;c:integer):integer;
begin
if((a<>b)and(a<>c)and(b<>c)) then TR:=1
else TR:=0;
end;

begin
write('a = '); readln(a);
write('b = '); readln(b);
write('c = '); readln(c);
if(TR(a,b,c)=1) then writeln('Triunghiul este scalen')
else  writeln('Triunghiul nu este scalen');
end.