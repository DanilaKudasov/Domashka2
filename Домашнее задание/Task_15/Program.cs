﻿// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//Примеры:
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) {
    if (dayNumber == 6 || dayNumber == 7) {
         Console.WriteLine("Выходной? Да");
         }
   else Console.WriteLine("Выходной? Нет");
}

CheckingTheDayOfTheWeek(dayNumber);
