
let btns = document.getElementsByTagName("buttom");

//debugger; //Para cuando queres dejar un breakpoint fijo.

function ejemploPrompt()
{
let texto = prompt("Ingresar texto: ");

let confirmar = confirm("Estas seguro de seguir?");

   if(confirmar) 
        hacerAlgo(texto);
   else 
        alert("Esta bien, no hago nada");
}

function validarEdad(edad)
{
    if(isNaN(edad))
    {
        return "Ingresar un numero" 
    }


    if(edad > 18)
       return "Acceso concedido";
    else
       return "Acceso denegado";

}


function hacerAlgo(texto="-ALGO")
{
   alert('HOLA22 ' + texto); 
}

function mostrarMensaje(desde, texto=hacerAlgo())
{12
   console.log(desde + ":" + texto);

}

let edad = prompt("Cargar edad: ");
alert(validarEdad(edad));