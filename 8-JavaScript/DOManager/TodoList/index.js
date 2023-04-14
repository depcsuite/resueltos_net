
  let buttonTL = document.getElementById('buttonTL')
  //obtengo nodo del contendor de los li, ul
  let todo_wrapper = document.querySelector('.todo-wrapper');
  let buttonImg = document.getElementById('buttonImg')


  buttonImg.addEventListener('click', () => {


    let rowImg = document.querySelector('.rowImg');
    let divImg = document.querySelector('#divImg');

    let imgNew = document.createElement('img');
    imgNew.alt = "Nueva imagen";
    imgNew.src = "./images/img1.jpg";
    imgNew.className = "newImage";

    divImg.appendChild(imgNew);
    rowImg.appendChild(divImg);

  });

  let imgNew = document.querySelector('.newImage');

  if(imgNew !== null && imgNew !== 'undefined')
  {

    imgNew.addEventListener('click', () => {
        if(imgNew.src.contains('img1.jpg'))
        {
            imgNew.src = './images/img2.jpg';
        }
        else
        { 
        if(imgNew.src.contains('img2.jpg'))
            imgNew.src = './images/img1.jpg';
        }
    } )
}
 

  todo_wrapper.addEventListener('click', (e) => {

    if(e.target.className = 'todo'){

        let acepto = confirm('Estas seguro de borrarlo?');

        if(acepto == true)
            todo_wrapper.removeChild(e.target);
    }

  });




buttonTL.addEventListener('click',() => {
    let userInput = document.querySelector('#userInput');

    if(userInput === null || userInput === 'undefined')
    {
        console.log('userInput es invalido');  
    }
    else
    
    {
        if(userInput.value.length <= 3)
        {
            alert("El input debe ser de al menos 3 caracteres");
        }
        else
        {
            //console.log(userInput.value);
            let li = document.createElement('li')
            li.className = 'todo';

            let nodo = document.createTextNode(userInput.value);

            li.appendChild(nodo);

            todo_wrapper.appendChild(li);

        }
    }
});