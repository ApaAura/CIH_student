<?php
    $username="johndoe";    
    $password="123456";
    $usernamePost=$_POST['username'];
    $passwordPost=$_POST['password'];
    if($username===$usernamePost && $password===$passwordPost){
        header(header: "location:index.php?login=succes");
    }else{
        header(header: "location:index.php?login=fail");
    }
?>
<p><?=$username?></p>