//Estamos desarrollando una calculadora de nota media global de los alumnos que ayudará a calcular el promedio global de las calificaciones de los alumnos. 
//Los parámetros de la aplicación son:

//Se nos proporciona el nombre y la información de la clase del alumno.
//Cada clase tiene un nombre, la calificación del alumno y el número de horas en créditos de esa clase.
//La aplicación debe realizar operaciones matemáticas básicas para calcular la nota media global del alumno determinado.
//La aplicación debe generar o mostrar el nombre del alumno, la información de la clase y la nota media global.
// El formato deseado debe ser el siguiente:

//Student: Sophia Johnson

//Course          Grade   Credit Hours	
//English 101         4       3
//Algebra 101         3       3
//Biology 101         3       4
//Computer Science I  3       4
//Psychology 101      4       3

//Final GPA:          3.35

// Datos proporcionados
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Declaramos los dos tipos de nota existentes y las asignamos a las asignaturas
int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// Calculamos el total de horas
int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Calculamos el total de puntos
int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;
// Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

// Calculamos GPA
float finalGPA = (float)totalGradePoints / totalCreditHours;
finalGPA = (float)System.Math.Round(finalGPA,2); // Redondeamos con el método Round para obtener solo 2 decimales

// Resultado por consola
Console.WriteLine("Student: " + studentName + "\n");
Console.WriteLine("Course:\t\t\tGrade\tCredit Hours");
Console.WriteLine(course1Name + "\t\t" + course1Grade + "\t" + course1Credit);
Console.WriteLine(course2Name + "\t\t" + course2Grade + "\t" + course2Credit);
Console.WriteLine(course3Name + "\t\t" + course3Grade + "\t" + course3Credit);
Console.WriteLine(course4Name + "\t" + course4Grade + "\t" + course4Credit);
Console.WriteLine(course5Name + "\t\t" + course5Grade + "\t" + course5Credit + "\n");
Console.WriteLine("Final GPA:\t\t" + finalGPA);