
var k,n:integer;
function DIVI(k:integer; n:integer):integer;
begin
if(n mod k=0) then DIVI:=1
else Divi:=0;
end;

begin
write('n='); readln(n);
write('k='); readln(k);
if(DIVI(k,n)=1) then writeln(n+' este divizor al lui '+k)
else writeln(n+' nu este divizor al lui '+k)
end.