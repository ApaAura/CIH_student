var n,m:integer;

function IsConsecutive(n:integer; m:integer):integer;
begin
if(n=m-1) then
IsConsecutive:=m+n
else IsConsecutive:=0;
end;

begin
writeln('M = '); read(m);
writeln('N = '); read(n);
writeln(IsConsecutive(m,n));
end.