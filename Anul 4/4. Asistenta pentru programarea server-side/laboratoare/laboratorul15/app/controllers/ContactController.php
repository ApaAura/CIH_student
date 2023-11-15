<?php
    namespace App\Controllers;

    use Psr\Http\Message\ResponseInterface as Response;
    use Psr\Http\Message\ServerRequestInterface as Request;
    use App\Models\Contact;

    class ContactController{
        public function index(Request $request, Response $response, $args){
            $contacts = Contact::all();
            $response->getBody()->write(json_encode($contacts)); 
            return $response;
        }
        public function store(Request $request, Response $response, $args){
            $data=$request->getParsedBody();
            $contact=new Contact($data);
            $contact ->save();
            $response->getBody()->write(json_encode(['message'=>'Contact created']));
            return $response;
        }
        public function update(Request $request, Response $response, $args){
            $contact =Contact::find($args['id']);
            $data=json_decode($request ->getBody()->getContents(), true);
            $contact -> fill($data);
            $contact->save();
            $response ->getBody()->write(json_encode(['message'=>'Contact updated']));
            return $response;
        }
    }

?>