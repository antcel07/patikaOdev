let domain="kodluyoruz"
let isActive=false
let items=[1,2,3,isActive,domain]
console.log(items)

let emptyArray=[]

console.log(
    items.length
)

console.log(items[0])
console.log(items.length-1)
console.log("true : ", Array.isArray(true))


let arr = [1,2,3,"dört","beş"];
arr.forEach((item, index) => {
  console.log(item, index);
});


let item=[1,2,3,4,5]
console.log("items-ilk hali : " , item)

//sona eklenmis hali
item.push(13)
console.log("13 eklenmis hali : " , item)

//basa oge eklemek icin
item.unshift(23)
console.log("23 eklenmis hal" , item)

//pop ile son öğeyi çıkarma
let lastItem=item.pop()
console.log("son oge cıkarilmis hal:", lastItem , item)

//shift ile ilk öğeyi çıkarma
let firstItem=item.shift()
console.log("ilk oge cıkarilmis hal:", firstItem , item)

//splice ile ilk adım başlangıç konumu ikinci adım kaç ileri gideceği belirterek dizide silme işlemini uygularız
var sports = ['basketball', 'football', 'tennis' ];
console.log(sports); // basketball, football, tennis
sports.splice(1,1);
console.log(sports); // basketball, tennis


const alisverisListem = ["elma", "ekmek", "süt"];
const yeniAlisverisListem = alisverisListem.slice(0,2);
// "elma"dan başlayıp "süt"e kadar olan elemanları kopyala."süt" dahil değil.
console.log(yeniAlisverisListem);
// ["elma", "ekmek"] görmeyi bekleriz.

const alisverisListem2 = ["elma", "ekmek", "süt","muz","kalem"];
console.log(alisverisListem2.indexOf("süt"))


//include ile ekleme işlemi yaparız
const alisverisListem3 = ["elma", "ekmek", "süt"];

const elmaVar = alisverisListem3.includes("elma");
console.log(elmaVar);
// Dizi içerisinde elma olduğu için true yazdırmasını bekleriz.

const armutVar = alisverisListem3.includes("armut");
console.log(armutVar);
// Dizi içerisinde armut olmadığı için ekrana false yazdırmasını bekleriz.


//slice (dilimleme) metodu bir dizinin bir kısmının kopyasıyla yeni bir dizi oluşturmamıza olanak sağlıyor.
const alisverisListem4 = ["elma", "ekmek", "süt"];
const yeniAlisverisListem4 = alisverisListem4.slice(0,2);
// "elma"dan başlayıp "süt"e kadar olan elemanları kopyala."süt" dahil değil.
console.log(yeniAlisverisListem4);
// ["elma", "ekmek"] görmeyi bekleriz.


//join ile ekleme yaparız diziye
const alisverisListem5 = ["elma", "ekmek", "süt"];
const stringAlisverisListem5 =  alisverisListem5.join();
console.log(stringAlisverisListem5);
// Çıktıda "elma,ekmek,süt" bekleriz.
const stringAlisverisListem6 = alisverisListem5.join(" kiraz ");
console.log(stringAlisverisListem6);
// Çıktıda "elma kiraz ekmek kiraz süt" bekleriz.


//concat ile iki farklı diziyi birleştirme işlemi yaparız 
const yiyecekler = ["pasta", "baklava", "puding"];
const icecekler = ["su", "kahve"];
const menu = yiyecekler.concat(icecekler);
console.log(menu);
// Çıktıda ["pasta", "baklava", "puding", "su", "kahve"] bekleriz.


// Malzemeler dizisindeki her bir malzemeyi ve onun indeksini konsola yazdıran bir kod yazalım:
const malzemeler = ["yumurta", "un", "süt"];
malzemeler.forEach(function(malzeme, malzemeIndeksi) {
    console.log(malzeme, malzemeIndeksi);
});

// console.log() fonksiyonu her bir malzeme için ayrı ayrı çalışacağından çıktı olarak tüm malzemeleri (ve indekslerini) alt alta görürüz.




//Map foreach benzer bir dizideki sayıların 5 katından oluşan başka bir dizi oluşturalım:

const sayilar = [1,2,3];
let sayilarin5kati = sayilar.map(function(sayi) {
    return sayi*5;
});
console.log(sayilarin5kati);
// Çıktı olarak [5,10,15] görmeyi bekleriz.
console.log(sayilar);
// Çıktı olarak [1,2,3] görmeyi bekleriz. Orijinal dizimiz aynı kalır.





const sayilar2 = [3,5,2,10,4];
sayilar2.sort();
console.log(sayilar2);
// Çıktı olarak [10, 2, 3, 4, 5] alırız. 
//(Sayıların string halleri UTF-16 değerlerine göre sıralandıkları için)



const sayilar3 = [4,5,6,7];
const bulunacakEleman1 = sayilar3.find(function(sayi) {
    return sayi === 5;
});
console.log(bulunacakEleman1);
// Dizi içerisinde 5 eleman olarak bulunduğu için çıktıda elemanın kendisini yani 5 görmeyi bekleriz.
const bulunacakEleman2 = sayilar3.find(function(sayi) {
    return sayi > 5;
});
console.log(bulunacakEleman2);
// Dizi içerisinde 5'ten büyük birden fazla eleman olduğu için koşula uyan ilk elemanı yani 6'yı görmeyi bekleriz.
const bulunacakEleman3 = sayilar3.find(function(sayi) {
    return sayi < 3;
});
console.log(bulunacakEleman3);
// Dizi içerisinde 3'ten küçük bir eleman olmadığı için çıktıda undefined görmeyi bekleriz.




const sayilar4 = [4,5,6];
// sonucu görebilmek çıktıyı sonuc adlı değişkende tutalım:
const sonuc1 = sayilar4.some(function(sayi) {
    return sayi > 5 ;
});
console.log(sonuc1);
// Dizi içerisinde 5'ten büyük bir eleman bulunduğu için çıktıda "true" görmeyi bekleriz.
const sonuc2 = sayilar4.some(function(sayi) {
    return sayi <3;
});
console.log(sonuc2);
// Dizi içerisinde 3'ten küçük herhangi bir sayı olmadığı için çıktıda "false" görmeyi bekleriz.