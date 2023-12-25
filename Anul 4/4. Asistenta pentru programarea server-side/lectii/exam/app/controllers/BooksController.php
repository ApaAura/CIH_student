<?php
    namespace App\Controllers;

    use Psr\Http\Message\ResponseInterface as Response;
    use Psr\Http\Message\ServerRequestInterface as Request;
    use App\Models\Book;
    class BooksController {
        public function index (Request $request, Response $response) {
            $query = Book::query();
            $data = $request->getParsedBody();
            if (isset($data['titlu']) && $data['titlu'] !== "") {
                $query->where('titlu', 'like', '%' . $data['titlu'] . '%');
            }
            if (isset($data['autor']) && $data['autor'] !== "") {
                $query->where('autor', 'like', '%' . $data['autor'] . '%');
            }
            if (isset($data['gen']) && $data['gen'] !== "") {
                $query->where('gen', $data['gen']);
            }
            if (isset($data['an_publicare']) && $data['an_publicare'] !== "") {
                $query->where('an_publicare', $data['an_publicare']);
            }
            $query->orderBy('titlu', 'asc');
            $books = $query->get();
            // Pentru formular
            $autori = Book::select('autor')->distinct()->orderBy('autor', 'asc')->get()->pluck('autor')->toArray();
            $genuri = Book::select('gen')->distinct()->orderBy('gen', 'asc')->get()->pluck('gen')->toArray();
            $ani = Book::select('an_publicare')->distinct()->orderBy('an_publicare', 'asc')->get()->pluck('an_publicare')->toArray();
            ob_start();
            include __DIR__ . "/../../views/books/index.view.php";
            $html = ob_get_clean();
            $response->getBody()->write($html);
            return $response;
        }
        public function create(Request $request, Response $response) {
            ob_start();
            include __DIR__ . "/../../views/books/create.view.php";
            $html = ob_get_clean();
            $response->getBody()->write($html);
            return $response;
        }

        public function store(Request $request, Response $response) {
            $data = $request->getParsedBody();
            $contact = new Book($data);
            $contact->save();
            return $response
                ->withHeader('Location', '/')
                ->withStatus(302);
        }

        public function edit(Request $request, Response $response, $args) {
            $book = Book::findOrFail($args['id']);
            ob_start();
            include __DIR__ . "/../../views/books/edit.view.php";
            $html = ob_get_clean();
            $response->getBody()->write($html);
            return $response;
        }

        public function update(Request $request, Response $response, $args) {
            $data = $request->getParsedBody();
            $book = Book::findOrFail($args['id']);
            $book->update([...$data]);
            return $response
                ->withHeader('Location', '/')
                ->withStatus(302);
        }

        public function delete(Request $request, Response $response, $args) {
            $book = Book::findOrFail($args['id']);
            $book->delete();
            return $response;
        }
    }