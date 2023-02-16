//chese board

var chessboard = document.getElementById('app');

for (var i = 8; i >= 1; i--) {
   for (var j = 0; j < 8; j++) {
      var chessSquare = document.createElement('div')
      chessSquare.className = 'chess-square'

      if ((i + j) % 2 == 0) {
         chessSquare.style.backgroundColor = '#000'
         chessSquare.style.color = '#fff';
      }

      var rank = String.fromCharCode(96 + i) // calculează indicele pentru rând
      var file = j + 1 // calculează indicele pentru coloană
      var label = rank + file

      var labelDiv = document.createElement('div')
      labelDiv.className = 'chess-label'
      labelDiv.innerHTML = label

      chessSquare.appendChild(labelDiv)
      chessboard.appendChild(chessSquare)
   }
}