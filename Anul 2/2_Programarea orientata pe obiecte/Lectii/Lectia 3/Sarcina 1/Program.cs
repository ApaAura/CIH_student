/*
 Creați clasa statică FileWriter ce va avea următoarele metode ce va permite să scrim 
un șir de caractere în fișiere text în două moduri: în format text și în format binar. 
Aceasta va conține două metode:

WriteTextFile(string FilePath, string text)  - Va scri șirul de caractere (text) în 
fisierul identificat prin FilePath în format text.

WriteBinaryFile(string FilePath, string text) – Va scri șirul de caractere (text) în
fisierul identificat prin FilePath în format binar.

Utilizați-vă de membrii statici ai clasei pentru a scri într-un fișier orice text doriți voi. 
 */


using Sarcina_1;

FileWriter.WriteTextFile(@"D:/myFile.txt", "Eu sunt Aura");
FileWriter.WriteBinaryFile(@"D:/myFile.bin", "Eu sunt Aura");
Console.WriteLine("Datele au fost inscrise cu succes\n yey :D");
