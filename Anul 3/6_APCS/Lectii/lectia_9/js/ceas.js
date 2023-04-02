/*let contor=0
const interval=setInterval(()=>{
    console.log(++contor)
},3000)

setTimeout(()=>{
    clearInterval(interval)
},30000)
*/

const ceas=document.getElementById('ceas')
const interval=setInterval(()=>{
    const data =new Date()
    const h=data.getHours()
    const min=data.getMinutes()
    const s=data.getSeconds()

    let hText=h.toString().padStart(2,'0')
    let minText=min.toString().padStart(2,'0')
    let sText=s.toString().padStart(2,'0')
    
    ceas.textContent=`${hText}:${minText}:${sText}`
    //console.log(`${hText}:${minText}:${sText}`)
},1000)