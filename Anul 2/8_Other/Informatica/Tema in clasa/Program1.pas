Program P1;
const pi=3.14;
var r, p, a : real;
begin
write('Raza cercului : '); read(r);
p:=2*pi*r;
a:=sqr(pi)*r;
writeln('Perimetrul cercului :',p,' cm');
writeln('Aria cercului :',a,' cm^2');
end.