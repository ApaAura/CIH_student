<?php
declare(strict_types=1);
function showData($data) {
    foreach ($data as $i => $carte) {
        echo '<div class="shadow-sm p-3 mb-4 bg-white rounded">';
        echo "<h3>Cartea: " . ($i + 1) . "</h3>";
        echo "<p>Titlu: " . $carte["titlu"] . "</p>";
        echo "<p>Autor: " . $carte["autor"] . "</p>";
        echo "<p>Pret: " . $carte["pret"] . "</p>";
        echo "</div>";
    }
}
function sum($data){
    $suma= (int)0;
    foreach ($data as $i => $carte) {
        $suma+=$carte["pret"];
    }
    return $suma;
}
function pretMax($data){
    $pretMaxim=(int)0;
    foreach ($data as $i => $carte) {
        if($carte["pret"]>$pretMaxim){
            $pretMaxim=$carte["pret"];
        }
    }
    return $pretMaxim;
}
function filterBooks($data, $titluCautat) {
    $filtredBooks = [];
    foreach ($data as $carte) {
        if (stripos($carte["titlu"], $titluCautat) !== false) {
            $filtredBooks[] = $carte;
        }
    }
    return $filtredBooks;
}

//optim
function sumShort($data){
    return array_sum(array_column($data, 'pret'));
}
function maxShort($data){
    return max(array_column($data, 'pret'));
}
function filterShort($data, $titluCautat){
    return array_filter($data, function ($carte) use ($titluCautat) {
        return stripos($carte["titlu"], $titluCautat) !== false;
    });
}

$books=[
    [
        "titlu"=>"Atomic Habits",
        "autor"=>"James Clear",
        "pret"=>300
    ],
    [
        "titlu"=>"Million Dollar Habits",
        "autor"=>"Brian Tracy",
        "pret"=>180
    ],
    [
        "titlu"=>"The psichology of Selling",
        "autor"=>"Brian Tracy",
        "pret"=>200
    ],
    [
        "titlu"=>"Maximum achievments",
        "autor"=>"Brian Tracy",
        "pret"=>300
    ],
    [
        "titlu"=>"Think and grow rich",
        "autor"=>"Napoleon Hill",
        "pret"=>250
    ]
];
?>

<!DOCTYPE html>
<html>
<head>
    <style>
        .book h2 {
            margin: 0;
            font-size: 18px;
        }
        .book p {
            margin: 0;
            font-size: 14px;
        }
        .title{
            font-weight:bold;
            margin-left: 10px;
        }
        
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
<div class="container">
    <?php
    echo '<h2 class="title"> Lista cartilor: </h2>';
    showData($books);
    echo '<h2 class="title">Suma pretului tuturor cartilor este : '.sum($books).'</h2>'.'<br>';
    echo '<h2 class="title">Suma pretului tuturor cartilor este : '.sumShort($books).'</h2>'.'<br>';
    echo '<h2 class="title">Carti cu pretul maxim: </h2>';
    foreach ($books as $i => $carte) {
        if($carte["pret"]== pretMax($books)){
            showData([$carte]); 
        }
    }
    $titluCautat = "Atomic";
    $cartiFiltrate = filterBooks($books, $titluCautat);
    $cartiFiltrate2 = filterShort($books, $titluCautat);
    echo '<h2 class="title">Carti cu titlul: '. $titluCautat.'</h2>';
    showData($cartiFiltrate2);
    ?>
</div>

</body>
</html>
