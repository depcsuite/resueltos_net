import { equal } from "assert";

import {
  sumar,
  agregar,
  alrevez,
  buscar,
  combinar,
  extraer,
  duplicar,
  filtar,
  mapear_strings,
  ordenar,
  ordenar_por_fecha,
  ordenar_por_nombre,
  separar,
  separar_array,
  unir,
  sumar_indice_pares,
  extraer_resto,
  duplicar2
} from "../src/array.js";


let arr = [1, 4, 5, -2, 6, 10, -11];
let personas = []; 
personas.push(
{
  nombre: "Luis",
  FechaNacimiento : '09/07/1943'
});
personas.push(
{
  nombre: "Pedro",
  FechaNacimiento : '09/07/19770'
});
personas.push(
{
  nombre: "Carlos",
  FechaNacimiento : '09/07/1960'
})
personas.push(
{
  nombre: "Sergi0",
  FechaNacimiento : '09/07/1993'
});
personas.push(
{
  nombre: "Horacio",
  FechaNacimiento : '09/07/1990'
});



console.log(arr);

describe('Operaciones con arrays', () => {
  it('sumar elementos', () => {
    equal(sumar(arr), 13);
  });
  it('sumar elementos de indice par', () => {
    equal(sumar_indice_pares(arr), 1);
  });
  it('agregar elementos al array', () => {
    equal(agregar(arr,33), [1, 4, 5, -2, 6, 10, -11,33]);
  });
  it('Da vuelta los elementos al array', () => {
    equal(alrevez(arr), [-11,10,6,-2,5,4,1]);
  });
  it('buscar un elemento -> devuelve el index de la primera ocurrencia',
   () => {
    equal(buscar(arr,10), 5);
  });
  it('buscar un elemento -> devuelve -1 si no lo encuentra',
   () => {
    equal(buscar(arr,22), -1);
  });
  it('combinar dos arreglos',  () => {
   let arr1 = [11,22,33,44,55,66]
   equal(combinar(arr,arr1), [1, 4, 5, -2, 6, 10, -11,11,22,33,44,55,66]);
 });
 it('extraer primer elemento del array', () => {
  equal(extraer(arr), 1);
});
  it('extrae primer elemento del array y devuelve el resto', () => {
    equal(extraer_resto(arr), [4, 5, -2, 6, 10, -11]);
});
it('duplicar cada elemento del array (foreEach)', () => {
  equal(duplicar(arr),[2, 8, 10, -4, 12, 20, -22]);
});
it('duplicar2 cada elemento del array (map)', () => {
  equal(duplicar2(arr), [2, 8, 10, -4, 12, 20, -22]);
});
it('filtar según condición1', () => {
  equal(filtar(arr, filtro => filtro < 6), [1, 4 , 5, -2, -11]);
});
it('filtar según condición2', () => {
  equal(filtar(arr, filtro => filtro%2 == 0),[4, -2, 6, 10]);
});
it('filtar según condición3', () => {
  equal(filtar(arr, filtro => filtro%2 != 0), [1, 5, -11]);
});
it('mapear_strings según condición3', () => {
  let str = "Hola Operaciones con Array usando mocha test frammework y Visual Studio Code en el curso de Programacion .Net 2022";
  equal(mapear_strings(str, cad => cad.length < 6 ),
       ["Hola","con","Array","mocha","test","y","Code","en","el","curso","de",".Net","2022"]);
});
it('ordenar en forma descendente ', () => {
  equal(ordenar(arr, (a,b) => b-a),[10, 6, 5, 4, 1, -2, -11] );
});  
it('ordenar en forma ascendente ', () => {
  equal(ordenar(arr, (a,b) => a-b),[-11,-2,1,4,5,6,10] );
});  
it('ordenar_por_fecha en forma descente ', () => {
 
  equal(ordenar_por_fecha(personas), ["Valor esperado"]);
});  
it('ordenar por nombre en forma ascendente', () => {
  equal(ordenar_por_nombre(personas),["Valor esperado"] );
});  
it('Separar en un array una cadena de caracteres', () => {
  let cadena = "Separar en un array una cadena de caracteres"
  equal(separar(cadena," "),["Valor esperado"] );
});  
it('Separar en un array una cadena de caracteres ', () => {
  let cadena = ["Separar","en","un","array","cadena","caracteres","amarillos","buenos aires","America"];
  equal(separar_array(cadena,condicion => condicion.length < 6),["Valor esperado"] );
});  
it('Unir una cadena de caracteres', () => {
  let cadena = "at Context.<anonymous> (file:///C:/Users/sergi/fuentes/resueltos_net/8-JavaScript/Testing/Ejemplo1/test/test.operaciones.js:19:5) at process.processImmediate (node:internal/timers:471:21)"
  equal(unir(cadena," "),["Valor esperado"] );
});  
});

 
