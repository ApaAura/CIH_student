//Implementarea unui timer care să pornească și să se oprească la apăsarea unui buton. Acesta se poate realiza folosind metodele setInterval() și clearInterval() pentru a actualiza valoarea unui contor și a o afișa pe ecran.

const timerDisplay = document.getElementById('timer')
const startStopButton = document.getElementById('start-stop-button')
let intervalId
let seconds = 0
let minutes = 0
let hours = 0

const startTimer=()=>{
  intervalId = setInterval(()=>{
    seconds++
    if (seconds >= 60){
      seconds = 0
      minutes++
      if (minutes >= 60){
        minutes = 0
        hours++
      }
    }
    timerDisplay.textContent = (hours ? (hours > 9 ? hours : "0" + hours) : "00") + ":" +
      (minutes ? (minutes > 9 ? minutes : "0" + minutes) : "00") + ":" +
      (seconds > 9 ? seconds : "0" + seconds)
  }, 1000)
}
const stopTimer=()=>{
  clearInterval(intervalId);
}
startStopButton.addEventListener('click', ()=>{
  if(intervalId){
    stopTimer()
    intervalId = null
  }else {
    startTimer()
  }
})