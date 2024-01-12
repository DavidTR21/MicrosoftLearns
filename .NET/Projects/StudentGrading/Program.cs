﻿// Supongamos que es auxiliar de un profesor en un colegio. Su tarea es desarrollar una
// aplicación que automatice la calificación de los alumnos. La aplicación usa todas las 
// tareas calificadas de cada alumno para calcular su calificación o nota global actual 
// para la clase. El profesor también ha proporcionado el formato necesario para informar de las calificaciones de los alumnos

// Actualmente, el libro de calificaciones de los profesores muestra las calificaciones de las tareas de cada alumno de la siguiente manera:
// Sophia: 93, 87, 98, 95, 100
// Nicolas: 80, 83, 82, 88, 85
// Zahirah:   84, 96, 73, 85, 79
// Jeong:  90, 92, 98, 100, 97

// El profesor quiere que las calificaciones calculadas de cada alumno se muestren de la siguiente manera:
// Student     Grade
// Sophia      94.6  A
// Nicolas     83.6  B
// Zahirah     83.4  B
// Jeong       95.4  A

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// variables with sum of assignments
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t{sophiaScore}\tA");
Console.WriteLine($"Nicolas:\t{nicolasScore}\tB");
Console.WriteLine($"Zahirah:\t{zahirahScore}\tB");
Console.WriteLine($"Jeong:\t\t{jeongScore}\tA");