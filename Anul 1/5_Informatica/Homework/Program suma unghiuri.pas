{De la tastatura se citesc doua marimi de unghiuri exprimate in gradde, minute si, respectiv, secunde. Scrieti 
un program ce calculeaza si afiseaza pe ecran suma marimilor celor 2 unghiuri, exprimate la fel in grade, minute si secunde}
var
  gr1, min1, sec1, gr2, min2, sec2, gr3, min3, sec3: integer;

begin
  writeln('dati valoarea unghiului 1:');
  write('grade: '); readln(gr1);
  write('minute: '); readln(min1);
  write('secunde: '); readln(sec1);
  writeln('dati valoarea unghiului 2:');
  write('grade: '); readln(gr2);
  write('minute: '); readln(min2);
  write('secunde: '); readln(sec2);
  
  sec3 := sec1 + sec2;
  if(sec3 >= 60) then begin
    sec3 := sec3 - 60;
    min1 := min1 + 1;
    end;
  min3 := min1 + min2;
  if(min3 >= 60) then begin
    min3 := min3 - 60;
    gr1 := gr1 + 1;
  end;
  gr3 := gr1 + gr2;
  writeln('Suma unghiurilor: ', gr3, ' ', min3, '` ', sec3, '``');
end.