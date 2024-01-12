// Unión de cadena literal y variable

string firstName = "Bob";
string message1 = "Hello " + firstName;
Console.WriteLine(message1);

// Unión de varias cadenas variales y cadenas literales

string greeting = "Hello";
string message2 = greeting + " " + firstName + "!";
Console.WriteLine(message2);

// Sin variable intermedia

Console.WriteLine(greeting + " " + firstName + "!");

// Interpolación de cadenas

string message3 = $"{greeting} {firstName}!";
Console.WriteLine(message3);

// Se pueden interpolar diferentes tipos de variable

int version = 11;
string updateText = "Update to Windows";
string message4 = $"{updateText} {version}";
Console.WriteLine(message4);

// Literales textuales + interpolación

string projectName = "Frist-Project";
Console.WriteLine($@"C:\Output\{projectName}\Files");