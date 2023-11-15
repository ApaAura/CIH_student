<?php
    include 'conexiune.php';
    if($_SERVER["REQUEST_METHOD"]=="POST"){
        $nume=$_POST["nume"];
        $prenume=$_POST["prenume"];
        $varsta=$_POST["varsta"];

        $sql="INSERT INTO utilizatori (nume, prenume, varsta) VALUES (:nume, :prenume, :varsta)";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':nume', $nume);
        $stmt->bindParam(':prenume', $prenume);
        $stmt->bindParam(':varsta', $varsta);
        $stmt->execute();

        header("Location:index.php");
    }
?>