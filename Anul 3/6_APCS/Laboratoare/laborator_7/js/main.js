//Concatenați două sau mai multe tablouri: Scrieți o funcție care primește două sau mai multe tablouri și returnează un nou tablou care conține toate elementele din acele tablouri concatenate. Acest lucru poate fi util pentru combinarea mai multor seturi de date într-unul singur.
const concatArr=(...arr)=>{
    //return arr.filter()
    return arr.reduce((acc, curr) => acc.concat(curr), []);
}
const arr=['J','a','v','a']
const arr1=['S','c','r','i','p','t']

console.log(concatArr(arr, arr1))

//Scrieți o funcție care primește două tablouri de obiecte și un nume de proprietate comună și returnează un sub-tablou din primul tablou care conține obiectele care au o valoare din proprietatea comună care se regăsește în al doilea tablou. De exemplu, puteți filtra un tablou de obiecte produs pe baza unui tablou de ID-uri.
const checkID=(tablou1, tablou2, propetry)=>{
    const filter = []
    for (let i = 0; i < tablou1.length; i++) {
      if (tablou2.includes(tablou1[i][propetry])) {
        filter.push(tablou1[i])
      }
    }
    return filter
}

const products = [
    {name: 'Product 1', price: 10 },
    {name: 'Product 2', price: 20 },
    {name: 'Product 3', price: 30 },
    {name: 'Product 4', price: 40 },
];
const productPrice = [10, 40];
const filteredProducts = checkID(products, productPrice, 'price');
console.log(filteredProducts);

//Scrieți o funcție care primește un tablou de obiecte și un șablon RegExp și returnează un sub- tablou care conține doar obiectele care conțin șiruri de caractere care se potrivesc cu acel șablon. De exemplu, puteți filtra un tablou de obiecte mesaj pe baza unui șablon care corespunde cuvintelor cheie.
const checkMessage=(tablou,regex)=>{
    return tablou.filter(obj => {
        for (let prop in obj) {
          if (regex.test(obj[prop])) {
            return true
          }
        }
        return false
      });
}

const messages = [
    { id: 1, text: "JavaScript" },
    { id: 2, text: "HyperText Markup Language" },
    { id: 3, text: "Cascading Style Sheets" },
    { id: 4, text: "Phyton" }
];
const checkedMessage=checkMessage(messages, /Style/)
console.log(checkedMessage)