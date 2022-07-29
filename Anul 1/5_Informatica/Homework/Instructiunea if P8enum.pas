program P8;
{Denumirea zilelor saptamanii sunt codificate in urmatorul mod. Scrieti un program ce 
citeste de la tastatura nnumarul corespunzator fiecarei zil, cu ajutorul tipului de date enumerare.}
type
  Zile = (Null, Luni, Marti, Miercuri, Joi, Vineri, Sambata, Duminica);
var
  x: integer;
  Z: Zile;
begin
  writeln('Introduceti un numar de la 1 la 7: '); readln(x);
  if (x = 1) then z := Zile.Luni
  else
    if(x = 2) then z := Zile.Marti
    else
      if(x = 3) then z := Zile.Miercuri
      else
        if(x = 4) then z := Zile.Joi
        else
          if(x = 5) then z := Zile.Vineri
          else
            if(x = 6) then z := Zile.Sambata
            else 
              if(x = 7) then z := Zile.Duminica
              else
                if ((x > 7) or (x < 1)) then writeln('Din pacate saptamana are doar 7 zile');
  if (z <> Zile.Null) then Writeln(z);
end.