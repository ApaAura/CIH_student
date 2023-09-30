<?php

/*comment*/
//constante
#echo, print

//nu returneaza nimic
echo "learning_php !"."<br>";
//returneaza 1 (true) daca mesajul este afisat cu succes
print "Text_afisat_cu_prinT"."<br>";

#define - CONSTANTE
define('STATUS_PAID', 'paid');
const STATUS_PAID_2 = 'PAID 2';
$paid='PAID_DINAMIC';
define('PAID_'.$paid,$paid);

//$$ face referinta la valoarea !!$oras=localitate
$test = 'oras';
$$test = 'localitate';

echo $test.$oras."<br>";
