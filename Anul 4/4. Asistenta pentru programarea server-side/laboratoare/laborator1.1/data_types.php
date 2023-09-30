<?php
 
 # Scalar Types
    #bool - true/false
    $isAdmin=true;
    #int - 1,2,3
    $anul=2023;
    #float - 1.5
    $pret=0.99;
    #string = "Hello World !"
    $name='ica';
    echo $isAdmin."<br>";
    #gettype();
    echo gettype($pret)."<br>";
    echo is_bool($anul);

 # Compound Types
    #array
    //nu afiseaza array cu echo deoarece nu poate converti in string
    $companies=[1, 2, 'true', true];
    print_r($companies);
    #object
    #callable
    #iterable

# Special Types
    #null
    #resource

# Convertion
    #(int) $number= 2;
    #declare(strict_types=1) //pentru a folosi tip de date tipizat
function sum(int $nr1, int $nr2):int{
    return $nr1+$nr2;
}
function sum2(float $nr1, float $nr2):float{
    return $nr1+$nr2;
}
$suma=sum(5,4);
$suma2=suma2(5,4);