<?php
include 'connect.php';
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nume = $_POST["nume"];
    $city = $_POST["city"];
    $region = $_POST["region"];
    $country = $_POST["country"];

    $sql = "INSERT INTO aeroporturi (nume, city, region, country) VALUES (:nume, :city, :region, :country)";
    $stmt = $conn->prepare($sql);
    $stmt->bindParam(':nume', $nume);
    $stmt->bindParam(':city', $city);
    $stmt->bindParam(':region', $region);
    $stmt->bindParam(':country', $country);
    $stmt->execute();

    header("Location:index.php");
}
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Aeroporturi</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand" href="./index.php">AirportApp</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup"
            aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div class="navbar-nav">
                <a class="nav-item nav-link" href="./add.php">Add aeroport</a>
            </div>
        </div>
    </nav>
    <div class="container mt-5">
        <div class="row">
            <div class="col-lg-4">
                <h2>Adauga aeroport</h2>
                <form action="add.php" method="post" class="mb-3">
                    <div class="mb-3">
                        <input type="text" name="nume" placeholder="Nume" id="nume" class="form-control" required>
                    </div>
                    <div class="mb-3">
                        <input type="text" name="city" placeholder="Oras" id="city" class="form-control" required>
                    </div>
                    <div class="mb-3">
                        <input type="text" name="region" placeholder="Regiunea" id="region" class="form-control"
                            required>
                    </div>
                    <div class="mb-3">
                        <input type="text" name="country" placeholder="Tara" id="country" class="form-control" required>
                    </div>
                    <div class="mb-3">
                        <button type="submit" class="btn btn-primary">Adauga</button>
                    </div>
                </form>
            </div>

            <div class="col-lg-8">
                <table class="table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nume</th>
                            <th>Oras</th>
                            <th>Regiune</th>
                            <th>Tara</th>
                            <th>Actiuni</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php include 'connect.php';
                        $sql = "SELECT * FROM aeroporturi";
                        $stmt = $conn->query($sql);
                        $results = $stmt->fetchAll(PDO::FETCH_ASSOC);
                        ?>
                        <?php foreach ($results as $row): ?>
                            <tr>
                                <td>
                                    <?= $row['id'] ?>
                                </td>
                                <td>
                                    <?= $row['nume'] ?>
                                </td>
                                <td>
                                    <?= $row['city'] ?>
                                </td>
                                <td>
                                    <?= $row['region'] ?>
                                </td>
                                <td>
                                    <?= $row['country'] ?>
                                </td>
                                <td>
                                    <a href='delete.php?id=<?= $row['id'] ?>' class="btn btn-danger btn-sm mr-2">Sterge</a>
                                </td>
                            </tr>
                        <?php endforeach; ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"
        crossorigin="anonymous"></script>
</body>
</html>