<?php

//1. Suma elementelor: Scrieți o funcție care calculează suma tuturor elementelor dintr-un array de numere.
function sumaElementelor($array) {
    return array_sum($array);
}
//2. Produsul elementelor pare: Scrieți o funcție care găsește produsul tuturor elementelor pare dintr-un array de numere.
function produsElementelorPare($array) {
    return array_reduce($array, function ($produs, $element) {
        return $element % 2 === 0 ? $produs * $element : $produs;
    }, 1);
}
//3. Inversarea unui array: Scrieți o funcție care inversează ordinea elementelor dintr-un array dat.
function inverseazaArray($array) {
    return array_reverse($array);
}
//4. Filtrarea elementelor: Scrieți o funcție care elimină toate elementele negative dintr-un array de numere.
function eliminaElementeleNegative($array) {
    return array_filter($array, function ($element) {
        return $element >= 0;
    });
}
//5. Găsirea elementului maxim: Scrieți o funcție care găsește cel mai mare element dintr-un array de numere.
function gasesteElementulMaxim($array) {
    return max($array);
}
//6. Unirea a două array-uri: Scrieți o funcție care combină două array-uri într-unul singur.
function combinaArrayuri($array1, $array2) {
    return array_merge($array1, $array2);
}
//7. Verificarea duplicatelor: Scrieți o funcție care verifică dacă un array conține elemente duplicate și le elimină dacă există.
function eliminaDuplicate($array) {
    return array_unique($array);
}
//8. Căutarea unui element: Scrieți o funcție care caută un element specific într-un array și returnează indicele său sau un mesaj de eroare dacă nu este găsit.
function cautaElement($array, $elementCautat) {
    if (in_array($elementCautat, $array)) {
        return array_search($elementCautat, $array);
    } else {
        return "Elementul nu a fost găsit în array.";
    }
}
//9. Sortarea unui array asociativ: Scrieți o funcție care sortează un array asociativ după cheile sau valorile sale.
function sortareChei($array) {
    ksort($array);
    return $array;
}
function sortareValori($array) {
    asort($array);
    return $array;
}
//10. Intersecția a două array-uri: Scrieți o funcție care găsește elementele comune din două array-uri și le returnează într-un nou array.
function intersectieArrayuri($array1, $array2) {
    return array_intersect($array1, $array2);
}