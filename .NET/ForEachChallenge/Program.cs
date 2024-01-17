/*
Anteriormente en este módulo, nuestro objetivo era escribir código que almacenara los identificadores de pedido pertenecientes 
a pedidos potencialmente fraudulentos. Su objetivo es encontrar los pedidos fraudulentos lo antes posible y marcarlos para analizarlos
en profundidad.


El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con una frecuencia 25 veces superior 
a la normal. Deberá escribir otro código que genere el identificador de pedido para los nuevos pedidos que empiecen por la letra "B". 
El equipo antifraude lo usará para investigar más en profundidad.

1. Declare una matriz e inicialícela para que contenga los siguientes elementos:
B123
C234
A345
C15
B177
G3003
C235
B179

2. Cree una instrucción foreach para recorrer en iteración cada elemento de la matriz.

3. Informe de los identificadores de pedido que comienzan con la letra "B". 

La salida debería coincidir con la siguiente:
B123
B177
B179
*/

// Declaramos el array indicado
string[] fraudulentOrdersID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Por cada elemento dentro del array comprobamos si la cadena contiene el caracter "B"
foreach (string order in fraudulentOrdersID)
{
    if (order.Contains("B"))
    {
        Console.WriteLine($"{order}");
    }
}