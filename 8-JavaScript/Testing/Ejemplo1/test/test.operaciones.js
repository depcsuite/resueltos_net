import equal from "assert";
import {sumar,multiplicar, dividir, modulo} from "../src/operaciones.js";


describe('Operaciones básicas', () => {
  it('suma dos números', () => {
    equal(sumar(2, 3), 5);
  });
  it('multiplica dos números', () => {
    equal(multiplicar(2, 3), 6);
  });
  it('divide dos números', () => {
    equal(dividir(2, 3), 1.5);
  });
  it('modulo de dos números coprimos', () => {
    equal(modulo(2, 3), 1);
  });
  it('modulo de dos números multiplos', () => {
    equal(modulo(12, 3), 0);
  });
});


