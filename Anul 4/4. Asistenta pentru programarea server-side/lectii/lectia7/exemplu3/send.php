<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST["username"];
    $checkbox = isset($_POST["checkbox"]) ? "Checked" : "Not Checked";
    $radio_option = $_POST["radio_option"];
    $color = $_POST["color"];
    $date = $_POST["date"];
    
    if ($_FILES["file"]["error"] == 0) {
        $file_name = $_FILES["file"]["name"];
        $temp_file = $_FILES["file"]["tmp_name"];
        move_uploaded_file($temp_file, "uploads/" . $file_name);
    } else {
        $file_name = "No file uploaded.";
    }

    echo "Username: $username<br>";
    echo "Checkbox: $checkbox<br>";
    echo "Radio Option: $radio_option<br>";
    echo "Color: $color<br>";
    echo "Date: $date<br>";
    echo "Uploaded File: $file_name<br>";
}
?>