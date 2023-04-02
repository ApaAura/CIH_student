const changeBackground = document.getElementById ('changeBackground')

changeBackground.addEventListener('click', ()=>{
    changeBackground.classList.toggle('gb-color')
})


const start = document.getElementById('start')
const stop = document.getElementById('stop')
const timer = document.getElementById('timer')
let contor = 0
start.addEventListener('click', ()=>{
    const interval = setInterval(()=>{
        timer.textContent = ++contor
    }, 1000)
})
document.getElementById('stop').onclick = ()=> {
    document.getElementById('timer').hidden = true
}