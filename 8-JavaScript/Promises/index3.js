let promiseLenta = new Promise(function(resolve, reject) {
    setTimeout(() => resolve('Termine'), 5000);
  });


promiseLenta.then(result => console.log(result))

for(var i = 0; i < 50000 ;i++)
  console.log(i + '-');



  