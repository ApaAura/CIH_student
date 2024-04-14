const kgToLbs=(weight: number|string): number =>{
    //Narrowing
    if (typeof weight === 'number')
        return weight*2.2;
    else 
        return parseInt(weight)*2.2;
}
kgToLbs(10)
kgToLbs('10kg')

//intersection types
type Draggable = {
    drag: () => void
}
type Resiziable = {
    resize: () => void
}
type UIWidget = Draggable & Resiziable
let textBox : UIWidget={
    drag: () => {},
    resize: () => {}
}

//literal types (exact)
type Quantity = 50|100;
let quantity : Quantity = 100

type Customer = {
    birthday:Date
};
const getCustomer =(id:number):Customer|null|undefined=>{
    return id===0? null: {birthday : new Date()}
}
let customer = getCustomer(0);
//if (customer!==null && customer!==undefined)
//optional property acces operator 
console.log(customer?.birthday)