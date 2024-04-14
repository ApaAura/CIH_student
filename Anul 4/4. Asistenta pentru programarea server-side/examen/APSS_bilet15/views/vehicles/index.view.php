<!doctype html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>VehiclesApp</title>
    <link rel="stylesheet" href="	https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css">
</head>

<body>
    <?php include __DIR__ . '/../partials/navbar.view.php'; ?>
    <div class="container mt-5">
    <div class="row align-items-md-stretch">
      <div class="col-md-11 m-auto">
        <div class="h-100 p-5 text-white bg-dark rounded-3 mb-3">
          <h2>Vehicles List</h2>
          <p>Conditia: Creati o aplicatie web pentru gestionarea unei companii de transport. <br>Interfata grafica pentru utilizator prin care acesta poate <b>adauga si sterge vehicule</b>.</p>
        </div>
      </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-11 m-auto">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Name</th>
                            <th scope="col">Type</th>
                            <th scope="col">Cpacity</th>
                            <th scope="col">Year</th>
                            <th scope="col">Status</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php foreach ($vehicle as $key => $vehicle): ?>
                            <tr>
                                <td>
                                    <?= $key + 1 ?>
                                </td>
                                <td>
                                    <?= $vehicle->name ?>
                                </td>
                                <td>
                                    <?= $vehicle->type ?>
                                </td>
                                <td>
                                    <?= $vehicle->capacity ?>
                                </td>
                                <td>
                                    <?= $vehicle->year ?>
                                </td>
                                <td>
                                    <?= $vehicle->status == 0 ? "Indisponible" : "Disponible" ?>
                                </td>
                                <td>
                                    <button class="btn btn-sm btn-danger delete-book"
                                        data-id="<?= $vehicle->id ?>">Delete</button>
                                </td>
                            </tr>
                        <?php endforeach; ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <?php include __DIR__ . '/../partials/footer.view.php'; ?>
    <script>
        const deleteProdus = document.querySelectorAll(".delete-book");
        deleteProdus.forEach(button => {
            button.addEventListener("click", async () => {
                try {
                    if (confirm("You want to delete?")) {
                        const response = await fetch(`/vehicle/delete/${button.dataset.id}`, {
                            method: 'DELETE'
                        })
                        location.reload();
                    }
                } catch (error) {
                    console.error(error);
                }
            })
        });
    </script>
</body>

</html>