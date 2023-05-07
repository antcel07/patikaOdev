//let değişebilir değerler için dinamik değerler için
//const sabit degerler için tc,şifre,vs

/*
let fullName="kerem çelik";
console.log(fullName + " besiktas");

const serverPassword="bbvmhygk343";
console.log(serverPassword);

console.log(2**4);

console.log("aşagı yuvarlama: "+Math.floor(1.6));

console.log("yukari yuvarlama: "+ Math.ceil(1.6));
console.log("yakina yuvarlama: "+ Math.round(1.6));

var x = 1;
console.log(Boolean(x)); // returns true

let a; 
console.log(Boolean(a));

var x=10/'a';
console.log(Boolean(x));

var y="" || -2 || 'Javascript';
console.log(Boolean(y));


var z={2:'js'}; 
console.log(Boolean(z));



var t = "" && -2 && 'JavaScript'; console.log(Boolean(t));


var w = false || 0; console.log(Boolean(w));


var as = true; console.log(Boolean(as));

console.log(typeof 42);
// beklenen output: "number"

console.log(typeof 'kodluyoruz');
//beklenen output: "string"

console.log(typeof true);
// beklenen output: "boolean"

console.log(typeof Variable);
// beklenen output: "undefined"

let a1 = 99;
let b= 999;

console.log(`${a1} çarpı ${b} eşittir ${a1*b}`);

const kitap = {
    ad: "Fırtına",
    yazar: "Shakespeare",
    tarih: 1610
  }
  const bookTable =
        "<table border>"+
    "<tbody>"+
      "<tr>"+
        "<td>"+"Kitap"+"</td>"+
        "<td>"+kitap.ad+"</td>"+
      "</tr>"+
    "<tr>"+
        "<td>"+"Yazar"+"</td>"+
        "<td>"+kitap.yazar+"</td>"+
      "</tr>"+
        "<tr>"+
        "<td>"+"Tarih"+"</td>"+
        "<td>"+kitap.tarih+"</td>"+
      "</tr>"+
   " </tbody>"+
  "</table>"
  document.body.innerHTML = bookTable


  let email = "kodluyoruz@kodluyoruz.org"
  let domainn = email.slice(email.search("@")+1); 
console.log(domainn); //"kodluyoruz.org"

let domain = email.slice(email.indexOf("@")+1); 
console.log(domain); //"kodluyoruz.org"

firstName = email.toUpperCase();
console.log(firstName); 

console.log(firstName.slice(1,4)); 

let language = "Java";

language = language.replace("Java", "JavaScript");
console.log(language);


let url = "www.kodluyoruz.org";


console.log(url.indexOf("."));
//Önce indexOf kullanarak "noktanın" yerini öğrendik.
domain = url.slice(3+1)
//3+1 olması "noktadan" sonrasını al demek.
console.log(domain)



console.log(document.location.pathname)
console.log(document.head)
console.log(document.body)

document.body.style.background="red";


//etiket isimletrine göre çağırmak istersek  getElementsByTagName()
//eleman isimlerine getirmek için getElementsByName()
//bu element ise classa ait verileri getirir getElementsByClassName()
//innerHtml ile o classa ait içindeki veri bilgisi gelir


//const emails = document.getElementsByName('e-posta');

*/

