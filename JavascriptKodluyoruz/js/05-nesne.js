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

let laptop1={
    brand: "Apple",
    model: "MacBook Pro",
    "2kg": 2,
    modelName: "MacbookPro"
}

console.log(laptop1)
console.log(laptop1.brand , laptop1["brand"])
console.log(laptop1.model , laptop1["model"])
console.log(laptop1["2kg"])

//anahtar bilgisine yeni değer ekleme
laptop1.brand="Mac"
laptop1["brand"]="Mac1"
console.log(laptop1)

//yeni bilgi eklemek 
laptop1.version="10.15.7"
console.log(laptop1)

//anahtar bilgilerine ulaşmak(keys) --> object.keys(item)
keys=Object.keys(laptop1)
console.log(keys)
console.log(Object.keys(laptop1))



keys.forEach(keyInfo => {
     console.log(keyInfo)
     console.log(laptop1[keyInfo])
})

console.log(
    Object.values(laptop1)
)

let values=Object.values(laptop1)

values.forEach(value=>{
    console.log(value)
    console.log(laptop1[keyInfo])
}
    )



