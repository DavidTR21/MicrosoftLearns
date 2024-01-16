// El programa realizará una tirada de tres dados, cuyos valores almacenaremos.
// Si la suma del total de sus valores es mayor a 14, devolverá un mensaje de victoria. De lo contrario, un mensaje de derrota.

// Creamos el objeto dice como una nueva instancia Random
Random dice = new Random();

// Generamos las variables que almacenarán los resultados de las tiradas de dados.
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Se suman las tiradas y se pasa por consola el resultado
int total = roll1 + roll2 + roll3;


Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Expresiones booleanas para determinar el curso de acción que debe seguir el programa, indicadas en un bloque de código

// Las "||" son el literal "o"
//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    Console.WriteLine("You rolled doubles! +2 bonus to total!");
//    total += 2;
//}

// Las "&&" son el literal "y"
//if ((roll1 == roll2) && (roll2 == roll3))
//{
//    Console.WriteLine("You rolled triples! +6 to total!");
//    total += 6;
//}

// Anidamos las expresiones anteriores

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}