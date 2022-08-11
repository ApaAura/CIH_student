{ REZOLVĂ! Se consideră următoarele tipuri de date
Elaboraţi un program care citeşte de pe tastatură datele referitoare la n persoane
(n≤50) şi afişează pe ecran:
a) persoanele născute în ziua z a lunii;
b) persoanele născute în luna l a anului;
c) persoanele născute în anul a;
d) persoanele născute pe data z.l.a;
e) persoana cea mai în vârstă;
f) persoana cea mai tânără;
g) vârsta fiecărei persoane în ani, luni, zile;
h) lista persoanelor care au mai mult de v ani;
i) lista persoanelor în ordine alfabetică;
j) lista persoanelor ordonată conform datei naşterii;}

program P6;

uses crt;

type
  Data = record
    Ziua: 1..31;
    Luna: 1..12;
    Anul: integer;
  end;
  
  Persoana = record
    NumePrenume: string;
    DataNasterii: Data;
  end;

var
  i,j, n, z, l, a, op,v: integer;
  ListaPersoane: array [1..50] of Persoana;
  Temp : Persoana;

begin
  writeln('Introduceti numarul de persoane: ');
  readln(n);
  {Citirea datelor persoanelor}
  for i := 1 to n do
  begin
    writeln('______________________________________');
    Write('Numele si Prenumele persoanei ', i, ' :');
    Readln(ListaPersoane[i].NumePrenume);
    Writeln('Data de nastere a persoanei ', i, ' :');
    Write('Ziua : ');
    Readln(ListaPersoane[i].DataNasterii.Ziua);
    Write('Luna : ');
    Readln(ListaPersoane[i].DataNasterii.Luna);
    Write('Anul : ');
    Readln(ListaPersoane[i].DataNasterii.Anul);
  end;
  op := integer.MinValue;
  clrscr();
  while(op <> 0)
  do
  begin
    writeln('==============Meniu==============');
    Writeln('1. persoanele născute în ziua z a lunii');
    Writeln('2. persoanele născute în luna l a anului');
    Writeln('3. persoanele născute în anul a');
    Writeln('4. persoanele născute pe data z.l.a');
    Writeln('5. persoana cea mai în vârstă');
    Writeln('6. persoana cea mai tânără');
    Writeln('7. vârsta fiecărei persoane în ani, luni, zile');
    Writeln('8. lista persoanelor care au mai mult de v ani');
    Writeln('9. lista persoanelor în ordine alfabetică');
    Writeln('10. lista persoanelor ordonată conform datei naşterii');
    Writeln('0  -  iesire');
    Writeln('=================================');
    Write('Introduceti comanda: ');
    Readln(op);
    clrscr();
    case (op) of
      1:
        begin
          writeln('==================Optiunea 1==================');
          writeln('persoanele născute în ziua z a lunii');
          write('ziua lunii dorita: ');
          readln(z);
          writeln('====================================');
          for i := 1 to n do
          begin
            if (ListaPersoane[i].DataNasterii.Ziua = z)
              then
              Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      2:
        begin
          writeln('==================Optiunea 2==================');
          writeln('persoanele născute în luna l a anului');
          write('luna dorita: ');
          readln(l);
          writeln('====================================');
          for i := 1 to n do
          begin
            if (ListaPersoane[i].DataNasterii.Luna = l)
              then
              Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      3:
        begin
          writeln('==================Optiunea 3==================');
          writeln('persoanele născute în anul a');
          write('anul dorit: ');
          readln(a);
          writeln('====================================');
          for i := 1 to n do
          begin
            if (ListaPersoane[i].DataNasterii.Anul = a)
              then
              Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      4:
        begin
          writeln('==================Optiunea 4==================');
          writeln('persoanele născute pe data z.l.a');
          write('ziua lunii dorita: ');
          readln(z);
          write('luna dorita: ');
          readln(l);
          write('anul dorit: ');
          readln(a);
          writeln('====================================');
          for i := 1 to n do
          begin
            if ((ListaPersoane[i].DataNasterii.Anul = a) and (ListaPersoane[i].DataNasterii.Luna = z) and (ListaPersoane[i].DataNasterii.Ziua = z))
              then
              Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      5:
        begin
          writeln('==================Optiunea 5==================');
          writeln('persoana cea mai în vârstă');
          a := integer.MaxValue;
          for i := 1 to n do 
          begin
            if(ListaPersoane[i].DataNasterii.Anul < a) then a := ListaPersoane[i].DataNasterii.Anul;
          end;
          for i := 1 to n do
          begin
            if(ListaPersoane[i].DataNasterii.Anul = a) then Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      6:
        begin
          writeln('==================Optiunea 6==================');
          writeln('persoana cea mai tânără');
          a := integer.MinValue;
          for i := 1 to n do 
          begin
            if(ListaPersoane[i].DataNasterii.Anul > a) then a := ListaPersoane[i].DataNasterii.Anul;
          end;
          for i := 1 to n do
          begin
            if(ListaPersoane[i].DataNasterii.Anul = a) then Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      7:
        begin
          writeln('==================Optiunea 7==================');
          writeln('vârsta fiecărei persoane în ani, luni, zile');
          Writeln('Introduceti data curenta');
          write('ziua lunii curente: ');
          readln(z);
          write('luna curenta: ');
          readln(l);
          write('anul curent: ');
          readln(a);
          for i := 1 to n do
          begin
            Writeln(ListaPersoane[i].NumePrenume, '      ', z - ListaPersoane[i].DataNasterii.Ziua, ' zile ', l - ListaPersoane[i].DataNasterii.Luna, ' luni ', a - ListaPersoane[i].DataNasterii.Anul, ' ani ');
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      8:
        begin
          writeln('==================Optiunea 8==================');
          writeln('lista persoanelor care au mai mult de v ani');
          Write('Introduceti varsta: ');
          readln(v);
          Writeln('Introduceti data curenta');
          write('ziua lunii curente: ');
          readln(z);
          write('luna curenta: ');
          readln(l);
          write('anul curent: ');
          readln(a);
          for i := 1 to n do
          begin
            if(a-ListaPersoane[i].DataNasterii.Anul > v) then
            Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul,'      ', a-ListaPersoane[i].DataNasterii.Anul,' ani');
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      9:
        begin
          writeln('==================Optiunea 9==================');
          writeln('lista persoanelor în ordine alfabetică');
          for i := 1 to n do 
            begin
            for j := 1 to  n-i do 
              begin
                if (ListaPersoane[j].NumePrenume > ListaPersoane[j+1].NumePrenume)
                then begin
                    Temp:= ListaPersoane[j];
                    ListaPersoane[j] := ListaPersoane[j+1];
                    ListaPersoane[j+1]:= Temp;
                end;
            end;
            end;
            
            for i := 1 to n do
          begin
              Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
      10:
        begin
          writeln('==================Optiunea 10==================');
          writeln('lista persoanelor ordonată conform datei naşterii');
          for i := 1 to n do 
            begin
            for j := 1 to  n-i do 
              begin
                if (ListaPersoane[j].DataNasterii.Anul > ListaPersoane[j+1].DataNasterii.Anul)
                then begin
                    Temp:= ListaPersoane[j];
                    ListaPersoane[j] := ListaPersoane[j+1];
                    ListaPersoane[j+1]:= Temp;
                end;
            end;
            end;
            
            for i := 1 to n do
          begin
              Writeln(ListaPersoane[i].NumePrenume, '      ',
                      ListaPersoane[i].DataNasterii.Ziua, '.', ListaPersoane[i].DataNasterii.Luna, '.', ListaPersoane[i].DataNasterii.Anul);
          end;
          writeln('Apasati o tasta penrtu a va intoarce la meniu');
          readln();
          clrscr();
        end;
    end;     
  end;
end.