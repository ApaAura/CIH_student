<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Contacts</title>
    <script src="https://cdn.tailwindcss.com"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
    <div class="container mt-5">
        <h2 class="h2 mb-4">Sistem de gestionare a contactelor</h2>
        <form action="add.php" method="POST" class="mb-3">
            <div class="row">
                <div class="mb-3 col-lg-4">
                    <input type="text" name="nume" placeholder="Nume" id="nume" class="form-control" required>
                </div>
                <div class="mb-3 col-lg-4">
                    <input type="text" name="prenume" placeholder="Prenume" id="prenume" class="form-control" >
                </div>
                <div class="mb-3 col-lg-4">
                    <input type="email" name="email" placeholder="Email" id="email" class="form-control" required>
                </div>
                <div class="mb-3 col-lg-4">
                <input type="tel" name="telefon" placeholder="Nr. telefon" id="telefon" class="form-control" required>
                </div>
                <div class="mb-3 col-lg-4">
                    <input type="text" name="adresa" placeholder="Adresa" id="adresa" class="form-control" required>
                </div>
                <div class="mb-3 col-lg-4">
                    <label for="data_nasterii">Data nasterii:</label>
                    <input type="date" id="data_nasterii" name="data_nasterii" value="2023-10-30" min="1950-01-01" max="2023-12-31"/>
                </div>
                <div class="mb-3 col-lg-6">
                <input type="text" name="compania" placeholder="Companie" id="compania" class="form-control" >
                </div>
                <div class="mb-3 col-lg-6">
                    <input type="text" name="pozitia" placeholder="Pozitie/Ocupatie" id="pozitia" class="form-control" >
                </div>
                <div class="mb-3">
                    <textarea class="form-control" name="note_aditionale" placeholder="Note aditionale" id="note_aditionale" rows="3"></textarea>
                </div>
            </div>
            <div class="mb-3">
                <button type="submit" class="btn btn-secondary">Adauga</button>
            </div>
        </form>
        <div class="flex flex-col">
        <div class="overflow-x-auto sm:-mx-6 lg:-mx-8">
            <div class="inline-block min-w-full py-2 sm:px-6 lg:px-8">
            <div class="overflow-hidden">
                <table class="min-w-full text-left text-sm font-light">
                <thead class="border-b font-medium dark:border-neutral-500">
                    <tr>
                        <th scope="col" class="px-6 py-4">ID</th>
                        <th scope="col" class="px-6 py-4">Nume</th>
                        <th scope="col" class="px-6 py-4">Prenume</th>
                        <th scope="col" class="px-6 py-4">Adresa de email</th>
                        <th scope="col" class="px-6 py-4">Nr. telefon</th>
                        <th scope="col" class="px-6 py-4">Actiuni</th>
                    </tr>
                </thead>
                <tbody>
                <?php include 'connect.php';
                $sql = "SELECT * FROM contact";
                $stmt = $conn->query($sql); 
                $results = $stmt->fetchAll(PDO::FETCH_ASSOC);
                $conn = null;
                ?>
                <?php foreach ($results AS $row): ?>
                    <tr class="border-b dark:border-neutral-500">
                        <td class="whitespace-nowrap px-6 py-4 font-medium">
                            <?= $row['id'] ?>
                        </td>
                        <td class="whitespace-nowrap px-6 py-4">
                            <?= $row['nume'] ?>
                        </td>
                        <td class="whitespace-nowrap px-6 py-4">
                            <?= $row['prenume'] ?>
                        </td>
                        <td class="whitespace-nowrap px-6 py-4">
                            <?= $row['email'] ?>
                        </td>
                        <td class="whitespace-nowrap px-6 py-4">
                            <?= $row['telefon'] ?>
                        </td>
                        <td class="whitespace-nowrap px-6 py-4">
                            <a href='view.php?id=<?= $row['id'] ?>' class="btn btn-info btn-sm mr-2">View</a>
                            <a href="edit.php?id=<?= $row['id'] ?>" class="btn btn-secondary btn-sm mr-2">Editeaza</a>
                            <a href='delete.php?id=<?= $row['id'] ?>' class="btn btn-primary btn-sm mr-2">Sterge</a>
                        </td>
                    </tr>
                <?php endforeach; ?>
                </tbody>
                </table>
            </div>
            </div>
        </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"
        crossorigin="anonymous"></script>
</body>
</html>