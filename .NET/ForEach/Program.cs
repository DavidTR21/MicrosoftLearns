// Declaración del array
string[] names = { "Rowena", "Robin", "Bao" };

// Se almacena el número de índice del array en una variable temporal (name) dentro del array (names)
// Por cada iteración se guarda el valor en la variable temporal y se ejecuta el código indicado
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Ejemplo con array de tipo int y operaciones
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;

/*foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");*/

// Ejemplo: variable que contenga el número del contenedor actual y que muestre la suma acumulativa
int bin = 0;

foreach (int items in inventory)
{
    bin++;
    sum += items;
    Console.WriteLine($"Bin {bin}. {items} items counted. Total inventory: {sum}");
}

Console.WriteLine($"We have {sum} items in inventory.");