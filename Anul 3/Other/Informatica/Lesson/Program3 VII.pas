Var sir,inv:string;
      
function inversare(s:string):string;
var n,i:integer;
sir:string;
begin
sir:='';
for i:=length(s) downto 1 do
if s[i]<>' ' then sir:=sir+s[i];
inversare:=sir;
end;
 
Begin
writeln('Introduceti sirul de caractere: '); readln(sir);
writeln('Sirul inversat este: '+inversare(sir));
End.