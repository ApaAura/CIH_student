<?php
    session_start();
    if(is_null($_SESSION['user_id'])){
        header("location:index.php");
    }
;
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Control</title>
</head>
<body>
    <h4> Salut <?= $_SESSION['user_name'];?>, ai tot controlul asupra aplicatiei !</h4>
    <a href="logout.php">Logout</a>
</body>
</html>