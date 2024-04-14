<?php
use App\Controllers\ProductsController;
$app->get("/",[ProductsController::class, "index"]);