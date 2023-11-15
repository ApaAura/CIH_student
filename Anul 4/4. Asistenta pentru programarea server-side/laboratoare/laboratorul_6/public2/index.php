<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>City List</h1>
    <ul>

    <?php
    $json_data = file_get_contents('orase.txt');
    $cities = json_decode($json_data, true); //returns json
    foreach ($cities as $city) {
        echo '<li>' . $city['name'] . ' - Population: ' . $city['population'] . '</li>';
    }
    ?>

    </ul>
</body>
</html>