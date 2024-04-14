"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var point_1 = require("./point");
/*
npm install -g typescript
mkdir ts-hello
cd ts-hello
code main.ts
tsc main.ts | node main.js
rm main.js

let anouncement = (message)=>{
    console.log(message)
}
var message='Hello World'
anouncement(message)

var doSomething=()=>{
    for(var i = 0; i < 5; i++){
        console.log(i);
    }
    console.log(`Last ${i}`)
}
doSomething()

let a: number;
let b: boolean;
let c: string;
let d: any;
let e: number[]=[1,2,3];
let f: any[]=[1, true, 'a', false];

const ColorRed=0;
const ColorGreen=1;
const ColorBlue=2;
enum Color {Red=0, Green=1, Blue=2, Purple =3};
let backgroundColor=Color.Red;

let message;
message='abc';
let endsWithC=(<string>message).endsWith('c');
let alternativeWay=(message as string).endsWith('c');

let doLog = () => console.log(); //arrow function (lambda expresion)

interface Point{
    x: number,
    y: number
}
let drawPoint=(point: Point)=>{
    //..
}
let getDistance=(pointA: PointerEvent, pointB:Point)=>{
    //..
}

class Point{
    private x: number | undefined;
    private y: number | undefined;
    //optional parameters x?:number (should be both)
    //for optional parameters use 'type | undefined'
    constructor(x?:number, y?:number){
        this.x = x;
        this.y = y;
    }
    draw(){
        console.log(`X: ${this.x}, Y: ${this.y}`)
    }
    getDistance(another:Point){
        //..
    }
}
let point = new Point();
point.draw();
let anotherPoint = new Point(1,-1);
anotherPoint.draw();
*/
var anotherPoint = new point_1.Point(1, -1);
anotherPoint.draw();
