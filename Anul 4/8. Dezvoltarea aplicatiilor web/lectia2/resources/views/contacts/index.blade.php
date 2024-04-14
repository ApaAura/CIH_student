@extends('layouts.app')
@section('title', 'Contacts Page')

@section('content')
<h2>Contact List</h2>
<ul class="list-group"></ul>
@forelse ($contacts as $contact)
<li class="list-group-item m-2">{{$contact->nume}} | {{$contact->prenume}} | {{$contact->telefon}} | {{$contact->email}}
</li>
@empty
<li class="list-group-item">No contacts</li>
@endforelse
@endsection


@section('content-card')
<h2>Contact List</h2>
<div class="row">
    @forelse ($contacts as $contact)
    <div class="col-lg-3">
        <div class="card bg-light mb-3" style="max-width: 18rem;">
            <div class="card-header">{{$contact->nume}} {{$contact->prenume}}</div>
            <div class="card-body">
                <h5 class="card-title">{{$contact->telefon}}</h5>
                <p class="card-text">{{$contact->email}} </p>
            </div>
        </div>
    </div>
    @empty
    <li class="list-group-item">No contacts</li>
    @endforelse
</div>
@endsection