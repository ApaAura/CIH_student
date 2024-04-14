
var canvas11 = document.getElementById('bird');
        var ctx11 = canvas11.getContext('2d');

        ctx11.beginPath();
        ctx11.arc(200, 200, 40, 0, Math.PI * 2);
        ctx11.fillStyle = 'brown';
        ctx11.fill();
        ctx11.closePath();

        ctx11.beginPath();
        ctx11.arc(150, 180, 20, 0, Math.PI * 2);
        ctx11.fillStyle = 'brown';
        ctx11.fill();
        ctx11.closePath();

        ctx11.beginPath();
        ctx11.moveTo(165, 180);
        ctx11.lineTo(175, 180);
        ctx11.lineTo(170, 190);
        ctx11.fillStyle = 'orange';
        ctx11.fill();
        ctx11.closePath();

        ctx11.beginPath();
        ctx11.arc(145, 175, 3, 0, Math.PI * 2);
        ctx11.fillStyle = 'black';
        ctx11.fill();
        ctx11.closePath();

        ctx11.beginPath();
        ctx11.moveTo(190, 200);
        ctx11.quadraticCurveTo(150, 160, 110, 200);
        ctx11.quadraticCurveTo(150, 220, 190, 200);
        ctx11.fillStyle = 'brown';
        ctx11.fill();
        ctx11.closePath();

        ctx11.beginPath();
        ctx11.moveTo(190, 240);
        ctx11.lineTo(190, 280);
        ctx11.moveTo(210, 240);
        ctx11.lineTo(210, 280);
        ctx11.strokeStyle = 'black';
        ctx11.lineWidth = 2;
        ctx11.stroke();
        ctx11.closePath();
