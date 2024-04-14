<!doctype html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Laborator 2</title>
    @vite(['resources/scss/app.scss', 'resources/js/app.js'])
</head>

<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Carti</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">
                            Carti
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container">
    <div class="row">
        <div class="col-md-6 mt-4">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Titlu:    {{$book->titlu}}</h4> <hr>
                    <h6 class="card-subtitle mb-2 text-muted">{{$book->autor}}</h6>
                    <p class="card-text">Pages: {{$book->pagini}}</p>
                    <p class="card-text">Price: {{$book->pret}}</p>
                </div>
            </div>
        </div>
    </div>
</div>

    <footer>

    </footer>
</body>

</html>