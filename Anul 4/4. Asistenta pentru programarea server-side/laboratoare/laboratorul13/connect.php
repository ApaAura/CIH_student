<?php
$server = "localhost";
$user = "root";
$pass = "";
$db = "contacts";


try {
    $conn = new PDO("mysql:host=$server;dbname=$db", $user, $pass);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $con=null;
} catch (PDOException $th) {
    die("Eroare:". $th->getMessage());
}