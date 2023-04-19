
// ¿Cuál es el resultado del código a continuación?

let promise = new Promise(function(resolve, reject) {
    setTimeout(() => resolve(2), 1000);
    resolve(1);
  });
   
//promise.then(alert);


//setTimeout usando promesas
function delay(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

delay(10000).then(() => alert('runs after 10 seconds'));
    

//Resuleve el forma inmediata.
let promiseOK = new Promise(function(resolve, reject){
   setTimeout(() => {
      resolve("OK, me fue de 10!!")
   }, 2000); 
})

//La promesa devuelve un error.
 let promiseError = new Promise(function(resolve, reject) {
    // después de 1 segundo, indica que la tarea ha finalizado con un error
    setTimeout(() => reject(new Error("¡Vaya!")), 2000);
  });
  
  //Consumir de promesas usa then (equivalente al try), catch y el finally
//   try{
//     //Ejecutar tu código
//   }
//   catch(e)
//   {
//     //Hubo error --> en e esta la info del error.
//   }
//   finally{
//     //Se ejecuta cuando termina el bloque try sea por ok o por error.
//   }


//En result esta la respuesta de la promesa-
promiseOK.then(
    result => console.log(result),
    error => console.log(error)
)

promiseError.then(
    result => console.log(result),
    error => console.log(error)
)
// //Si solo me interesa la respuesta OK
// promiseOK.then(result => alert(result))

// promiseError.catch(result => alert(result))