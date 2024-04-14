/* Exercise 1: Create a Class for a Car. Create a TypeScript class representing a car. The car class should have properties like make, model, year, and a method to start the car. Instantiate different car objects, and call the start method for each car. */
class Car{
    constructor(private make?:string, private model?:string, private year?: number){}
    start(){
        console.log(`Starting the ${this.make} ${this.model} (${this.year})`);
    }
}
let firstCar=new Car('Honda', 'Civic', 2023);
firstCar.start();

/*Exercise 2: Create a Class for a Calculator. Create a TypeScript class representing a calculator. The calculator class should have methods to add, subtract, multiply, and divide two numbers. Test the calculator by performing various calculations.*/
class Calculator{
    add(a: number, b: number): number {return a + b;}
    subtract(a: number, b: number): number {return a - b;}
    multiply(a: number, b: number): number {return a * b;}
    divide(a: number, b: number): number {return a / b;}
}
let calculator=new Calculator();
console.log(calculator.add(5, 3));    
console.log(calculator.subtract(7, 2)); 
console.log(calculator.multiply(4, 6)); 
console.log(calculator.divide(10, 2));  

/*Exercise 3: Create a Class for a Rectangle. Create a TypeScript class representing a rectangle. The rectangle class should have properties for its width and height, and methods to calculate its area and perimeter.*/
class Rectangle {
    constructor(public width: number, public height: number) {}
    calculateArea(): number {
      return this.width * this.height;
    }
    calculatePerimeter(): number {
      return 2 * (this.width + this.height);
    }
}
const rectangle = new Rectangle(5, 8);
console.log('Area:', rectangle.calculateArea());   
console.log('Perimeter:', rectangle.calculatePerimeter());
