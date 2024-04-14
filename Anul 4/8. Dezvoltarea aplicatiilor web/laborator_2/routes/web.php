<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\BookController;
Route::get('/',[BookController::class, 'index']);


Route::resource('books', BookController::class);
