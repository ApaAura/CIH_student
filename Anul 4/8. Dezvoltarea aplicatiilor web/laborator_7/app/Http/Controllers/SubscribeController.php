<?php

namespace App\Http\Controllers;
use App\Models\Subscribe;
use Illuminate\Http\Request;
use App\Mail\SubscribeUser;
use Illuminate\Support\Facades\Mail;

class SubscribeController extends Controller
{
    public function store(Request $request){
        Subscribe::create($request->all());
        $subscribe = new Subscribe();
        $subscribe->name=$request->name;
        $subscribe->email=$request->email;
        Mail::to($request->email)->send(
            new SubscribeUser($subscribe)
        );
        return redirect()->back()-with('succes', 'Inregistrarea reusita !');
    }
}
