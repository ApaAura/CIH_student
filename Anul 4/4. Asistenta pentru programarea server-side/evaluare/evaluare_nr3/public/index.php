<?php
require_once "../vendor/autoload.php";
use Slim\Factory\AppFactory;
use Illuminate\Database\Capsule\Manager as Capsule;

$app = AppFactory::create();
$capsule = new Capsule;
$capsule->addConnection(require '../config/database.php');
$capsule->setAsGlobal();
$capsule->bootEloquent();
require_once "../routes/web.php";
$app->run();