<?php
    //Procedural
    //msqi_connect()

    /*POO
    $server="localhost";
    $user="root";
    $pass= "";
    $db= "blog";

    try {
        //verificam conexiunea
        $conn=new mysqli($server,$user,$pass,$db);
        if ($conn->connect_error) { 
            die("". $conn->connect_error);
        }
    }catch(ErrorException $error){
        die($error);
    }*/

    //POO PDO
    $server="localhost";
    $user="root";
    $pass= "";
    $db= "blog";

    try {   
        //Coexiune
        $conn=new PDO("mysql:host=$server;dbname=$db", $user, $pass);

        //..
        $sql="SELECT*FROM categorii";
        $stm= $conn->prepare($sql);
        $categorii= $stm->fetchAll();
        foreach($categorii as $categorie){
            echo $categorie['nume']."<br/>";
        }

        //Inchidem conexiunea
        $con=null;
    } 
    catch (PDOException $error) {
        die("Eroare: ".$error);
    }
   
?>