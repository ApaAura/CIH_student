var c = document.getElementById("line");
var ctx = c.getContext("2d");
ctx.moveTo(0, 0);
ctx.lineTo(200, 100);
ctx.stroke();

const c2 = document.getElementById("stroke");
const ctx2 = c2.getContext("2d");
ctx2.beginPath();
ctx2.moveTo(20, 20);
ctx2.lineTo(50, 90);
ctx2.lineTo(140, 90);
ctx2.strokeStyle = "red";
ctx2.stroke();

const canvas1 = document.getElementById("circle");
const ctx4 = canvas1.getContext("2d");
ctx4.beginPath();
ctx4.arc(100, 50, 40, 0, 2 * Math.PI);
ctx4.fillStyle = "orange";
ctx4.fill();