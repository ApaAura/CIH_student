<?php declare(strict_types= 1);

class Transaction{
    private ?float $amount;
    private ?string $description;
    public function __construct(?float $amount, ?string $description) {
        $this->amount = $amount;
        $this->description = $description;
    }
    public function getAmount(): ?float{
        return $this->amount;
    }
    public function addTax(): ?string{
        
    }
}
?>