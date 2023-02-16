let flag=confirm(`Doriti sa adaugati un utilizator ?`)
const users=[]
while(flag){
    const user={
        nume:prompt(`Introducei numele !`),
        prenume:prompt(`Introduceti prenumele !`),
        fullName:function(){
            return`
            <div class="card">
                <h4>Nume: ${this.nume}</h4>
                <h4>Prenume: ${this.prenume}</h4>
            </div>
            `
        }
    }
    users.push(user)
    flag=confirm(`Doriti sa adaugati un utilizator ?`)
}

const app=document.getElementById('app')
for (const value of users){
    app.innerHTML+= value.fullName()
       
    
}
