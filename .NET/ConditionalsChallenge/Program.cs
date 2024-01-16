// Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar 
// la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un 
// usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. 
// Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.

// Reglas
// Regla 1: El código solo debe mostrar un mensaje.

// Regla 2: Si la suscripción del usuario expira en 10 días o menos, muestre el mensaje:
// Your subscription will expire soon. Renew now!

// Regla 3: Si la suscripción del usuario expira en 5 días o menos, muestre los mensajes (sustituir _ por los dias que quedan para expirar):
// Your subscription expires in _ days.
// Renew now and save 10%!

// Regla 4: Si la suscripción del usuario expira en un día, muestre los mensajes:
// Your subscription expires within a day!
// Renew now and save 20%!

// Regla 5: Si la suscripción del usuario ha expirado, muestre el mensaje:
// Your subscription has expired.

// Regla 6: Si la suscripción del usuario no expira en 10 días o menos, no muestre ningún mensaje.

// La solución debe usar las instrucciones if e if-else independientes para implementar las reglas de negocio. 
// La instrucción if-else puede incluir varias partes else if.

using System.Runtime.CompilerServices;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

// La suscripción expira en 10 días o menos
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration > 5)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1)) // 5 o menos días, pero más de uno
    {
        discountPercentage += 10;
        Console.WriteLine($"Your suscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    }
    else if (daysUntilExpiration == 1) // Expira en un día
    {
        discountPercentage += 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
    }
    else
    {
        Console.WriteLine("Your subscription has expired.");
    }
}
// PRUEBAS
// int daysUntilExpiration = {days_here};
// Console.WriteLine($"{daysUntilExpiration}");