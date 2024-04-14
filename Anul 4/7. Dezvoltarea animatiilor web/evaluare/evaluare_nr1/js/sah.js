var canvas = document.getElementById('sahCanvas');
var context = canvas.getContext('2d');
var cellSize = 25;
var lightColor = '#f0d9b5';
var darkColor = '#b58863';

for (var row = 0; row < 8; row++) {
  for (var col = 0; col < 8; col++) {
    var x = col * cellSize;
    var y = row * cellSize;
    var color = (row + col) % 2 == 0 ? lightColor : darkColor;
    context.fillStyle = color;
    context.fillRect(x, y, cellSize, cellSize);
  }
}

var qrCodeData = [
  [1, 1, 0, 1, 0, 1, 1, 1, 1, 1],
  [1, 0, 1, 0, 1, 1, 0, 1, 0, 1],
  [0, 1, 1, 1, 0, 1, 1, 1, 0, 1],
  [1, 1, 0, 0, 1, 1, 0, 1, 0, 1],
  [0, 1, 0, 1, 0, 0, 1, 1, 1, 1],
  [1, 0, 1, 0, 1, 0, 0, 1, 0, 0],
  [1, 1, 0, 1, 1, 1, 1, 0, 1, 0],
  [0, 1, 1, 0, 0, 0, 1, 1, 1, 1],
  [1, 0, 0, 1, 1, 1, 0, 0, 0, 1],
  [1, 1, 1, 1, 1, 1, 1, 1, 1, 1]
];

var canvasQR = document.getElementById('qr');
var content = canvasQR.getContext('2d');
var cellSize = 8;
var qrCodeSize = qrCodeData.length;
for (var y = 0; y < qrCodeSize; y++) {
  for (var x = 0; x < qrCodeSize; x++) {
    if (qrCodeData[y][x] === 1) {
      content.fillStyle = "#000";
    } else {
      content.fillStyle = "#fff";
    }
    content.fillRect(x * cellSize, y * cellSize, cellSize, cellSize);
  }
}

const canvas7 = document.getElementById("patrat");
const ctx7 = canvas7.getContext("2d");

ctx7.beginPath();
ctx7.lineWidth = "6";
ctx7.strokeStyle = "red";
ctx7.rect(5, 5, 290, 140);
ctx7.stroke();

ctx7.beginPath();
ctx7.lineWidth = "4";
ctx7.strokeStyle = "green";
ctx7.rect(30, 30, 50, 50);
ctx7.stroke();

ctx7.beginPath();
ctx7.lineWidth = "10";
ctx7.strokeStyle = "yellow";
ctx7.rect(50, 50, 100, 80);
ctx7.stroke();

const c9 = document.getElementById("grad");
const ctx9 = c9.getContext("2d");
const grd = ctx9.createLinearGradient(0, 0, 200, 0);
grd.addColorStop(0, "red");
grd.addColorStop(1, "white");
ctx9.fillStyle = grd;
ctx9.fillRect(10, 10, 150, 80);

const canvas4 = document.getElementById("bezer");
const ctx99 = canvas4.getContext("2d");
ctx99.beginPath();
ctx99.moveTo(20, 20);
ctx99.bezierCurveTo(20, 100, 200, 100, 200, 20);
ctx99.stroke();