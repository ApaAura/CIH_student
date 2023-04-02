const firstImage=document.getElementById('first-images')
const images=document.querySelectorAll('.imagine')
let contor=0


images.forEach((img,index)=>{
    img.addEventListener('click',()=>{
        firstImage.src=img.src
        contor=index
    })

})
const interval=setInterval(()=>{
    contor++
    if(contor>=images.length) contor=0 
    
},3000)