<?php
    use Slim\Psr7\Request;
    use Slim\Psr7\Response;
    use App\Controllers\ContactController;

    $app->get('/', function(Request $request, Response $response, $args){
        $response->getBody()->write("Hello world!");
        return $response;
    });
    $app->get('/contacts',[ContactController::class, 'index']);
    //$app->get('/contacts/create',[ContactController::class,'create']);
    $app->post('/contacts',[ContactController::class,'store']);
    //$app->get('/contacts/{id}',[ContactController::class,'show']);
    //$app->put('/contacts/{id}',[ContactController::class,'update']);
    //$app->delete('/contacts/{id}',[ContactController::class,'destroy']);

?>