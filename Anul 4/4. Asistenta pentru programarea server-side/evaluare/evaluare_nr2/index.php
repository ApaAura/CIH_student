<?php 
    include 'connect.php';
    $sql = "SELECT * FROM aeroporturi";
    $select_option="";
    $stmt = $conn->query($sql);
    $results = $stmt->fetchAll(PDO::FETCH_ASSOC);
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Contacts</title>
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
                <form action="index.php" method="post" class="mb-3">
                    <select class="form-control">
                        <option value="all">Toate aeroporturile</option>
                        <option value="gb">Aeroporturile din GB</option>
                    </select>
                    <button type="submit" class="btn btn-primary mt-3">Filtreaza</button>
                </form>
            </div>
            <div class="col-lg-8">
                <div class="row">
                    <h2>Toate aeroporturile</h2>
                    <?php foreach ($results as $row): ?>
                        <div class="col-lg-4">
                            <div class="card mb-2" style="width: 18rem; height:10rem;">
                                <div class="card-body">
                                    <h5 class="card-title">
                                        <?= $row['nume'] ?>
                                    </h5>
                                    <h6 class="card-subtitle mb-2 text-muted">
                                        Oras:
                                        <?= $row['city'] . " " . $row['region'] ?>
                                    </h6>
                                    <h6 class="card-subtitle mb-2 text-muted">
                                        Tara:
                                        <?= $row['country'] ?>
                                    </h6>
                                </div>
                            </div>
                        </div>
                    <?php endforeach; ?>
                    <h2>Aeroporturile din GB</h2>
                    <?php foreach ($results as $row): ?>
                        <?php if($row['country'] ==='GB'): ?>
                        <div class="col-lg-4">
                            <div class="card mb-2" style="width: 18rem; height:10rem;">
                                <div class="card-body">
                                    <h5 class="card-title">
                                        <?= $row['nume'] ?>
                                    </h5>
                                    <h6 class="card-subtitle mb-2 text-muted">
                                        Oras:
                                        <?= $row['city'] . " " . $row['region'] ?>
                                    </h6>
                                    <h6 class="card-subtitle mb-2 text-muted">
                                        Tara:
                                        <?= $row['country'] ?>
                                    </h6>
                                </div>
                            </div>
                        </div>
                        <?php endif; ?>
                    <?php endforeach; ?>
                </div>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"
        crossorigin="anonymous"></script>
</body>

</html>