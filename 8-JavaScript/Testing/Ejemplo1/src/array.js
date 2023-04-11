export function sumar(arr){
  arr.reduce( (total, num ) => {
    console.log(total);
    return total + num;
  },0)
}

export function dividir(a,b) {
  return a/b;
}

export function multiplicar(a,b) {
  return a*b;
}

export function modulo(a,b) {
  return a%b;
}




