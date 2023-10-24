<?php  declare(strict_types=1);
    //var_dump($_FILES)
    if(strlen($_FILES['fisiere']['name'][0])>0){
        $path="public/";
        $directory=md5((string)time());
        if(!file_exists($path.$directory)){
            mkdir($path.$directory);
        }
        foreach($_FILES['fisiere']['name'] as $key=>$nume){
            $numeFisier=md5(time().$key);
            $ext=pathinfo($nume, PATHINFO_EXTENSION);
            $numeNou=$path.$directory."/".$numeFisier.$ext;
            move_uploaded_file($_FILES['fisiere']['tmp_name'][$key], $numeNou);
        }
    }
?>