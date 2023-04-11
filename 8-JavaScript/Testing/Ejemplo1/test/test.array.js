import equal from "assert";
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
  unir
} from "../src/array.js";


let arr = [1, 4, 5, -2, 6, 10, -11];

console.log(arr);

describe('Operaciones con arrays', () => {
  it('sumar elementos', () => {
    equal(sumar(arr), 0);
  });
});


