<?php

session_start();
$email="john.doe@gmail.com";
$password="1234";

$emailPost=$_POST['email'];
$passwordPost=$_POST['password'];
if($email==$emailPost && $passwordPost==$password){
    $_SESSION['id']=154;
    $_SESSION['user_email']=$email;
    $_SESSION['user_name']="John Doe";
    header("location:control.php");
}else{
    header("location:index.php");
}