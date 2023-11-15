<?php declare(strict_types= 1);

    namespace App;
    class App{
        protected int $port;
        public function getPort():int{
            return $this->port;
        }
        public function setPort(int $port):void{
            $this->port = $port;
        }
    }
?>