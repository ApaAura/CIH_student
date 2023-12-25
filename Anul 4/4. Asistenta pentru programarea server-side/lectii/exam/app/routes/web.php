<?php
    use App\Controllers\BooksController;

    $app->get("/", [BooksController::class, "index"]);
    $app->get("/book/adauga", [BooksController::class, "create"]);
    $app->post("/book/store", [BooksController::class, "store"]);
    $app->get("/book/edit/{id}", [BooksController::class, "edit"]);
    $app->put("/book/update/{id}", [BooksController::class, "update"]);
    $app->delete("/book/delete/{id}", [BooksController::class, "delete"]);
    $app->post("/book/sort", [BooksController::class, "index"]);