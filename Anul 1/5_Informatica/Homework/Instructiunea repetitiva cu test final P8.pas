program P8;
{APLICĂ! Elaboraţi un program care citeşte de la tastatură o secvenţă de caractere şi afişează pe ecran:
a) numărul literelor citite;
b) numărul literelor mari;
c) numărul literelor mici.
Sunt admise literele mari şi mici ale alfabetului latin şi caracterul * care indică sfârşitul secvenţei.}
var
  text: string;
  i, litMari, litMici: integer;
begin
  repeat
    begin
      litMari := 0;
      litMici := 0;
      writeln('Introduceti o secventa de caractere: '); readln(text); 
      if text <> '*' then begin
        for i := 1 to Length(text) do 
        begin
          if (text[i] <> LowerCase(text[i])) 
          then 
            litMari := litMari + 1
          else 
            litMici := litMici + 1;
        end;
        writeln('In secventa de caractere sunt ' + Length(text));
        writeln('In secventa de caractere sunt ' + litMari + ' majuscule');
        writeln('In secventa de caractere sunt ' + LitMici + ' minuscule');
      end;
    end;
  until text = '*';
end.