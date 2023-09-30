<?php
// Function which prints "Hello I am Zura"
function hello()
{
    echo 'Hello I am Zura<br>';
}
hello();
hello();
hello();

// Function with argument
function helloParametru($name)
{
   echo "Hello I am $name <br>";
}
helloParametru("John");

// Create sum of two functions
function sum($a, $b)
{
    return $a + $b;
}

echo sum(4,5);
echo sum(9,10);

// Create function to sum all numbers using ...$nums
function suma(...$nums)
{
   $sum = 0;
   foreach ($nums as $num) $sum += $num;
   return $sum;
}
echo suma(1, 2, 3, 4, 6) . "<br>";

//
// Arrow functions
function sumaFn(...$nums)
{
   return array_reduce($nums, fn($carry, $n) => $carry + $n);
}
echo sumaFn(1, 2, 3, 4, 6) . "<br>";

//Functia variabila
$produs = function($a, $b){
    return $a * $b;
};
//Functie variabila -> functie anonima asociativa
$produs1 = fn($a, $b) => $a * $b;

echo $produs(7, 8) . "<br>";
echo $produs1(7, 9) . "<br>";

// Tipuri de date in functii
function sumaType( float $a, float $b):float {
    return $a + $b;
}
echo sumaType(8, 5.87) . "<br>";

function oraseSort(string ...$orase):array{
    (array) $cities = [];
    foreach ($orase as $oras) 
        if (strlen($oras) >= 5) array_push($cities, $oras);
    return $cities;
}
print_r(oraseSort("Chisinau", "Iasi", "Cahul", "Istanbul", "Roma")) . "<br>";

function validateEmail(string $email):bool{
    return filter_var($email, FILTER_VALIDATE_EMAIL);
}

echo validateEmail("jgmail.com");

?>