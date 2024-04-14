<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\SubscribeController;

Route::get('/', function () {
    return view('welcome');
});
Route::post('subscribe', [SubscribeController::class, 'store'])->name('subscribe');

