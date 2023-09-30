<?php

//1. Se consideră un şir de caractere. Să se determine raportul dintre numărul vocalelor şi numarul cifrelor din şir. 
//Exemplu: pentru sirul “Ionel are 10 lei noi” raportul este 4.
$sir = "Ionel are 10 lei noi";
$numarVocale = preg_match_all("/[aeiou]/i", $sir);
$numarCifre = preg_match_all("/[0-9]/", $sir);
if ($numarCifre > 0) {
    $raport = $numarVocale / $numarCifre;
} else {
    $raport = "Nu există cifre în șir.";
}
echo "Raportul dintre numărul de vocale și numărul de cifre din șir este: $raport";

//2. Se consideră un şir de caractere. Să se determine poziţia primului caracter litera mare din acest şir. 
//Exemplu: pentru sirul “tatal lui Gigel merge la Metrou” se va afisa 10.
$sir = "tatal lui Gigel merge la Metrou";
$pozitie = -1; 
for ($i = 0; $i < strlen($sir); $i++) {
    $caracter = $sir[$i];
    if (ctype_upper($caracter)) {
        $pozitie = $i + 1; 
        break; 
    }
}
echo "Poziția primei litere mari în șir este: $pozitie";

//3. Se consideră un şir de caractere. Să se afişeze numărul vocalelor aflate pe poziţii impare în şirul dat. 
//Exemplu: pentru sirul “mama spala vase” numarul cerut este 4.
function nrVocalePozImpare($sir) {
    $vocale = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
    $numarVocale = 0;
    for ($i = 1; $i < strlen($sir); $i += 2) {
        if (in_array($sir[$i], $vocale)) {
            $numarVocale++;
        }
    }
    return $numarVocale;
}
$sir = "mama spala vase";
$numarVocaleImpare = nrVocalePozImpare($sir);
echo "Numărul de vocale aflate pe poziții impare în șir este: $numarVocaleImpare";

//4. Se consideră un şir de caractere. Să se determine poziţia ultimului caracter cifră din acest text. 
//Exemplu: pentru sirul “2+3 fac cinci” se afiseaza 2.
function ultimaCifra($sir) {
    $ultimaCifra = false;
    for ($i = strlen($sir) - 1; $i >= 0; $i--) {
        if (is_numeric($sir[$i])) {
            $ultimaCifra = $i;
            break;
        }
    }
    return $ultimaCifra;
}
$sir = "2+3 fac cinci";
$pozitieUltimaCifra = UltimaCifra($sir);
echo "Poziția ultimei cifre în șir este: $pozitieUltimaCifra";

//5. Se consideră un şir de caractere format doar din litere. Să se determine procentul literelor mari din acest şir. 
//Exemplu: pentru sirul „euMERg” se afiseaza 50%.
function procentLitereMari($sir) {
    $lungime = strlen($sir);
    $numarLitereMari = 0;
    for ($i = 0; $i < $lungime; $i++) {
        if (ctype_upper($sir[$i])) {
            $numarLitereMari++;
        }
    }
    if ($lungime > 0) {
        $procent = ($numarLitereMari / $lungime) * 100;
    } else {
        $procent = 0;
    }
    return $procent;
}
$sir = "euMERg";
$procentLitereMari = procentLitereMari($sir);
echo "Procentul literelor mari în șir este: $procentLitereMari%";

//6. Se consideră un şir de caractere S şi două caractere C1 şi C2. Să se verifice dacă numărul de apariţii ale caracterului C1 în S este egal cu numărul de apariţii ale caracterului C2 în S. Exemplu: pentru sirul S= “aurul alb“ şi C1=’a’, C2=’u’ se afiseaza “Da”.
function verificaAparitii($sir, $c1, $c2) {
    $numarAparitiiC1 = substr_count($sir, $c1);
    $numarAparitiiC2 = substr_count($sir, $c2);
    if ($numarAparitiiC1 == $numarAparitiiC2) {
        return "Da";
    } else {
        return "Nu";
    }
}

