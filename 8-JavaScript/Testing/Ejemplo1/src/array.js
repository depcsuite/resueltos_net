export function sumar(arr){
  return (
    arr.reduce( (acum, item ) =>  {
      return acum + item;
  },0))
}

export function sumar_indice_pares(arr){
  return (
    arr.reduce( (acum, item , index) => {
      return index%2 == 0 ? acum + item : acum + 0;
  },0))
}


//Usar sort
export function ordenar(arr) {
  
}

//Usar reverse
export function alrevez(arr) {
  
}

//Usar push
export function agregar(arr, elemento) {
 
}

export function extraer(arr) {
 
}

//Usar indeOf
export function buscar(arr, elemento) {
 
}

//Usar filter
export function filtar(arr, filtro) {
 
}

//Usar map
export function mapear_strings (arr, condicion ) {
 
}

//Usar split
export function separar (arr, separador ) {
 
}

//Usar join
export function unir (cadena, separador ) {
 
}

//Usar foreEach
export function duplicar (arr) {
 
}

//Usar map
export function duplicar2 (arr) {
 
}

export function combinar (arr1, arr2 ) {
 
}

//Separar en dos partes, primera cumple condicion y 
//la segunda parte no la cumple.
export function separar_array (arr,condicion) {
 
}

//arr es una array de objetos por fecha {int id, string nombre, date fecha}
export function ordenar_por_fecha (arr) {
 
}

//arr es una array de objetos por nombre {int id, string nombre, date fecha}
export function ordenar_por_nombre (arr) {
 
}

export function extraer_resto(arr){

}