/*
let title=document.getElementById('title')
console.log(title.innerHTML)


//let item=document.querySelector("ul#list>li:last-child")
//item.innerHTML="son oge değişti..."

let link=document.querySelector("ul#list>li>a")
link.innerHTML+=" degisti"
link.style.color="green"

//prepend ile liste elemanın başına veri ekleriz
//append ile de sonuna veri ekleriz
//createElement yerine hangi formatta veri oluşturcaksak a,li,ul vs. gibi tanımlamayı belirtiriz
let liDom=document.createElement('a')
liDom.innerHTML="kendi ekledigim oge "
link.prepend(liDom)


//prompt ile kullanıcıdan veri alırız
let fName=prompt("Lutfen adinizi giriniz")
console.log(fName)
let greeting=document.querySelector("#greeting")
//greeting.innerHTML=`${greeting.innerHTML} <small style="color:red">${fName}</small>`



var one = document.getElementById("walterwhite");
console.log(one.innerHTML)
var two  = document.getElementsByClassName("alternate");
console.log(two.innerHTML)

for (var i = 0; i < two.length; i++) { 
  two[i].style.color  = "red"; 
}

let div = document.querySelector('#content');
div.classList.add('info','visible','block');

var liste = document.querySelector("ul");
console.log(liste.innerHTML)

var urun = document.querySelector("#veri"); 
var ekle = document.querySelector("#ekle");




ekle.addEventListener("click",function(){
  // createElement ile yeni bir listItem (li) oluşturuyoruz
  var li=document.createElement("li"); 
  
  // Input ile gelen veriyi "li" içerisine metin olarak giriyoruz.
  li.textContent=veri.value; 
  
  // appendChild ile oluşturduğumuz elementi "liste" isimli değişkenimizin içerisine ekliyoruz.
  liste.appendChild(li);
              
  // Veri inputu içerisindeki metni siliyoruz.
  veri.value = "";
});



var a = 10;
var b = "kodluyoruz";
console.log(a>11 && b=="kodluyoruz")

console.log(!!2);


var x = 5;
var y = 7;

if(x > y) {
    console.log(x + " sayisi" + y + " sayısından büyüktür." );
}

else {
    console.log(y + " sayisi" + " " + x + " sayısından büyüktür.");
}


var ogrVizeNot = 45; // Bu kod satırını değiştiriniz. 

var ogrFinalNot = 60; // Bu kod satırını değiştiriniz. 

var ogrOrtalama = (ogrVizeNot * 0.3) + (ogrFinalNot * 0.7);

if(ogrOrtalama >= 0 && ogrOrtalama <= 30) {
  console.log("Not ortalamanız: " +ogrOrtalama + " KALDINIZ(FF).");
}

else if(ogrOrtalama >= 31 && ogrOrtalama <= 49) {
  console.log("Not ortalamnız: " +ogrOrtalama + " DC - KOŞULLU ");
}

else if(ogrOrtalama >= 50 && ogrOrtalama <= 84) {
  console.log("Not ortalamnız: " +ogrOrtalama + " CC - GEÇTİNİZ ");
}

else if(ogrOrtalama >= 85 && ogrOrtalama <= 100) {
  console.log("Not ortalamnız: " +ogrOrtalama + " AA - GEÇTİNİZ ");
}


var randomSayi = Math.floor(Math.random() * 10);
//Girdiğimiz sayıyı aklında tutması için prompt değişkene atanır
var tahmin = prompt("Bir sayı gir ve rastgele sayıyı bulmaya çalış!");
if (tahmin === randomSayi && tahmin != null) alert("Bildin!!!");
else if (tahmin == "") alert("Boş giriş yaptınız!");
else if (tahmin == null) alert("Giriş yapmaktan vazgeçtiniz!");
else {
  alert("Bir daha denee :(, Random sayi: " + randomSayi);
}


let hava = "Gunesli";
switch(hava) {
  case "Yagmurlu":
      console.log("Semsiyeni yanina almayi unutma");
      break;
  case "Gunesli":
      console.log("Hafif giyin");
  case "Bulutlu":
      console.log("Disari cik");
      break;
  case "Karlı":
      console.log("Kalin giyin");
      break;
  case "Firtinali":
      console.log("Bir süre disari cikma");
      break;
  default:
      console.log("Bilinmeyen hava durumu:" , hava);
}


let islem = function(a, b, operator) {
  switch(operator) {
      case 'topla':
          return a + b;
      break;
      case 'cikar':
          return a - b;
      break;
      case 'carp':
          return a * b;
      break;
      case 'bol':
          return a / b;
      break;
      default:
          return 'Tanimlanmamis islem';
      break;
  }
};
console.log(islem(23, 14, 'topla'));  // 37
console.log(islem(10, 3, 'mod'));  


let userName=prompt("ad bilgisini yaziniz")
let info=document.querySelector("#info")
//ternany kullanimi: kosul ? dogruysa : yanlissa

//info.innerHTML=`${userName.length>0 ? userName : "kullanici bilgisi bulunamadı :( "}`


function hello(){
  console.log("merhaba")
}


hello()



function Question(hobby) {
  switch (hobby) {
    case "car":
      return function (name) {
        console.log(name + " do you have a car ?");
      };
      break;

    case "book":
      return function (name) {
        console.log(name + " what is your favorite author?");
      };
      break;

    case "software":
      return function (name, type) {
        console.log(name + " are you interested in " + type + "?");
      };
      break;

    default:
      return function (name) {
        console.log(name + "  how are you ?");
      };
      break;
  }
}

var softwareQuestion = Question("software");
softwareQuestion("Cemre","nodejs");



function daireAlaniHesaplama (r, PI = 3.14) { 
    return PI*r*r;		
}
var donenSonuc = daireAlaniHesaplama(3); 
console.log(donenSonuc);


let firstName="Lorem"

function cvvc(firstName="",lastName=""){
  console.log(`Merhaba ${firstName}`)
  console.log(`Merhaba ${firstName} ${lastName} `)

}

function toplama (a , b){
 // a ve b toplanacak iki sayıyı temsil eden fonksiyon parametreleri(girdileri) {  
  var sonuc = a+b; // Fonksiyonda aldığımız parametrelerle yaptığımız işlem
	return sonuc;  	// Herhangi iki sayının toplamından elde edeceğimiz işlem sonucunu, return ifadesinden hemen sonra belirtiyoruz.
  
}
 */


// => fat arrow ifadesi const greet = (who) => `Hello, ${who}!`; bu kullanımda => sonrası return olan kısma eşittir

function hello (firstName){
  console.log(`Merhaba ${firstName}`)
}

hello("Javascript")

const helloFuncV1=(firstName) => {console.log(`Merhaba ${firstName}`)}
helloFuncV1("kerem")

