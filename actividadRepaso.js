//Punto 1

let articulos = ["Zapatos", "Tenis", "Camisetas", "Jeans"];
let precios = [350000, 280000, 175000, 200000];
let precio = 0;
let suma = 0;

for (let i = 0; i < articulos.length; i++) {
  if (
    articulos[i] === "Zapatos" ||
    articulos[i] === "Tenis" ||
    articulos[i] === "Jeans"
  ) {
    console.log(`El precio de los ${articulos[i]} es de $${precios[i]}`);
  } else if (articulos[i] === "Camisetas") {
    console.log(`El precio de las ${articulos[i]} es de $${precios[i]}`);
  }
}

for (let i = 0; i < precios.length; i++) {
  precio = precios[i];
  suma = suma + precio;
}
console.log(`El costo total de los 4 artículos es de ${suma}`);
console.log(`El promedio de la venta es de ${suma / precios.length}`);
console.log(
  `El nuevo precio de los ${articulos[0]} es de ${
    precios[0] - precios[0] * 0.008
  }`
);
console.log(
  `El nuevo precio de los ${articulos[3]} es de ${
    precios[3] + precios[3] * 0.062
  }`
);

//Punto 2

let horaDiaria = 0;
let sueldoMensual = 0;
let horasLaboradas = 0;
let horasExtras = 0;
let sueldoTotal = 0;
let tp = "";

for (var i = 1; i <= 4; i++) {
  horasLaboradas = parseFloat(prompt("Ingrese las horas diarias trabajadas"));
  tp = prompt("Ingrese el tipo de proyecto para el que trabaja (A, B, C)");

  console.log(horasLaboradas);
  console.log(tp);

  if (tp === "A" || tp === "a") {
    horaDiaria = 20000;
  } else if (tp === "B" || tp === "b") {
    horaDiaria = 10000;
  } else if (tp === "C" || tp === "c") {
    horaDiaria = 5000;
  } else {
    console.log("Ingresaste un tipo de proyecto incorrecto");
  }

  console.log(horaDiaria);
  sueldoMensual = horasLaboradas * horaDiaria * 30;
  console.log(sueldoMensual);

  if (sueldoMensual > 1500000) {
    console.log("Salario es mayor a tope máximo");
  } else if (sueldoMensual <= 1500000) {
    horasExtras = 3 * (horaDiaria * 0.06 + horaDiaria);
    console.log(horasExtras);
    sueldoMensual = sueldoMensual + horasExtras;
    console.log(sueldoMensual);
  }
}

//Punto 3

let precioHabitacion = 0;
let precioIva = 0;
let precioDescuento = 0;
let huesped = parseInt(prompt("Ingrese la cantidad de huespedes"));
let dias = parseInt(prompt("Ingrese la cantidad de días"));

if (huesped === 1) {
  precioHabitacion = dias * 2500;
  precioIva = precioHabitacion * 0.16 + precioHabitacion;
  precioDescuento = precioIva - precioIva * 0.05;
  console.log(precioHabitacion);
  console.log(precioIva);
  console.log(precioDescuento);
} else if (huesped === 2) {
  precioHabitacion = dias * 4600;
  precioIva = precioHabitacion * 0.16 + precioHabitacion;
  precioDescuento = precioIva - precioIva * 0.09;
  console.log(precioHabitacion);
  console.log(precioIva);
  console.log(precioDescuento);
} else if (huesped >= 3) {
  precioHabitacion = dias * 5200;
  precioIva = precioHabitacion * 0.16 + precioHabitacion;
  precioDescuento = precioIva - precioIva * 0.15;
  console.log(precioHabitacion);
  console.log(precioIva);
  console.log(precioDescuento);
} else {
  console.log("Ingreso una cantidad de huspedes invalida");
}
