<?php declare(strict_types=1);
$directoryName= (string) 'public';
$source=scandir($directoryName);

array_shift($source);
array_shift($source);

if(count($files)>0){
    foreach($files as $file){
        unlink($directoryName.'/'.$file);
    }
}