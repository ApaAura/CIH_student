var canvas22 = document.getElementById('flower');
var ctx22 = canvas22.getContext('2d');

function drawFlower(x, y, petalColor, centerColor) {
    ctx22.beginPath();
    ctx22.moveTo(x, y);
    ctx22.lineTo(x, y - 50);
    ctx22.strokeStyle = 'green';
    ctx22.lineWidth = 3;
    ctx22.stroke();
    ctx22.closePath();

    ctx22.beginPath();
    ctx22.arc(x, y - 60, 10, 0, Math.PI * 2);
    ctx22.fillStyle = petalColor;
    ctx22.fill();
    ctx22.closePath();

    ctx22.beginPath();
    ctx22.arc(x + 10, y - 50, 10, 0, Math.PI * 2);
    ctx22.fillStyle = petalColor;
    ctx22.fill();
    ctx22.closePath();

    ctx22.beginPath();
    ctx22.arc(x - 10, y - 50, 10, 0, Math.PI * 2);
    ctx22.fillStyle = petalColor;
    ctx22.fill();
    ctx22.closePath();

    ctx22.beginPath();
    ctx22.arc(x, y - 40, 10, 0, Math.PI * 2);
    ctx22.fillStyle = petalColor;
    ctx22.fill();
    ctx22.closePath();

    ctx22.beginPath();
    ctx22.arc(x, y - 50, 5, 0, Math.PI * 2);
    ctx22.fillStyle = centerColor;
    ctx22.fill();
    ctx22.closePath();
}

drawFlower(50, 150, 'red', 'yellow');
drawFlower(150, 150, 'blue', 'white');
drawFlower(250, 150, 'purple', 'pink');