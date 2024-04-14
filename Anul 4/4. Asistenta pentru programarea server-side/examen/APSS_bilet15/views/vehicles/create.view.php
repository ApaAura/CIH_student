<!doctype html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>VehiclesApp</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css">
</head>

<body class="bg-light">
    <div class="container mt-3">
        <div class="row">
            <div class="py-5 text-center">
                <img class="d-block mx-auto mb-4"
                    src="https://getbootstrap.com/docs/4.0/assets/brand/bootstrap-solid.svg" alt="" width="72"
                    height="72">
                <h2>Add vehicle</h2>
                <p class="lead">Below is an example form built entirely with Bootstrap's form controls. Each required <br>
                    form group has a validation state that can be triggered by attempting to submit the form without
                    completing it.</p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-10 m-auto">
                <form action="/vehicle/store" method="post" form-control>
                    <div class="mb-3">
                        <label for="name">Name</label>
                        <input type="text" name="name" id="name" class="form-control">
                    </div>
                    <div class="mb-3">
                        <label for="type">Type</label>
                        <input type="text" name="type" id="type" class="form-control">
                    </div>
                    <div class="mb-3">
                        <label for="capacity">Capacity</label>
                        <input type="text" name="capacity" id="capacity" class="form-control">
                    </div>
                    <div class="mb-3">
                        <label for="year">Year</label>
                        <input type="number" name="year" id="year" class="form-control">
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="status" name="status" checked>
                        <label class="form-check-label" for="status">
                            Disponible
                        </label>
                    </div>
                    <button class="btn btn-primary my-3">Save vehicle</button>
                </form>
            </div>
        </div>
    </div>
</body>

</html>