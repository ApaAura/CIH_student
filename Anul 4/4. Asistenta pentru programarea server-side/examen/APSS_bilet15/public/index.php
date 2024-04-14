<?php
    require_once "../vendor/autoload.php";
    use Slim\Factory\AppFactory;
    use Illuminate\Database\Capsule\Manager as Capsule;

    $app = AppFactory::create();
    $app->addRoutingMiddleware();
    $app->add(new Slim\Middleware\MethodOverrideMiddleware());
    $capsule = new Capsule;
    $capsule->addConnection(require '../config/database.php');
    $capsule->setAsGlobal();
    $capsule->bootEloquent();
    require_once "../app/routes/web.php";
    $app->run();