<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <style>
        td{
            padding: 0!important;
        }
        .cell{
            width: 50px;
            height: 50px;
            display: flex;
            justify-content: center;
            align-items: center;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-12 pt-3">
                <div class="p-3 border">
                    <h3 class="py-2">Laborator 2</h3>
                    <h4>Culegere de probleme</h4>
                </div>
                <div class="bg-light border p-3">
                    <p class="h5 py-2">1. Elaborati un program in limbajul PHP astfel încât să inverseze toate cuvintele dintr-un șir dat:</p>
                    <p class="text-monospace"><b>Exemplu:</b> The greatest victory is that which requires no battle -> battle no requires which that is victory greatest The</p>
                    <?php
                        $inputString = "The greatest victory is that which requires no battle";
                        $words = explode(" ", $inputString);
                        $reversedWords = array_reverse($words);
                        $reversedString = implode(" ", $reversedWords);
                        echo $reversedString;
                    ?>
                </div>
                <div class="border p-3">
                    <p class="h5 py-2">2. Afisati suma numerelor din intervalul n - m</p>
                    <p class="text-monospace"><b>Exemplu:</b>n = 2, m = 23, S = 3794 </p>
                    <?php
						$n = 2;
                        $m = 23;
                        $suma = 0;
                        for ($i = $n; $i <= $m; $i++) {
                            $suma += $i;
                        }
                        echo "Suma numerelor din intervalul $n - $m este: $suma";
                    ?>
                </div>
                <div class="border p-3 bg-light">
                    <p class="h5 py-2">3. Afisati toate numerele din intervalul 1 - 100 cu patratul si triplul lui.</p>
                    <table class="table table-bordered">
                            <?php
								for ($i = 1; $i <= 100; $i++) {
                                    $patrat = $i * $i;
                                    $triplu = $i * 3;
                                    echo "Numărul: $i, Pătratul: $patrat, Triplu: $triplu<br>";
                                }
                            ?>
                    </table>
                </div>
                <div class="border p-3">
                    <p class="h5 py-2">4. Asifati toate numerele din intervalul 1 - 100 care la impartirea cu 3 restul este numar par.</p>
                        <?php
							for ($i = 1; $i <= 100; $i++) {
                                $rest = $i % 3;
                                if ($rest % 2 === 0) {
                                    echo "$i ";
                                }
                            }
                        ?>
                </div>
                <div class="border p-3 bg-light">
                    <p class="h5 py-2">5. Afisati o matrice cu 10 x 10 ce va contine elemente aleatorii.</p>
                    <?php
                        $matrice = array();
                        for ($i = 0; $i < 10; $i++) {
                            for ($j = 0; $j < 10; $j++) {
                                $element = rand(1, 100);
                                $matrice[$i][$j] = $element;
                            }
                        }
                        echo "<table border='1'>";
                        for ($i = 0; $i < 10; $i++) {
                            echo "<tr>";
                            for ($j = 0; $j < 10; $j++) {
                                echo "<td>" . $matrice[$i][$j] . "</td>";
                            }
                            echo "</tr>";
                        }
                        echo "</table>";
                    ?>
                </div>
                <div class="border p-3">
                    <p class="h5 py-2">6. Afisati o matrice cu 10 x 10 ce va contine elemente aleatorii(1 - 100). Daca elemetele matricei sunt impare vor avea culoarea rosu, par verde</p>
                    <?php
                        $matrice = array();
                        for ($i = 0; $i < 10; $i++) {
                            for ($j = 0; $j < 10; $j++) {
                                $element = rand(1, 100);
                                $matrice[$i][$j] = $element;
                            }
                        }
                        echo '<table border="1" cellpadding="5">';
                        for ($i = 0; $i < 10; $i++) {
                            echo '<tr>';
                            for ($j = 0; $j < 10; $j++) {
                                $element = $matrice[$i][$j];
                                $culoare = ($element % 2 == 0) ? 'green' : 'red'; 
                        
                                echo "<td style='color: $culoare;'>$element</td>";
                            }
                            echo '</tr>';
                        }
                        echo '</table>';
                    ?>
                </div>
                <div class="border p-3 bg-light">
                    <p class="h5 py-2">7. Afisati un sir de numere aleatorii(1 - 100) de 30 unitati. Daca numarul este divizibil cu 3 va fi intr-un disc verde cu textul de culoare alba</p>
                    <div class="d-flex">
                        <?php
                            $nrAleatoare = array();
                            for ($i = 0; $i < 30; $i++) {
                                $numar = rand(1, 100);
                                $nrAleatoare[] = $numar;
                            }
                            foreach ($nrAleatoare as $numar) {
                                $culoareFond = ($numar % 3 == 0) ? 'green' : 'transparent';
                                echo "<div style='display: inline-block; background-color: $culoareFond; color: white; padding: 10px; border-radius: 50%; margin: 5px; text-align: center; width: 40px; height: 40px;'>";
                                echo $numar;
                                echo "</div>";
                            }
                        ?>
                    </div>
                </div>
                <div class="border p-3">
                    <p class="h5 py-2">8. Afisati o matrice cu 10 x 10 ce va avea in diagonala principala valoarea 1</p>
                    <?php
                        $matrice = array();
                        for ($i = 0; $i < 10; $i++) {
                            for ($j = 0; $j < 10; $j++) {
                                if ($i == $j) {
                                    $matrice[$i][$j] = 1;
                                } else {
                                    $matrice[$i][$j] = 0; 
                                }
                            }
                        }
                        echo '<table border="1" cellpadding="5">';
                        for ($i = 0; $i < 10; $i++) {
                            echo '<tr>';
                            for ($j = 0; $j < 10; $j++) {
                                echo '<td>' . $matrice[$i][$j] . '</td>';
                            }
                            echo '</tr>';
                        }
                        echo '</table>';
                    ?>
                </div>
                <div class="border p-3 bg-light">
                    <p class="h5 py-2">9. Cu ajutorul * desenati un patrat cu o latura de 10 *.</p>
                    <?php
                        for ($i = 0; $i < 10; $i++) {
                            for ($j = 0; $j < 10; $j++) {
                                echo "* ";
                            }
                            echo "<br>";
                        }
                    ?>
                </div>
                <div class="border p-3 bg-light">
                    <p class="h5 py-2">11. Cu ajutorul * desenati un X cu o latura de 10 *.</p>
                    <div class="container">
                        <?php
							for ($i = 0; $i < 10; $i++) {
                                for ($j = 0; $j < 10; $j++) {
                                    if ($i == $j || $i + $j == 10 - 1) {
                                        echo "* ";
                                    } else {
                                        echo "  "; 
                                    }
                                }
                                echo "<br>";
                            }
                        ?>
                    </div>
                </div>
                <div class="border p-3">
                    <p class="h5 py-2">13. Elaborati un script care va afisa numarul de litere "a" gasite intr-un string.</p>
                    <?php
						$text = "Acest text contine litera a.";
                        $nrLitereA = substr_count(strtolower($text), 'a');
                        echo "Numărul de litere 'a' găsite în text: $nrLitereA";
                    ?>
                </div>
            </div>
        </div>
    </div>
</body>
</html>