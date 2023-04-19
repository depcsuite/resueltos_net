let promise = new Promise(function(resolve, reject) {

    setTimeout(() => resolve(1), 1000); // (*)
  
  });


 //Promesas encadenadas 
 promise.then(function(result) { // (**)
  
    alert(result); // 1
    return result * 2;
  
  }).then(function(result) { // (***)
  
    alert(result); // 2
    return result * 2;
  
  }).then(function(result) {
  
    alert(result); // 4
    return result * 2; 
  }).then(function(result) {
  
    alert(result); // 8
    return result * 2; 
});

//Promesas encadenadas? --> No son encadenadas.
 promise.then(function(result) { // (**)
  
    alert(result); // 1
    return result * 2;
  
  });

  promise.then(function(result) { // (**)
  
    alert(result); // 1
    return result * 2;
  
  });

  promise.then(function(result) { // (**)
  
    alert(result); // 1
    return result * 2;
  
  });

  promise.then(function(result) { // (**)
  
    alert(result); // 1
    return result * 2;
  });