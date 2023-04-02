const test = document.getElementById('test')
test.onclick = ()=>{
    console.log('Test')
}

const app = document.getElementById('app')
const btn = document.createElement('button')
     btn.textContent = 'Apasa'
     btn.style.backgroundColor = 'red'
     btn.onclick = ()=>{
        alert('Bravo!')
     }
app.appendChild(btn)     