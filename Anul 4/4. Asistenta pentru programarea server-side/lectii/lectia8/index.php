<?php
    date_default_timezone_set("Europe/Chisinau");
    echo date('Y-m-d H:i:s').'<br/>'; 
    echo date('Y-m-d H:i:s', time()-60*60*24).'<br/>';
    echo date('F-j-Y H:i:s').'<br/>';

    $date='2020-02-06 10:10:35';
    $parsedData=date_parse($date);


?>