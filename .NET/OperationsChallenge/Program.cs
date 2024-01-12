// En este desafío, escribirá código que utilizará una fórmula para convertir una 
// temperatura de grados Fahrenheit a Celsius. Imprimirá el resultado en un mensaje 
// con formato para el usuario.

int fahrenheit = 94;

// Para convertir de Fahrenheit a Celsius primero se resta 32 y luego se multiplica por 5/9
decimal celsius = (fahrenheit - 32m) * (5m / 9m); 

Console.WriteLine($"The temperature is: {celsius} Celsius.");