const dropdownLinkList = document.querySelectorAll('.dropdown-link')

dropdownLinkList.forEach(link=>{
    link.addEventListener('click', ()=>{
        link.nextElementSibling.classList.toggle('active')
    })
})