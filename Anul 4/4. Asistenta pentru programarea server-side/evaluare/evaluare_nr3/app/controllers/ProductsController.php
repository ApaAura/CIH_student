<?php
namespace App\Controllers;
use Psr\Http\Message\ResponseInterface as Response;
use Psr\Http\Message\ServerRequestInterface as Request;
use App\Models\Product;
class ProductsController{
    public function index(Request $request, Response $response){
        $product= Product::all();
        ob_start();
        include __DIR__ . "./../../views/products/index.view.php";
        $html = ob_get_clean();
        $response->getBody()->write($html);
        return $response;
    }
}