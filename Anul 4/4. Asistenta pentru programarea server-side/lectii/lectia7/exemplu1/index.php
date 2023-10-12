<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!--
        post - date mari/fisiere/ ascunde datele
        get - date cu capacitate mica, nu ascunde datele
    -->
    <form action="./send.php" method="post">
        <label for="text">Text</label>
        <input type="text" name="text" id="text"><br/>
        <label for="email">Email</label>
        <input type="email" name="email" id="email"><br/>
        <button type="submit">Send</button>
    </form>
</body>
</html>