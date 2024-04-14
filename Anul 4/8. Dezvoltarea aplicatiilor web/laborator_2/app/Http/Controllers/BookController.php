<?php

namespace App\Http\Controllers;

use App\Models\Book;
use Illuminate\Http\Request;
use Illuminate\View\View;

class BookController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $books = Book::all();
        //dd($books);
        return view('index', ['books'=>$books]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create():View
    {
        return view('create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $validated = $request->validate([
            'titlu' => 'required|unique:books|max:255',
            'autor' => 'required',
            'pagini'=> 'required|numeric',
            'pret' => 'required|numeric'
        ]);
        Book::create($request->all());
        return redirect()->back();
    }

    /**
     * Display the specified resource.
     */
    public function show(Book $book)
    {
        return view('show', ['book'=>$book]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Book $book)
    {
        return view('edit', ['book'=>$book]);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Book $book)
    {
        $book->titlu=$request->titlu;
        $book->autor=$request->autor;
        $book->pagini=$request->pagini;
        $book->pret=$request->pret;
        $book->save();
        //return redirect()->back();
        return redirect()->route('books.index');
    }

    /**
     * Remove the specified resource from storage.
    */
    public function destroy(Book $book)
    {
        $book->delete();
        return redirect()->back();
    }
}
