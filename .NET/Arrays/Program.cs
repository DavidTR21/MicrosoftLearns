// Para declarar matrices (Arrays) se indica el tipo de dato a almacenar seguido de []. "new" crea una nueva instancia del array.
// Se finaliza indicando el número de elementos que va a contener el array.

string[] fraudulentOrderIDs = new string[3];

// El primer elemento del array siempre es el 0.
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// También se pueden inicializar los valores del array de la siguiente forma
// string[] fraudulentOrderIDs = { "A123", "B456", C"789" };

// El proceso de recuperar valores de un array es similar al de invocar una variable.

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

// Se pueden invocar propiedades de los arrays, como por ejemplo la propiedad Lenght para saber el número de elementos que contiene

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");