//bir parametre bir geri dönüş varsa
const helloFuncV2=(firstName) => {console.log(`Merhaba ${firstName}`)}
helloFuncV2("sabah")

//console log parantezi
const helloFuncV3=(firstName,lastName) =>
 console.log(`Merhaba ${firstName} ${lastName} `)
helloFuncV3("asalan","last name info")



//birdenfazla işlem için süslü parantez kullanırız
const helloFuncV4=(firstName,lastName) =>{
let info=`Merhaba ${firstName} ${lastName} `
 console.log(info)
return info
}

helloFuncV4("sadık","guzel")

//----------------------------------------------

// ES5
var multiplier = function(item, multi) {
  return item * multi
};
console.log(multiplier(5, 2)); // output : 10

// ES6
const multiplier2 = (item, multi) => item * multi;
console.log( multiplier2(5, 2)); // output : 10

//----------------------------------------------

//ES5
var myList = function(param1, param2) {
  return param1.concat(param2);
};
console.log( myList([1, 2], [3, 4, 5])); // output : [ 1, 2, 3, 4, 5 ]

//ES6
const myList2 = (param1, param2) => param1.concat(param2);
console.log( myList2([1, 2], [3, 4, 5])); // output : [ 1, 2, 3, 4, 5 ]

//----------------------------------------------

let movie = { 

  name: "La la land",
  
  thisInArrow:() => { 
  console.log("Movie name is " + this.name); // 'this' window'u referans gösterir. Bu yüzden name'yi bulamaz.
  }, 
  
  thisInRegular(){ 
  console.log("Movie name is " + this.name); // 'this' kendisini referans gösterir ve çalışır.
  } 
  
  };
  movie.thisInArrow(); // output : Movie name is
  movie.thisInRegular(); // output : Movie name is La la land



  //----------------------------------------------
  const seriesList = list => {
  
    list.forEach((series, index) => {
      console.log(`${index+1}. ${series}`) 
    });
  };
  
  seriesList(["Firefly", "The Mandalorian","Breaking Bad"]);


 //----------------------------------------------


  const newArray = (nums) => {

    const newNums = nums.map(e=>{      
        if(e%2==0){
            return e*2
        }else if(e%2==1){
            return e*3
        }
    });
   return newNums 
}

console.log(newArray([1,2,3,4,5]));  // output: [3,4,9,8,15]



//------------------------------------------

//id=select olan nesne çağrılarak color değişkenine atandı
const color = document.querySelector("#select");
//color değişkenine change etkinliği etkinliği atandı ve fonksiyon ismi parametre olarak atandı
color.addEventListener('change' ,selectBox);

//selectBox isimli fonksiyon ile selectbox her seçildiğinde etkinlik tipi =change ve değeri consola yazılmaktadır 
function selectBox(event){
  console.log("Etkinlik tipi : " + event.type);
  console.log("deger : " + event.target.value);
  }
  
// Selectbox içinde "blue" değerini seçtiğimiz takdirde;
// ekran çıktısı: Etkinlik tipi : change, deger : blue﻿



//---------------------------------


  
/*
// iç içe elementler çağrıldı  
const selectBox = document.querySelector('#selectBox');
const button = document.querySelector('#button');
const form = document.querySelector('.inputText');  
const cerceve = document.querySelector('.container');
selectBox.addEventListener('click' ,function(){
    console.log("selectBox");    
    })
form.addEventListener('click',function(){
    console.log("form");
    })
cerceve.addEventListener('click',function(){
    console.log('cerceve');
    })

*/



//butona tıklanma olayını ele alır Dom içindeki event olayları
    let greeting=document.querySelector("#greeting")
    //click tıklandığında , mouseover üstüne gelindiğinde
    greeting.addEventListener("mouseover",domClick)
    
    function domClick()
    {
     console.log("tiklandi")
     this.style.color=="red" ? this.style.color="black" : this.style.color="red"
    }


    //--------------------function bölüm sonu------------------------
    //button ile artrıma azaltma
//localStroge bölümsonuda ekledik-------
    let counter=localStorage.getItem('counter') ? Number(localStorage.getItem('counter')) : 0
    let counterDOM =document.querySelector('#counter')
    let increaseDOM =document.querySelector('#increase')
    let decreaseDOM =document.querySelector('#decrease')

    counterDOM.innerHTML=counter
    increaseDOM.addEventListener("click",clickEvent)
    decreaseDOM.addEventListener("click",clickEvent)


function clickEvent(){
  console.log(typeof(counter))
console.log(this.id)
this.id=="increase" ? counter+=1 : counter-=1
localStorage.setItem('counter',counter)
counterDOM.innerHTML=counter
    }

    
    //local storage işlemleri------------------------------------
    let user={userName:"keremcelik",isActive:true}
    console.log(user)
    //burada userStatus string türüne dönüştürürüz setItem ile veri kayıt ederiz
    localStorage.setItem('userinfo', JSON.stringify(user))

    //getItem ile veriyi çağırırız gösteririz
    let userInfo = localStorage.getItem('userInfo')
    console.log(userInfo)