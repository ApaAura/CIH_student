<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Laravel</title>

        <!-- Fonts -->
        <link rel="preconnect" href="https://fonts.bunny.net">
        <link href="https://fonts.bunny.net/css?family=figtree:400,600&display=swap" rel="stylesheet" />
    </head>
    <body >
        <div class="flex justify-centr items-center h-screen">
            <form action="{{route('subscribe')}}" method="post" class="flex-col">
                @csrf
                <div>
                    <label for="subscribe">Name</label>
                    <input type="text" name="name" id="name" class="mb-4" placeholder="name">
                </div>
                <div>
                    <label for="subscribe">Email</label>
                    <input type="text" name="email" id="email" class="mb-4" placeholder="email">
                </div>
                <button class="p-4" type="submit">Subscribe</button>
            </form>
        </div>
    </body>
</html>
