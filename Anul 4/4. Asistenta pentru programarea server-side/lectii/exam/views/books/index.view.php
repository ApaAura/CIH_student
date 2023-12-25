<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Books</title>
    <link rel="stylesheet" href="	https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css">
</head>
<body>
    <?php include __DIR__ . '/../partials/nav.view.php'; ?>
    <div class="container">
        <div class="row">
            <h4>Lista cartilor</h4>
        </div>
        <div class="row">
            <div class="col-md-2">
                <h5>Filtrarea cartilor</h5>
                <form action="/book/sort" method="post">
                    <div class="mb-3">
                        <label for="titlu">Titlu</label>
                        <input type="text" name="titlu" id="titlu" class="form-control" />
                    </div>
                    <div class="mb-3">
                        <label for="autor">Autor</label>
                        <select name="autor" id="autor" class="form-control">
                            <option></option>
                            <?php foreach( $autori as $autor ): ?>
                                <option value="<?=$autor?>"><?=$autor?></option>
                            <?php endforeach; ?>
                        </select>
                    </div>
                    <div class="mb-3">
                        <label for="gen">Gen</label>
                        <select name="gen" id="gen" class="form-control">
                            <option></option>
                            <?php foreach( $genuri as $gen ): ?>
                                <option value="<?=$gen?>"><?=$gen?></option>
                            <?php endforeach; ?>
                        </select>
                    </div>
                    <div class="mb-3">
                        <label for="an_publicare">Ani</label>
                        <?php foreach( $ani as $an ): ?>
                            <div class="form-check">
                            <input type="radio" class="form-check-input" name="an_publicare" id="<?=$an?>" value="<?=$an?>">
                                <label class="form-check-label" for="<?=$an?>">
                                    <?=$an?>
                                </label>
                            </div>
                        <?php endforeach; ?>
                    </div>
                    <button type="submit" class="btn btn-secondary">Sorteaza</button>
                </form>
            </div>
            <div class="col-md-10">
                <a href="/book/adauga" class="btn btn-info mb-2 text-white">Adauga</a>
                <table class="table table-bordered">
                    <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Titlu</th>
                        <th scope="col">Autor</th>
                        <th scope="col">Gen</th>
                        <th scope="col">An publicare</th>
                        <th scope="col">ISBN</th>
                        <th scope="col">Descriere</th>
                        <th scope="col">Pret</th>
                        <th scope="col">Stoc</th>
                        <th scope="col">Optiuni</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php foreach ($books as $key => $book): ?>
                        <tr>
                            <td><?= $key+1 ?></td>
                            <td><?= $book->titlu ?></td>
                            <td><?= $book->autor ?></td>
                            <td><?= $book->gen ?></td>
                            <td><?= $book->an_publicare ?></td>
                            <td><?= $book->isbn ?></td>
                            <td><?= $book->descriere ?></td>
                            <td><?= $book->pret ?></td>
                            <td><?= $book->stoc ?></td>
                            <td>
                                <a href="/book/edit/<?=$book->id?>" class="btn btn-sm btn-warning text-white">Edit</a>
                                <button class="btn btn-sm btn-danger delete-book" data-id="<?=$book->id?>">Delete</button>
                            </td>
                        </tr>
                    <?php endforeach; ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script>
        const deleteProdus = document.querySelectorAll(".delete-book");
        deleteProdus.forEach( button => {
            button.addEventListener("click", async () => {
                try{
                    if(confirm("Sunteti siguri?")) {
                        const response = await fetch(`/book/delete/${button.dataset.id}`, {
                            method: 'DELETE'
                        })
                        location.reload();
                    }
                }catch (error) {
                    console.error(error);
                }
            })
        } );
    </script>
</body>
</html>