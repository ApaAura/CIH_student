/* Exercise 1: Create a Class for a Car. Create a TypeScript class representing a car. The car class should have properties like make, model, year, and a method to start the car. Instantiate different car objects, and call the start method for each car. */
var Car = /** @class */ (function () {
    function Car(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    Car.prototype.start = function () {
        console.log("Starting the ".concat(this.make, " ").concat(this.model, " (").concat(this.year, ")"));
    };
    return Car;
}());
var firstCar = new Car('Honda', 'Civic', 2023);
firstCar.start();
/*Exercise 2: Create a Class for a Calculator. Create a TypeScript class representing a calculator. The calculator class should have methods to add, subtract, multiply, and divide two numbers. Test the calculator by performing various calculations.*/
var Calculator = /** @class */ (function () {
    function Calculator() {
    }
    Calculator.prototype.add = function (a, b) { return a + b; };
    Calculator.prototype.subtract = function (a, b) { return a - b; };
    Calculator.prototype.multiply = function (a, b) { return a * b; };
    Calculator.prototype.divide = function (a, b) { return a / b; };
    return Calculator;
}());
var calculator = new Calculator();
console.log(calculator.add(5, 3));
console.log(calculator.subtract(7, 2));
console.log(calculator.multiply(4, 6));
console.log(calculator.divide(10, 2));
/*Exercise 3: Create a Class for a Rectangle. Create a TypeScript class representing a rectangle. The rectangle class should have properties for its width and height, and methods to calculate its area and perimeter.*/
var Rectangle = /** @class */ (function () {
    function Rectangle(width, height) {
        this.width = width;
        this.height = height;
    }
    Rectangle.prototype.calculateArea = function () {
        return this.width * this.height;
    };
    Rectangle.prototype.calculatePerimeter = function () {
        return 2 * (this.width + this.height);
    };
    return Rectangle;
}());
var rectangle = new Rectangle(5, 8);
console.log('Area:', rectangle.calculateArea());
console.log('Perimeter:', rectangle.calculatePerimeter());
