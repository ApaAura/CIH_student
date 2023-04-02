fetch('https://jsonplaceholder.typicode.com/users')
    .then(response => response.json())
    .then(users =>{
        const usersBlock = document.querySelector('.users')
        users.forEach(user => {
            usersBlock.innerHTML += `<div class= 'card'>
                <h1>${user.name}</h1>
                <p>${user.email}</p>
                <h2>Adresa</h2>
                <ul type = 'circle'>
                <li>${user.address.city}</li>
                <li>${user.address.street}</li>
                <li>${user.address.suite}</li>
                </ul>
                <p>${user.phone}</p>
            </div>`
        });
        console.log(users)
})