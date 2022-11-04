Var sir,inv:string;
      
function Inversare(sir:string):string;
var  i:integer;
begin
inv:='';
for i:=1 to Length(sir) do
begin
inv:=sir[i]+inv;
end;
Inversare:=sir;
end;
 
Begin
writeln('Introduceti sirul de caractere: '); readln(sir);
writeln('Sirul inversat este: '+Inversare(sir));
End.