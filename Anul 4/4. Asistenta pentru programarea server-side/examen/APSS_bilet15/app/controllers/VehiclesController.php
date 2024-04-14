<?php
    namespace App\Controllers;

    use Psr\Http\Message\ResponseInterface as Response;
    use Psr\Http\Message\ServerRequestInterface as Request;
    use App\Models\Vehicle;
    class VehiclesController {
        public function index(Request $request, Response $response) {
            $query = Vehicle::query();
            $data = $request->getParsedBody();
            $vehicle = $query->get();
            ob_start();
            include __DIR__ . "/../../views/vehicles/index.view.php";
            $html = ob_get_clean();
            $response->getBody()->write($html);
            return $response;
        }
        public function create(Request $request, Response $response) {
            ob_start();
            include __DIR__ . "/../../views/vehicles/create.view.php";
            $html = ob_get_clean();
            $response->getBody()->write($html);
            return $response;
        }
        public function store(Request $request, Response $response) {
            $data = $request->getParsedBody();
            $vehicle = new Vehicle($data);
            $vehicle->save();
            return $response
                ->withHeader('Location', '/')
                ->withStatus(302);
        }
        public function delete(Request $request, Response $response, $args) {
            $vehicle = Vehicle::findOrFail($args['id']);
            $vehicle->delete();
            return $response;
        }
    }