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
let title=document.getElementById('title')
console.log(title.innerHTML)

let link=document.querySelector("ul#list>li>a")
link.innerHTML+=" degisti"
link.style.color="green"


