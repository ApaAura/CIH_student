<?php
/*Problemă 1: Copierea unui fișier
Scrieți un script PHP care să copieze un fișier existent dintr-un director în altul. Condiție suplimentară: Asigurați-vă că scriptul poate gestiona cazurile în care fișierul de destinație există deja.*/
$source='../dir1/fisier.txt';
$destination='../dir2/fisier.txt';
if (file_exists($source)){
    if(copy($source, $destination)){
        echo "Fisierul a fost copiat cu succes!";
    }else{
        echo "Fisierul nu poate fi copiat !";
    }
}else{
    echo "Asigurati-va ca fisierul exista !";
}
echo "<br/>";

/*Problemă 2: Listarea conținutului unui director
Scrieți un script PHP care să listeze conținutul unui director (fișierele și subdirectoarele) și să afișeze aceste informații într-un format ușor de citit. Condiție suplimentară: Implementați o funcție pentru a afișa ierarhia de directoare și subdirectoare.*/
$arrFiles = [];
$dirPath = "../MyFolder";

$files = scandir($dirPath);
//to delete 
//.
//..
array_shift($files);
array_shift($files);
foreach ($files as $file) {
    $filePath = $dirPath . '/' . $file;
    if (is_file($filePath)||is_dir($filePath)) {
        echo $file . "<br>";
    }
}

/*Problemă 3: Redenumirea unui fișier
Scrieți un script PHP care să permită utilizatorului să redenumească un fișier existent. Afișați un formular care solicită noul nume al fișierului. Condiție suplimentară: Verificați dacă numele noului fișier respectă regulile (de exemplu, să nu conțină caractere speciale sau spații).*/
//rename("task1.txt","task2.txt");

/*Problemă 4: Ștergerea unui fișier sau director
Scrieți un script PHP care să permită utilizatorului să șteargă un fișier sau director selectat. Condiție suplimentară: Adăugați o funcționalitate de confirmare pentru a evita ștergerile accidentale.*/
$sourceRm='../dir3';
if (dir($source)){
    if(rmdir($sourceRM))
    { echo ("$sourceRM successfully removed");}
    else
    {echo ($sourceRM . "couldn't be removed"); }
}else{
    echo "Asigurati-va ca fisierul exista !";
}

/*Problemă 5: Încărcarea și descărcarea fișierelor
Creați o pagină web PHP care să permită utilizatorilor să încarce fișiere pe server și să descarce fișiere existente. Afișați o listă cu fișierele încărcate și oferiți opțiuni pentru descărcare. Condiție suplimentară: Limitați tipurile de fișiere încărcate și verificați dimensiunea fișierelor pentru securitate.
*/

?>