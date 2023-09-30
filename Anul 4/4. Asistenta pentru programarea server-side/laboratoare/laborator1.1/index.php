<?php

$endLoop=100;
for($i=1; $i<=$endLoop; $i++){
    if($i%2==0){
        echo $i." ";
    }
}

echo "<table>";
echo "<thead>";
echo "<tr>";
echo "<th>Numarul</th>";
echo "<th>Patratul</th>";
echo "<th>Cubul</th>";
echo "</tr>";
echo "</thead>";
echo "<tbody>";
for($i=1; $i<=20; $i++){
    echo "<tr>";
    echo "<td>".$i."</td>";
    echo "<td>".$i*$i."</td>";
    echo "<td>".$i*$i*$i."</td>";
    echo "</tr>";
}
echo "</tbody>";
echo "</table>";


for($i=1; $i<=30; $i++){
    if($i%2==0){
        echo "<span style='border-radius: 100%; background-color: green; font-size:30px; color: white; padding:5px;'>$i  </span>";
    }else{
        echo "<span style='border-radius: 100%; background-color: red; font-size:30px; color: white; padding:5px;'>$i  </span>";
    }
}
