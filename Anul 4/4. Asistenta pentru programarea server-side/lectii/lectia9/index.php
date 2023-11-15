<?php declare(strict_types= 1);
    $server="localhost";
    $user="root";
    $password= "";
    $db= "lectia9";
    $i=1;

    try {   
        class Produs{
            public string $nume;
            public string $decriere;
            public float $pret;
        }
        $connect=new PDO("mysql:host=$server;dbname=$db", $user, $password);
        $st=$connect->query("SELECT*FROM produse");
        echo "<pre>";
        //var_dump($st->fetchAll(PDO::FETCH_CLASS, "Produs"));
        $produse=$st->fetchAll(PDO::FETCH_CLASS, "Produs");
        echo "</pre>";
        $connect=null;
    } 
    catch (PDOException $error) {
        die("Eroare la conexiune !");
    }
    require_once"./produse.php";
?>

