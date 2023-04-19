

// fetch('https://jsonplaceholder.typicode.com/todos/1')
//       .then(response => response.json())
//       .then(json => {
//         console.log('El titulo es ' + json.title);
//         console.log('Completado ' + json.completed == true ? 'SI' : 'NO');
//       })
let titulos = []

// fetch('https://jsonplaceholder.typicode.com/todos')
//         .then(response => response.json())
//         .then(json => {
//             json.forEach(j => {
//                 titulos.push(j.title)
//             });
//       })

// console.log(titulos);


let productTitle = []

fetch('https://dummyjson.com/products')
        .then(response => response.json())
        .then(json => {
            
            let products = json.products;
            products.forEach(j => {
                productTitle.push(j.title)
            });
      })

console.log(productTitle);



// // 20230418203325
// // https://jsonplaceholder.typicode.com/todos/1

// {
//     "userId": 1,
//     "id": 1,
//     "title": "delectus aut autem",
//     "completed": false
//   }