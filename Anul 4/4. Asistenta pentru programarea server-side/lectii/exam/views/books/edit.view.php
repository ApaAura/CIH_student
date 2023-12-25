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
<div class="container">
    <div class="row">
        <h2 class="text-center">Editeaza o carte</h2>
    </div>
    <div class="row">
        <div class="col-md-4 m-auto">
            <form action="/book/update/<?=$book->id?>" method="post">
            <input type="hidden" name="_METHOD" value="PUT">
                <div class="mb-3">
                    <label for="titlu">Titlu</label>
                    <input type="text" name="titlu" id="titlu" class="form-control" value="<?=$book->titlu?>">
                </div>
                <div class="mb-3">
                    <label for="autor">Autorul</label>
                    <input type="text" name="autor" id="autor" class="form-control" value="<?=$book->autor?>">
                </div>
                <div class="mb-3">
                    <label for="gen">Genul</label>
                    <input type="text" name="gen" id="gen" class="form-control" value="<?=$book->gen?>">
                </div>
                <div class="mb-3">
                    <label for="an_publicare">Anul publicarii</label>
                    <input type="number" name="an_publicare" id="an_publicare" class="form-control" value="<?=$book->an_publicare?>">
                </div>
                <div class="mb-3">
                    <label for="isbn">ISBN</label>
                    <input type="number" name="isbn" id="isbn" class="form-control" value="<?=$book->isbn?>">
                </div>
                <div class="mb-3">
                    <label for="descriere">Descriere</label>
                    <textarea name="descriere" id="descriere" rows="5" class="form-control"><?=$book->descriere?></textarea>
                </div>
                <div class="mb-3">
                    <label for="pret">Pret</label>
                    <input type="number" name="pret" id="pret" class="form-control" step="0.01" value="<?=$book->pret?>">
                </div>
                <div class="mb-3">
                    <label for="stoc">Stoc</label>
                    <input type="number" name="stoc" id="stoc" class="form-control" value="<?=$book->stoc?>">
                </div>
                <button class="btn btn-success">Editeaza</button>
            </form>
        </div>
    </div>
</div>
</body>
</html>