// El programa debe devolver la siguiente respuesta, dadas las variables "projectName" y "russianMessage".
// Solo se pueden usar dos veces los métodos Console.Write() o Console.WriteLine()
//
// View English output:
//  c:\Exercise\ACME\data.txt

//Посмотреть русский вывод:
//  c:\Exercise\ACME\ru-RU\data.txt

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// Solución 1
Console.WriteLine($@"View English output:
        c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}
        c:\Exercise\{projectName}\ru-RU\data.txt");

// Solución 2
Console.WriteLine($"View English output:\n\t c:\\Exercise\\{projectName}\\data.txt");
Console.WriteLine($"{russianMessage}\n\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt");