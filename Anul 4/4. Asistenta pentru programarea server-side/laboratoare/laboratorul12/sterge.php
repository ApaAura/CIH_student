<?php
    include('conexiune.php');
    if($_SERVER["REQUEST_METHOD"]=="GET"){
        $id=$_GET["id"];

        $sql="DELETE FROM utilizatori WHERE id=:id";
        $stmt=$conn ->prepare($sql);
        $stmt->bindParam(":id",$id);
        $stmt->execute();
        header("Location: index.php");
    }
?>