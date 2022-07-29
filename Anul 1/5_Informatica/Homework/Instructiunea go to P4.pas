Program P74;
 {Eroare}
label 1;
var i : 1..5;
begin
 i:=1;
1: writeln(i);
 i:=i+1;
 goto 1;
end.