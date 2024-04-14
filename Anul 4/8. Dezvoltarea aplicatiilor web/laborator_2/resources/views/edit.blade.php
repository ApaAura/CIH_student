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
            <div class="col-md-6 m-auto">
                <h4 class="mt-4">Editeaza cartea</h4>
                <form action="{{ route('books.update', ['book' => $book->id]) }}" method="post" class="mt-4">
                    @csrf
                    @method('PUT')
                    <div class="mb-3">
                        <input type="text" name="titlu" class="form-control" placeholder="Titlu" value="{{ $book->titlu }}">
                    </div>
                    <div class="mb-3">
                        <input type="text" name="autor" class="form-control" placeholder="Autor" value="{{ $book->autor }}">
                    </div>
                    <div class="mb-3">
                        <input type="number" name="pagini" class="form-control" placeholder="Pagini" value="{{ $book->pagini }}">
                    </div>
                    <div class="mb-3">
                        <input type="number" step="0.0" name="pret" class="form-control" placeholder="Pret" value="{{ $book->pret }}">
                    </div>
                    <button type="submit" class="btn btn-dark btn-sm">Editeaza</button>
                </form>
            </div>
        </div>
    </div>
    <footer>

    </footer>
</body>

</html>