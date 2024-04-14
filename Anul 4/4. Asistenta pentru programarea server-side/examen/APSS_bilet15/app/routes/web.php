<?php
    use App\Controllers\VehiclesController;

    $app->get("/", [VehiclesController::class, "index"]);
    $app->get("/vehicle/create", [VehiclesController::class, "create"]);
    $app->post("/vehicle/store", [VehiclesController::class, "store"]);
    $app->delete("/vehicle/delete/{id}", [VehiclesController::class, "delete"]);