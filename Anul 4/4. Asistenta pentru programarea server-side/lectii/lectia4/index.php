<?php
declare(strict_types=1);
//1. Creați o variabilă pentru fiecare tip de date în PHP (integer, float, string, boolean) și atribuiți-le valori.
$x= (int)5;
$y= (float)5.0;
$z= (string)"Hello world";
$q= (bool) true;

//2. Declarați o variabilă și afișați tipul de date al acelei variabile.
var_dump($q);
echo "<br>";
echo "Ex2 ".gettype($y);

//3. Declarați o variabilă de șir de caractere și afișați lungimea acestui șir.
$sir= (string)"Asistenta pentru programarea client-side";
echo "<br>";
echo "Lungimea: ".strlen($sir);

//4. Combinați două șiruri de caractere diferite într-unul singur și afișați rezultatul.
$part1="Asistenta pentru ";
$part2="programarea client-side";
echo "<br>";
echo $part1.$part2;

//5. Declarați un tablou cu 5 elemente și afișați-l folosind o buclă for.
$numbers=[1,2,3,4];
echo "<br>";
echo "Elementele masivului:";
for($i=0; $i<sizeof($numbers);$i++){
    echo "$numbers[$i] ";
}
//count(), sizeof()

//6. Adăugați un element nou în tablou și afișați tabloul actualizat.
$tablou = array("element1", "element2", "element3");
$elementNou = "elementNou";
$tablou[] = $elementNou;
print_r($tablou);
echo "<br>";

//7. Găsiți cea mai mare valoare dintr-un tablou de numere întregi.
$max= (int) $numbers[0]; 
for($i=1; $i<sizeof($numbers);$i++){
    if($max<$numbers[$i]){
        $max=$numbers[$i];
    }
}
echo "<br>";
echo "Elementul maxim: ".$max;
echo "<br>";

//8. Creați o funcție care să primească două numere întregi ca argumente și să returneze suma lor.
function Sum(int $x, int $y):int{
    return $x+$y;
}
echo "Suma: ".Sum(4,4);
echo "<br>";

//9. Creați o funcție care să verifice dacă un șir de caractere conține un anumit cuvânt.
function checkText($text, $cuvant){
    if(strpos($text, $cuvant)!==false){
        return true;
    }else
    {
        return false;
    }
}
$text="Text de verificat";
$cuvant="de";
if(checkText($text, $cuvant)){
    echo"Textul contine cuvantul '$cuvant'";
    echo "<br>";
}else
{
    echo"Textul nu contine cuvantul '$cuvant'";
    echo "<br>";
}

//10. Creați o funcție care să inverseze un șir de caractere.
function reverseString($text){
    return strrev($text);
}
$textOriginal="Text de inversat";
echo reverseString($textOriginal);

//11. Declarați un tablou asociativ cu numele, vârsta și orașul unei persoane și afișați informațiile.
$persoana = array(
    "nume" => "John Doe",
    "varsta" => 30,
    "oras" => "New York"
);

echo "Nume: " . $persoana["nume"] . "<br>";
echo "Vârsta: " . $persoana["varsta"] . "<br>";
echo "Oraș: " . $persoana["oras"];

//12. Creați o funcție care să sorteze un tablou de numere în ordine descrescătoare.
function sortDesc($array) {
    arsort($array);
    return $array;
}
$numere = [5, 2, 9, 1, 5, 6];
$rezultat = sortDesc($numere);
echo $rezultat;

//13. Creați o funcție care să primească un număr și să verifice dacă este par sau impar.
function estePar($numar) {
    if ($numar % 2 === 0) {
        return "Numărul $numar este par.";
    } else {
        return "Numărul $numar este impar.";
    }
}

//14. Creați un script care să genereze un număr aleatoriu între 1 și 100 și să permită utilizatorului să ghicească numărul.
$numarSecret = rand(1, 100);
$incercari = 0;

while (true) {
    $incercari++;

    echo "Introduceți un număr: ";
    $guess = intval(fgets(STDIN)); // Citim intrarea utilizatorului

    if ($guess < 1 || $guess > 100) {
        echo "Vă rugăm să introduceți un număr între 1 și 100.\n";
        continue;
    }

    if ($guess < $numarSecret) {
        echo "Numărul introdus este prea mic. Mai încercați!\n";
    } elseif ($guess > $numarSecret) {
        echo "Numărul introdus este prea mare. Mai încercați!\n";
    } else {
        echo "Felicitări! Ați ghicit numărul secret $numarSecret în $incercari încercări.\n";
        break;
    }
}
//15. Creați o funcție care să primească un tablou de numere și să calculeze media aritmetică a acestora.
function mediaAritmetica($numere) {
    if (count($numere) === 0) {
        return array_sum($numere) / count($numere);
    }else {
        return 0;
    }
}
//17. Creați un script care să primească un șir de numere întregi și să returneze același șir, dar cu numerele sortate în ordine crescătoare.
function sortareSir($sir) {
    $numere = explode(" ", $sir);
    sort($numere);
    $sirSortat = implode(" ", $numere);
    return $sirSortat;
}
//18. Implementați o funcție care să primească două tablouri și să returneze unul nou care să conțină doar elementele comune între cele două tablouri.
function elementeComune($tablou1, $tablou2) {
    $elementeComune = array_intersect($tablou1, $tablou2);
    return $elementeComune;
}
//19. Creați un program care să primească un număr și să verifice dacă este un număr palindrom (adică se citește la fel de la stânga la dreapta și de la dreapta la stânga, de exemplu, 121 sau 1331).
function estePalindrom($numar) {
    $numarString = strval($numar);
    $invers = strrev($numarString);
    if ($numarString === $invers) {
        return true;
    } else {
        return false;
    }
}
?>