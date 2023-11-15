<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Contacts</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>

<body>
    <div class="container mt-5">
        <h2>Sistem de gestionare a utilizatorilor</h2>
        <form action="adauga.php" method="post" class="mb-3">
            <div class="mb-3">
                <input type="text" name="nume" placeholder="Nume" id="nume" class="form-control" required>
            </div>
            <div class="mb-3">
                <input type="text" name="prenume" placeholder="Prenume" id="Prenume" class="form-control" required>
            </div>
            <div class="mb-3">
                <input type="number" name="varsta" placeholder="varsta" id="varsta" class="form-control" required>
            </div>
            <div class="mb-3">
                <button type="submit" class="btn btn-success">Adauga</button>
            </div>
        </form>

        <table class="table">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nume</th>
                    <th>Prenume</th>
                    <th>Virsta</th>
                    <th>Actiuni</th>
                </tr>
            </thead>
            <tbody>
                <?php include 'conexiune.php';
                $sql = "SELECT * FROM utilizatori";
                $stmt = $conn->query($sql); 
                $results = $stmt->fetchAll(PDO::FETCH_ASSOC);
                $con = null;
                ?>
                <?php foreach ($results AS $row): ?>
                    <tr>
                        <td>
                            <?= $row['id'] ?>
                        </td>
                        <td>
                            <?= $row['nume'] ?>
                        </td>
                        <td>
                            <?= $row['prenume'] ?>
                        </td>
                        <td>
                            <?= $row['varsta'] ?>
                        </td>
                        <td>
                            <a href="editeaza.php?id=<?= $row['id'] ?>" class="btn btn-warning btn-sm mr-2">Editeaza</a>
                            <a href='sterge.php?id=<?= $row['id'] ?>' class="btn btn-danger btn-sm mr-2">Sterge</a>
                        </td>
                    </tr>
                <?php endforeach; ?>
            </tbody>
        </table>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"
        crossorigin="anonymous"></script>
</body>

</html>