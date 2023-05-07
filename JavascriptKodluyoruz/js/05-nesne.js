// let arrayObj=[1,2,3]
// let object1={obj:1}

// console.log("arrayObj",typeof(arrayObj))
// console.log("object1",typeof(object1))

// let item1=new Object()
// let item2={}
// console.log("item1",typeof(item1))
// console.log("item2",typeof(item2))

// let item3={}
// let item4=new Object()

// console.log("object1",object1)

// let laptop1={
//     brand: "Apple",
//     model: "MacBook Pro",
//     "2kg": 2,
//     modelName: "MacbookPro"
// }

// console.log(laptop1)
// console.log(laptop1.brand , laptop1["brand"])
// console.log(laptop1.model , laptop1["model"])
// console.log(laptop1["2kg"])

// //anahtar bilgisine yeni değer ekleme
// laptop1.brand="Mac"
// laptop1["brand"]="Mac1"
// console.log(laptop1)

// //yeni bilgi eklemek 
// laptop1.version="10.15.7"
// console.log(laptop1)

// //anahtar bilgilerine ulaşmak(keys) --> object.keys(item)
// keys=Object.keys(laptop1)
// console.log(keys)
// console.log(Object.keys(laptop1))



// keys.forEach(keyInfo => {
//      console.log(keyInfo)
//      console.log(laptop1[keyInfo])
// })

// console.log(
//     Object.values(laptop1)
// )

// let values=Object.values(laptop1)

// values.forEach(value => {
//     console.log("value: ",value)
   
// })


// let person= {};                     // set (oluştur)
// person["likes sea"] = true;         // get (getir)
// console.log(person["likes sea"]);   // true (doğru)
// delete person["likes sea"];      

// //key-value ilişkisi
// let person2 = {
//     name: "Jack",
//     age: 20,
//   };
//   let key = prompt("Kişinin hangi özelliğini öğrenmek isterdiniz?", "name");
//   // değişken ile erişim
//   alert(person2[key]);      // Jack (prompt’a “name” yazarsak erişeceğimiz değer)


//   let state = {
//     users:[
//             {name: "Brock", age: 25, favoriteColor: "red"},
//             {name: "Jessie", age: 17, favoriteColor: "yellow"},
//             {name: "James", age: 41, favoriteColor: "blue"},
//             {name: "Winnie", age: 18, favoriteColor: "purple"}
//         ],
//     settings:{
//     version: "1.0.5",
//     DNS: "105.xx.xx.xx",
//     website: "https://www.example.com/"
//         },
//     banList: ["Ash", "Angelica", "Tom", "Jerry"]
//     }


//     let person3 = {
//         name: "Jack",
//         age: 20
//       };
      
//       document.getElementById("userList").innerHTML = JSON.stringify(person3); // Bu objenizi bir stringe çevirip demo idsine basacaktır.
      
//       let stringObject = JSON.stringify(person3);
      
//       let newPerson = JSON.parse(stringObject); 
//       // parse methodu da stringtify methodunun tersi olarak çalışır ve stringi objeye çevirir


//       var person4 = {
//         name1: 'Rumeysa',
//         surname1: 'Turgut',
//         age1: 23,
//         city1: 'Istanbul',
//         introduce: function () {
//             console.log(`My name is ${this.name1} ${this.surname1}, I'm ${this.age1} yo.`);
//         },
//     };

//     var person5 = {
//         name: 'Rumeysa',
//         surname: 'Turgut',
//         age: 23,
//         introduce: () => {
//             return `My name is ${person5.name} ${person5.surname}, I'm ${person5.age} yo.`;
//         },
//     };


//     var birey = {
//         isim: 'Ali',
//         soyisim: 'Veli',
//         dogumYili: 1989,
//         merhabaDe: (age) = `Merhaba, ben ${birey.isim} ${birey.soyisim}, ${age} yaşındayım`,
//     };
//     birey.yasHesapla = function () {
//         return 2021 - this.dogumYili;
//     };
//     console.log(birey.merhabaDe(birey.yasHesapla()));



let user1 = {

    firstName: "Bilgin",
    lastName: "Uzman",
    score: [1,2,3,4],
    isActive: true,
    shortName: function() {

        return `${this.firstName[0].toUpperCase()} ${this.lastName}`
    }
};
console.log(user1)


var person = {
	name: 'Rumeysa',
	surname: 'Turgut',
	age: 23,
	city: 'Istanbul',
	introduce: function () {
		return (`My name is ${this.name} ${this.surname}, I'm ${this.age} yo.`);
	}
};
console.log(person
 )



    function Insan(isim,yas) {
        this.isim = isim;
        this.yas = yas;
      }
      const ali = new Insan("ali",21);
console.log(ali.yas);
// 21


// Sınıfa prototype yardımıyla fonksiyon eklemek
Insan.prototype.yeniFonksiyon = () => {console.log("Merhaba Kodluyoruz")}
const ayse = new Insan("ayşe",22);
ayse.yeniFonksiyon();
// Output : "Merhaba Kodluyoruz"
ayse.__proto__.enYeniFonksiyon = () => {console.log("Tekrar Merhaba Kodluyoruz!")}
ayse.enYeniFonksiyon();
// Output : "Tekrar Merhaba Kodluyoruz!"



const toplama = ({ sayi1, sayi2, ...args }) => {
    let sonuc = sayi1 + sayi2;
    for (let sayi in args){
     sonuc += args[sayi];
    }
    return sonuc;
   }
   const sayilar = {
    sayi1: 8,
    sayi2: 4,
    sayi3: 7,
    sayi4: 9,
    sayi5: 11
   }
   
   console.log(toplama(sayilar))
   // 39 doner


   let personn={name:"Selin",city:"Ankara",favoriteColor:"aqua blue"}; 
let {name:foo}=personn;

console.log(foo)