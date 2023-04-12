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
  equal(duplicar(arr), [4, 5, -2, 6, 10, -11]);
});
it('duplicar2 cada elemento del array (map)', () => {
  equal(duplicar2(arr), [4, 5, -2, 6, 10, -11]);
});
});


