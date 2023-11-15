<?php
    include 'conexiune.php';
    if($_SERVER["REQUEST_METHOD"]=="GET"){
        $id=$_GET["id"];

        $sql="SELECT * FROM utilizatori WHERE id=:id";
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
            $varsta=$_POST["varsta"];
            $update_at=date("Y-m-d H:i:s");

            $sql = "UPDATE utilizatori SET nume = :nume, prenume = :prenume, varsta = :varsta WHERE id = :id";
            $stmt=$conn->prepare($sql);
            $stmt->bindParam(':nume',$nume);
            $stmt->bindParam(':prenume',$prenume);
            $stmt->bindParam(':varsta',$varsta);
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
    <title>Editeaza utilizator</title>
</head>
<body>
    <div class="container mt-5">
        <h2>Editeaza Utilizator</h2>
        <form action="editeaza.php" method="POST" class=mb-3>
            <input type="hidden" name="id" value="<?php echo $user['id'];?>">
            <div class="form-row">
                <div class="mb-3">
                    <input type="text" class="form-control" name="nume" value="<?php echo $user['nume']?>">
                </div>
                <div class="mb-3">
                    <input type="text" class="form-control" name="prenume" value="<?php echo $user['prenume']?>">
                </div>
                <div class="mb-3">
                    <input type="number" class="form-control" name="varsta" value="<?php echo $user['varsta']?>">
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