import {saveAs} from 'file-saver'

const user = {
    name:"John Doe",
    email:"john@gmail.com",
    age: 35,
    adress:{
        street:'Name',
        city: 'Cahul'
    }

}
const download_btn=document.getElementById('download_btn')
const upload_btn=document.getElementById('upload')
const userStr=JSON.stringify(user)

download_btn.addEventListener('click',()=>{
    const blob=new Blob([userStr],{type:'application/json'})
    saveAs(blob, 'file.json')
})

const displayData=(data)=>{
    for(const iterator in data){
        console.log(data[iterator])
    }
}
const user_list=document.getElementById('user')
const diplayDataList=(data)=>{
    for(const itr in data){
        if(typeof data[itr]==='object'){
            diplayDataList(data[itr])
        }else{
            user_list.innerHTML+=`<li>${itr}: ${data[itr]}</li>`
        }
    }
}
upload_btn.addEventListener('change', (event)=>{
    const file=event.target.files[0]
    const reader=new FileReader()
    reader.readAsText(file)
    reader.onload = ()=>{
        const data=JSON.parse(reader.result)
        displayData(data)
        diplayDataList(data)
    }
})

