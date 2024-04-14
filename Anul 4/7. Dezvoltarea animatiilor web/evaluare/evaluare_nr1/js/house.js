var canvashouse = document.getElementById('house');
var ctxhouse = canvashouse.getContext('2d');

ctxhouse.fillStyle = '#ffcc00'; 
ctxhouse.fillRect(50, 250, 300, 200); 

ctxhouse.beginPath();
ctxhouse.moveTo(50, 250);
ctxhouse.lineTo(200, 100);
ctxhouse.lineTo(350, 250);
ctxhouse.closePath();
ctxhouse.fillStyle = '#aa6633'; 
ctxhouse.fill();

ctxhouse.fillStyle = '#663300'; 
ctxhouse.fillRect(150, 350, 100, 100);

ctxhouse.fillStyle = '#99ccff'; 
ctxhouse.fillRect(80, 280, 80, 80);

ctxhouse.fillStyle = '#444444'; 
ctxhouse.fillRect(280, 150, 40, 100);
ctxhouse.fillRect(300, 120, 20, 30);