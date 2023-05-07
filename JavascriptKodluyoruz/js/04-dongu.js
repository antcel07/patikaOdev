// let users=["Lorem","Ipsum","Dolor"]

// const userListDOM= document.querySelector('#userList')

// for(index=0; index<users.length;index++){
//     const liDOM=document.createElement('li')
//     liDOM.innerHTML=users[index]
//     userListDOM.appendChild(liDOM)
//     // console.log(users[index])
// }

const LOREM_LIST=[
    'lorem','ipsum','dolor','amet','consectetur','âdisds','sghgffh'
]

let counter=0

const UL_DOM=document.querySelector('#userList')
let index=0

for(; index<LOREM_LIST.length;index++){
    if(LOREM_LIST[index] == "dolor"){break}
    let LI_DOM=document.createElement('li')
    LI_DOM.innerHTML=LOREM_LIST[index]
    UL_DOM.append(LI_DOM)
}

//forEach fonksiyonu item, index, array olmak üzere 3 parametre alabilir.

const PRODUCTS=["laptop","Phone","Speake","Desktop","Mouse","Keyboard"]
PRODUCTS.forEach((product,index,array) => array[index] = `${product.toUpperCase()}`)
console.log(PRODUCTS)



const animals = ["cat" , "dog" , "bird", "horse"];
  
animals.forEach((value , index , array) => {
  console.log('value: ', value );
  console.log('value parametresinin aldığı index :', index );
  console.log('array:' , array );
});



const numbers = [4, 11, 9];
const newArray = [];

numbers.forEach(function(numbers){
  newArray.push(numbers*3);
});
console.log(newArray);

// output = [12, 33, 27]


const products = ["Mikrofon","Kablo","Telefon","Bilgisayar","Mouse","Klavye","Ekran"]
const newProducts = products.filter(eleman => eleman.length > 5)
console.log(newProducts); //["Mikrofon", "Telefon", "Bilgisayar", "Klavye"]


//--------------------------
const person = [{
    name: "Adem",
    age: 25,
    languages: ["JavaScript", "CSS"],
    },
    {
    name: "Oğuz",
    age: 33,
    languages: ["Java", "HTML"],
      }
    ];

    const newPerson=person.filter(a=>a.languages.includes('JavaScript'))
    console.log(newPerson);


//--------------------------
const maaslar = [ 1100, 13000, 2500, 4500, 1500, 25000, 2000 ];
const yeniMaaslar = maaslar.map((e)=>{
    if(e > 3000)
        return e * 1.15;
    else
        return e * 1.25;
});

console.log( yeniMaaslar );
//[1210, 13650, 2750, 4725, 1650.0000000000002, 26250, 2200]


//--------------------------
const sayilar = [2, 3, 4, 5, 10]
const yeniArray = sayilar.map(deger => {
    return deger * 2
})

console.log(sayilar);
//[2, 3, 4, 5, 10]
console.log(yeniArray);
//[4, 6, 8, 10, 20]

