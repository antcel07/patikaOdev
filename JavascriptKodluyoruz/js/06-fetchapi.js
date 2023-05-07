

// fetch("data/settings.json").then(
//     response =>  response.json()
// ).then(responseJson => {
//     console.log(responseJson)
//     console.log(responseJson.userName)
// }) 


// fetch('https://jsonplaceholder.typicode.com/posts')
//       .then(response => response.json())
//       .then(json => console.log(json))

      
// fetch("https://jsonplaceholder.typicode.com/posts")
// .then(response => response.json())
// .then(responseJson => {
//     responseJson.forEach(item => console.log(item))
// })


//api ile json ile dönüp li formatında dom index tarafına basmış oldum
let userListDOM=document.querySelector("#userList")

fetch("https://jsonplaceholder.typicode.com/posts")
 .then(response => response.json())
 .then(responseJson => {
     responseJson.forEach(item =>
        {
            let liDOM=document.createElement('li')
            liDOM.innerHTML=item.title
            userListDOM.appendChild(liDOM)
        })
 })

 fetch("https://jsonplaceholder.typicode.com/comments")
    .then((response) => response.json())
    .then((json) => json.forEach((item) => console.log(item.email)))
    .catch((err) => console.log(err))


   

