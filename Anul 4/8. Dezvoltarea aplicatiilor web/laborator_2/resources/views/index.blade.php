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
                        <a class="nav-link active" aria-current="page" href="{{route('books.index')}}">
                            Carti
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container">
        <a href="{{ route('books.create')}}" class="btn btn-success btn-sm">
            Adauga
        </a>
        <div class="row">
            <h4>List</h4>
            <div class="table-responsive">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Titlu</th>
                            <th>Autor</th>
                            <th>Pagini</th>
                            <th>Pret</th>
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach($books as $book)
                        <tr>
                            <td>{{$book->id}}</td>
                            <td>{{$book->titlu}}</td>
                            <td>{{$book->autor}}</td>
                            <td>{{$book->pagini}}</td>
                            <td>{{$book->pret}}</td>
                            <td class="d-flex">
                                <a href="{{ route('books.edit', ['book'=>$book -> id]) }}" class="btn btn-warning btn-sm m-1">Edit</a>
                                <a href="{{ route('books.show', ['book'=> $book -> id]) }}" class="btn btn-warning btn-sm m-1" >Show</a>
                                <form href="{{ route('books.destroy', ['book'=>$book]) }}" action="post">
                                @csrf
                                @method('DELETE')
                                    <button type="submit" class="btn btn-warning btn-sm m-1">Delete</button>
                                </form>
                            </td>
                        </tr>
                        @endforeach
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <footer>

    </footer>
</body>

</html>