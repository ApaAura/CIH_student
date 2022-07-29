program P9;
//uses crt;
{CREEAZĂ! Scrieţi un program care execută repetitiv următoarele operaţii:
1) Citeşte de la tastatură numerele reale x şi y.
2) Afişează pe ecran un meniu care conţine comenzile ce specifică operaţiile
care trebuie efectuate asupra numerelor x şi y.
3) Citeşte de la tastatură numărul întreg c care indică comanda din meniu,
selectată de utilizator.
4) În funcţie de comanda c, calculează şi afişează pe ecran numărul real r –
rezultatul efectuării operaţiei respective asupra numerelor x şi y.
5) Procesul repetitiv continuă până la introducerea de către utilizator a comenzii
de ieşire din program.}
var
  x, y, c: integer;
  d: boolean;
begin
  d := true;
  while d do 
  begin
    write('Introduceti primul numar:'); readln(x);
    write('Introduceti al doilea numar numar:'); readln(y);
    writeln('Meniul CALCULEAZA:');
    writeln('1.Suma');
    writeln('2.Diferenta');
    writeln('3.Produsul');
    writeln('4.Raportul');
    writeln('5.Iesire');
    Writeln('Introduceti  comanda:'); readln(c);
    case c of
      1: writeln('Suma numerelor este: ', x + y);
      2: writeln('Diferenta numerelor este: ', x - y);
      3: writeln('Produsul numerelor este: ', x * y);
      4: writeln('Raportul numerelor este: ', x / y);
      5: d := false;
    else writeln('Comanda gresita'); 
    end;
  end;
end.