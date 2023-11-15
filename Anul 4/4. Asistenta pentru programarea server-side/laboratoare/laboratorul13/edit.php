<?php
    include 'connect.php';
    if($_SERVER["REQUEST_METHOD"]=="GET"){
        $id=$_GET["id"];

        $sql="SELECT * FROM contact WHERE id=:id";
        $stmt=$conn->prepare($sql);
        $stmt->bindParam(":id",$id);
        $stmt->execute();
        $user=$stmt->fetch(PDO::FETCH_ASSOC);

        if(!$user){
            header("Location:index.php");
        }
       
    }
     if($_SERVER["REQUEST_METHOD"]=="POST"){
            $id=$_POST["id"];
            $nume=$_POST["nume"];
            $prenume=$_POST["prenume"];
            $email=$_POST["email"];
            $telefon=$_POST["telefon"];
            $adresa=$_POST["adresa"];
            $data_nasterii=$_POST["data_nasterii"];
            $compania=$_POST["compania"];
            $pozitia=$_POST["pozitia"];
            $note_aditionale=$_POST["note_aditionale"];
    
            $sql = "UPDATE contact 
            SET nume = :nume, prenume = :prenume, email = :email, telefon = :telefon, adresa = :adresa, data_nasterii = :data_nasterii, compania = :compania, pozitia = :pozitia, note_aditionale = :note_aditionale
            WHERE id = :id";
            $stmt=$conn->prepare($sql);
            $stmt->bindParam(':nume', $nume);
            $stmt->bindParam(':prenume', $prenume);
            $stmt->bindParam(':email', $email);
            $stmt->bindParam(':telefon', $telefon);
            $stmt->bindParam(':adresa', $adresa);
            $stmt->bindParam(':data_nasterii', $data_nasterii);
            $stmt->bindParam(':compania', $compania);
            $stmt->bindParam(':pozitia', $pozitia);
            $stmt->bindParam(':note_aditionale', $note_aditionale);
            $stmt->bindParam(':id',$id);
            $stmt->execute();

            header("Location: index.php");
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <title>Editeaza contact</title>
</head>
<body>
    <div class="container mt-5">
        <h2>Editeaza contact</h2>
        <form action="edit.php" method="POST" class=mb-3>
            <input type="hidden" name="id" value="<?php echo $user['id'];?>">
            <div class="form-row">
                <div class="mb-3">
                    <input type="text" class="form-control" name="nume" value="<?php echo $user['nume']?>">
                </div>
                <div class="mb-3">
                    <input type="text" class="form-control" name="prenume" value="<?php echo $user['prenume']?>">
                </div>
                <div class="mb-3">
                <input type="email" name="email" placeholder="Email" id="email" class="form-control" value="<?php echo $user['email']?>">
                </div>
                <div class="mb-3">
                    <input type="tel" name="telefon" placeholder="Nr. telefon" id="telefon" class="form-control" value="<?php echo $user['telefon']?>">
                </div>
                <div class="mb-3">
                    <input type="text" name="adresa" placeholder="Adresa" id="adresa" class="form-control" value="<?php echo $user['adresa']?>">
                </div>
                <div class="mb-3">
                    <label for="data_nasterii">Data nasterii:</label>
                    <input type="date" id="data_nasterii" name="data_nasterii" value="<?php echo $user['data_nasterii']?>" min="1950-01-01" max="2023-12-31"/>
                </div>
                <div class="mb-3">
                    <input type="text" name="compania" placeholder="Companie" id="compania" class="form-control" value="<?php echo $user['compania']?>">
                </div>
                <div class="mb-3">
                    <input type="text" name="pozitia" placeholder="Pozitie/Ocupatie" id="pozitia" class="form-control" value="<?php echo $user['pozitia']?>">
                </div>
                <div class="mb-3">
                    <input type="text" name="note_aditionale" placeholder="Note aditionale" id="note_aditionale" class="form-control" value="<?php echo $user['note_aditionale']?>">
                </div>
                <div class="mb-3">
                    <button type="submit" class="btn btn-success" >Actualizare</button>
                </div>
            </div>
        </form>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>