//7. Fie Text un şir de caractere, care conţine litere din alfabetul englez, spaţii şi semne ortografice şi de punctuaţie.Se consideră şi numărul natural K, 1<=K<=20. Şirul va fi criptat după următorul algoritm: fiecare caracter literă va fi înlocuit cu caracterul aflat peste K poziţii în codul ASCII. Scrieţi funcţii pentru criptarea şi decriptarea unui text folosind algoritmul de mai sus. Exemplu: pentru şirul Text=“acasa” şi K=1 şirul criptat este ”bdbtb”.

//8. Se consideră un număr natural N, 1<=N<=26. Să se afişeze primele N linii din piramida următoare:
//A
//B B
//C C C
//D D D D

//9. Şirul de caractere Adrese conţine o listă de adrese e-mail separate prin virgulă, unele adrese putându-se repeta. Să se afişeze o lista a adreselor distincte două câte două, ordonate alfabetic.
function adreseDistincte($adrese) {
    $adreseArray = explode(',', $adrese);
    $adreseArray = array_map('trim', $adreseArray);
    $adreseUnice = array_unique($adreseArray);
    sort($adreseUnice);
    return $adreseUnice;
}
//10. Şirul de caractere Adrese conţine o listă de adrese e-mail separate prin virgulă, unele adrese putându-se repeta. O adresă e-mail are forma: nume_utilizator@nume_server . Să se determine numele serverului e-mail ce găzduieşte cele mai multe conturi e-mail, precum şi numele de utilizator folosit cel mai des.

//11. Se consideră un text în care cuvintele sunt separate prin spaţiu, virgulă, punct, punct şi virgulă, semnul întrebării şi semnul exclamării. Să se extragă toate cuvintele din text şi să se afişeze în ordinea crescătoare a lungimii. Cuvintele de aceeaşi lungime vor fi ordonate alfabetic.

//12. Salariile obţinute de către angajaţii unei firme sunt memorate într-un tablou asociativ în care elementele au drept cheie numele unui angajat, iar ca valoare suma primită ca indemnizaţie. Să se determine salariul minim, salariul maxim, lista angajaţilor care primesc salariul cel mai mic, precum şi lista angajaţilor care primesc suma cea mai mare.
function informatiiSalarii($salarii) {
    $salariuMinim = min($salarii);
    $salariuMaxim = max($salarii);
    $angajatiSalariuMinim = array_keys($salarii, $salariuMinim);
    $angajatiSalariuMaxim = array_keys($salarii, $salariuMaxim);

    echo "Salariul minim este: $salariuMinim\n";
    echo "Salariul maxim este: $salariuMaxim\n";
    echo "Lista angajaților cu salariul minim: " . implode(', ', $angajatiSalariuMinim) . "\n";
    echo "Lista angajaților cu salariul maxim: " . implode(', ', $angajatiSalariuMaxim);
}

$salarii = [
    "Angajat1" => 2000,
    "Angajat2" => 1800,
    "Angajat3" => 2200,
    "Angajat4" => 2200,
];
informatiiSalarii($salarii);

//13. Fie S un şir de caractere şi X un număr natural nenul mai mic decât lungimea şirului S. Construiţi un tablou T în care fiecare element conţine câte X caractere din şirul S, astfel: T[0] conţine caracterele S[0], S[1],...S[X-1], T[1] conţine următoarele X caractere, e.t.c. Ultimul element din T conţine caracterele rămase.

/*14. Şirul de caractere S conţine mai multe ecuaţii de gradul 1 cu coeficienţi întregi, separate prin virgulă. Elementele unei ecuaţii pot fi separate prin unul sau mai multe spaţii. Să se determine soluţia pentru fiecare ecuaţie. Se va utiliza o funcţie definită de utilizator, care să determine soluţia unei ecuaţii de gradul 1 dată prin specificarea coeficienţilor acesteia. Pentru şirul
S=”2x+4=0, x-2=0, -3x-6=0, 2=0, 0x+0=0” se va afişa:
Ecuaţia 1 are soluţia: -2
Ecuaţia 2 are soluţia: 2
Ecuaţia 3 are soluţia: -2
Ecuaţia 4 are soluţia: nu are soluţie
Ecuaţia 5 are soluţia: x aparţine lui R
*/