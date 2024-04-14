<?php

namespace App\Http\Controllers;
use App\Models\Create;
use Illuminate\Http\Request;

class CreateController extends Controller
{
    public function index(){
        $contacts = Create::all();
        return view('contacts.index', ['contacts'=>$contacts]);
    }
}
