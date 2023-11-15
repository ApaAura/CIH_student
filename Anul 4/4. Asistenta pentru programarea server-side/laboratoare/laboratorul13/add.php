<?php
    include 'connect.php';
    if($_SERVER["REQUEST_METHOD"]=="POST"){
        $nume=$_POST["nume"];
        $prenume=$_POST["prenume"];
        $email=$_POST["email"];
        $telefon=$_POST["telefon"];
        $adresa=$_POST["adresa"];
        $data_nasterii=$_POST["data_nasterii"];
        $compania=$_POST["compania"];
        $pozitia=$_POST["pozitia"];
        $note_aditionale=$_POST["note_aditionale"];

        $sql = "INSERT INTO contact (nume, prenume, email, telefon, adresa, data_nasterii, compania, pozitia, note_aditionale) VALUES (:nume, :prenume, :email, :telefon, :adresa, :data_nasterii, :compania, :pozitia, :note_aditionale)";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':nume', $nume);
        $stmt->bindParam(':prenume', $prenume);
        $stmt->bindParam(':email', $email);
        $stmt->bindParam(':telefon', $telefon);
        $stmt->bindParam(':adresa', $adresa);
        $stmt->bindParam(':data_nasterii', $data_nasterii);
        $stmt->bindParam(':compania', $compania);
        $stmt->bindParam(':pozitia', $pozitia);
        $stmt->bindParam(':note_aditionale', $note_aditionale);
        $stmt->execute();

        header("Location:index.php");
    }
?>