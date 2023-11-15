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

     header("Location: index.php");
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>View profile</title>
    <link rel="stylesheet" href="https://demos.creative-tim.com/notus-js/assets/styles/tailwind.css">
    <link rel="stylesheet" href="https://demos.creative-tim.com/notus-js/assets/vendor/@fortawesome/fontawesome-free/css/all.min.css">
</head>
<body style="background-color: #f8fafc;">
    
<section class="pt-16 bg-blueGray-50">
    <div class="w-full lg:w-4/12 px-4 mx-auto">
    <div class="relative flex flex-col min-w-0 break-words bg-white w-full mb-6 shadow-xl rounded-lg mt-16">
        <div class="px-6">
        <div class="flex flex-wrap justify-center">
            <div class="w-full px-4 flex justify-center">
            <div class="relative">
                <img alt="..." src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzPb_pSj-ir-9eB6mi0lVJdQP1KKHiB8fRBS1CbmOXGd9Z1FEGMJHbEKhahwhWLGSaEXY&usqp=CAU" class="shadow-xl rounded-full h-auto align-middle border-none absolute -m-16 -ml-20 lg:-ml-16 max-w-150-px">
            </div>
            </div>
            <div class="w-full px-4 text-center mt-20">
            </div>
        </div>
        <div class="text-center mt-12">
            <h3 class="text-xl font-semibold leading-normal mb-2 text-blueGray-700 mb-2">
                <?php echo $user['nume'].' '. $user['prenume']?> <br/>
                <span class="text-sm text-blueGray-400 mt-0"><?php echo $user['email']?></span>
            </h3>
            <div class="text-sm leading-normal mt-0 mb-2 text-blueGray-400 font-bold uppercase">
                <i class="fas fa-map-marker-alt mr-2 text-lg text-blueGray-400"></i>
                <?php echo $user['adresa']?>
            </div>
            <div class="mb-2 text-blueGray-600 mt-10">
                <i class="fas fa-briefcase mr-2 text-lg text-blueGray-400"></i>
                <?php echo $user['pozitia']?>
            </div>
            <div class="mb-2 text-blueGray-600">
                <i class="fas fa-university mr-2 text-lg text-blueGray-400"></i>
                <?php echo $user['compania']?>
            </div>
        </div>
        <div class="mt-10 py-10 border-t border-blueGray-200 text-center">
            <div class="flex flex-wrap justify-center">
            <div class="w-full lg:w-9/12 px-4">
                <p class="mb-4 text-lg leading-relaxed text-blueGray-700"> <?php echo $user['note_aditionale']?></p>
                <a href="./index.php" class="font-normal text-pink-500">Go back</a>
            </div>
            </div>
        </div>
        </div>
    </div>
    </div>
</section>
</body>
</html>