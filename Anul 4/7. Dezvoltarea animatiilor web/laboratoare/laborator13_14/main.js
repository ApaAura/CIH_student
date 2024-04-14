const canvas = document.querySelector('canvas');
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

var maxRadius = 40;
var mouse = {
  x: undefined,
  y: undefined
};

window.addEventListener('mousemove', function(event){
  mouse.x = event.x;
  mouse.y = event.y;
  console.log(mouse);
});

function Circle(x, y, dx, dy, radius){
  this.x = x;
  this.y = y;
  this.dx = dx;
  this.dy = dy;
  this.radius = radius;

  this.draw = function(){
    c.beginPath();
    c.arc(this.x, this.y, this.radius, 0, Math.PI * 2, false);
    c.strokeStyle = "brown";
    c.fill();
    c.stroke(); 
  }

  this.update = function(){
    this.draw();
    if(this.x + this.radius >= canvas.width || this.x - this.radius <= 0){
      this.dx = -this.dx;
    }
    if(this.y + this.radius >= canvas.height || this.y - this.radius <= 0){
      this.dy = -this.dy;
    }
    this.x += this.dx;
    this.y -= this.dy;

    if(mouse.x - this.x < 100 && mouse.x - this.x > -100 && mouse.y - this.y < 100 && mouse.y - this.y > -100 && this.radius < maxRadius){
      this.radius += 1;
    }
    else if(this.radius > 10){
      this.radius -= 1;

    }

  }

}


var circleArray = [];

for(var i = 0; i < 300; i++){
  var r = Math.floor(Math.random() * 5) + 25 ;
  var x = Math.random() * (innerWidth - r*2) + r;
  var y = Math.random() * (innerHeight - r*2) + r;
  var dx = (Math.random() - 0.5) * 5;
  var dy = (Math.random() - 0.5) * 5;
  circleArray.push(new Circle(x, y, dx, dy, r));
}

function animate(){
  requestAnimationFrame(animate);
  c.clearRect(0, 0, innerWidth, innerHeight);
  
  for(i = 0; i < circleArray.length ; i++){
    circleArray[i].update();
  }
}

animate();