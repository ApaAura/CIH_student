<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!--checkbox radio select file date-->
    <form action="send.php" method="post" enctype="multipart/form-data">
    <label for="username">Username</label>
    <input type="text" name="username" id="username"><br/>

    <label for="checkbox">Checkbox</label>
    <input type="checkbox" name="checkbox" id="checkbox"><br/>

    <label>Radio Buttons</label><br/>
    <input type="radio" name="radio_option" value="option1"> Option 1<br/>
    <input type="radio" name="radio_option" value="option2"> Option 2<br/>

    <label for="select">Select a Color</label>
    <select name="color" id="select">
        <option value="red">Red</option>
        <option value="green">Green</option>
        <option value="blue">Blue</option>
    </select><br/>

    <label for="file">Upload File</label>
    <input type="file" name="file" id="file"><br/>

    <label for="date">Select a Date</label>
    <input type="date" name="date" id="date"><br/>

    <button type="submit">Send</button>
</form>

</body>
</html>