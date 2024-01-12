// Adición de dos valores numéricos

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Combinación de tipos de dados con conversiones implícitas de tipos

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// Añadir paréntesis para aclarar intenciones
// Es recomendable evitar cálculos + concatenaciones en una única línea de código

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Tipos de operaciones

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
decimal quotient = 7m / 5m;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Decimal quotient: " + quotient);

// Obtener el resto, de modo que sepamos si un número es divisible por otro

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// Si debemos trabajar con variales tipo int pero necesitamos que
// el resultado no se trunque, podemos realizar una conversión

int first = 7;
int second = 5;
decimal dquotient = (decimal)first / (decimal)second;
Console.WriteLine(dquotient);

// Los operadores +=, -=, *=, ++ y -- son operadores de asignación compuesta

int value = 0;     // El valor es 0.
value = value + 1; // El valor es 1.
value++;           // El valor es 2

int count = 1;

count = count + 1;
Console.WriteLine("First increment: " + count);

count +=1;
Console.WriteLine("Second increment: " + count);

count++;
Console.WriteLine("Third increment: " + count);

count = count -1;
Console.WriteLine("First decrement: " + count);

count -= 1;
Console.WriteLine("Second decrement: " + count);

count--;
Console.WriteLine("Third drecement: " + count);

// El orden de la sintaxis influye en cómo se muestran los valores

int value2 = 1;
value2++; // Se incrementa en 1 la variable
Console.WriteLine("First: " + value2);
Console.WriteLine($"Second: {value2++}"); // La variable se incrementa tras mostrar el comando
Console.WriteLine("Third: " + value2);
Console.WriteLine("Fourth: " + (++value2)); // La variable se incrementa y después se muestra el comando
