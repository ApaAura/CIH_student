const button=document.getElementById('load-image')

const getGata=async()=>{
    //const response = await fetch('data.json')
    const response=await fetch('https://jsonplaceholder.typicode.com/photos')
    const data = await response.json()
    return data
}

async function displayData(){
    const loaderElement= document.getElementById('loader')
    loaderElement.style.display='block'
    const data=await getGata()
    const listElement =document.getElementById('list')
    data.forEach(item=>{
        const listItem=document.createElement('li')
        const image=document.createElement('img')
        image.src=item.url
        image.classList.add('img-fluid')
        //listItem.textContent=item.name
        listElement.appendChild(image)
        listElement.appendChild(listItem)
    })
    loaderElement.style.display='none'
}

button.addEventListener('click', ()=>{
    displayData()
})
