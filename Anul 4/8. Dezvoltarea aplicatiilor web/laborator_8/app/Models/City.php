<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\BelongsTo;

class City extends Model
{
    use HasFactory;
    protected $fillable=[
        'nume',
        'populatie',
        'country_id',
        'zona_geografica'
    ];
    public function country():BelongsTo{
        return $this->belongTo(Country::class);
    }
}
