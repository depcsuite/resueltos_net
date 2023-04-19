//Fetch es la función que permite llamar a servicio json.
//JSON: Java Script Object Notation
//Forma de representar datos enstructurados usando notacion javascript

/* DTO en C#

public class Persona
{
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public Domicilio Domicilio {get;set;}
}

public class Domicilio
{
    public string Ciudad {get;set;}
    public int Numero {get;set;}
    public string CP {get;set;}
}

En memoria se puede representar como

public class Persona
{
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public class Domicilio
    {
        public string Ciudad {get;set;}
        public string Calle {get;set;}
        public int Numero {get;set;}
        public string CP {get;set;}
    }
}

//Creo una instancia de Persona --> Objeto

var persona = new Persons(
    Nombre = "Juan Perez",
    Edad = 53,
    Domicilio = new Domicilio(){
        Ciudad = "Azul",
        Calle =  "Av Gral Paz",
        Numero = 1456,
        CP = 5670
    }
);

*/

//Objeto de JavaScript 
var objeto = {}

var persona = {
    Nombre : "Juan Perez",
    Edad : 53,
    Domicilio :
    {
        Ciudad : "Azul",
        Calle :  "Av Gral Paz",
        Numero : 1456,
        CP : 5670
    }
}

export default persona;

console.log(edad);
console.log(nombre);


console.log(persona.Edad);
console.log(persona.Nombre);
console.log(persona.Domicilio.CP);
console.log(persona.Domicilio.Calle);
console.log(persona.Domicilio.Numero);
console.log(persona.Domicilio.Ciudad);


var persona2 = {
    Nombre : "Juan Perez",
    Edad : 53,
    Domicilio :
    {
        Ciudad : "Azul",
        Calle :  "Av Gral Paz",
        CP : 5670
    }
}

console.log(persona2.Edad);
console.log(persona2.Nombre);
console.log(persona2.Domicilio.CP);
console.log(persona2.Domicilio.Calle);
console.log(persona2.Domicilio.Numero);
console.log(persona2.Domicilio.Ciudad);