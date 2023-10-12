<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php require('error.php');?>
    <form action="./send.php" method="post">
        <label for="username">Username</label>
        <input type="username" name="username" id="username"><br/>
        <label for="password">Password</label>
        <input type="password" name="password" id="password"><br/>
        <button type="submit">Send</button>
    </form>
</body>
</html>