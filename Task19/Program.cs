// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReverseNum(int Number) 
   { 
    int Reverse = 0; 
    while (Number > 0) 
    { 
     Reverse = Reverse * 10 + Number % 10; 
     Number /= 10; 
    } 
   return Reverse; 
   } 
    
   Console.Write("Введите пятизначное число: "); 
   int num = Convert.ToInt32(Console.ReadLine()); 
    
   int num2 = Math.Abs(num); 
   int rev = ReverseNum(num2); 
    
//    Console.WriteLine($"Реверс числа {num} = {rev}"); 
    
   if (num2 > 9999 && num2 < 100000) 
   { 
    if (num2 == rev) 
    { 
     Console.WriteLine("Число является палиндромом"); 
     
    } 
    else 
    { 
     Console.WriteLine("Число не является палиндромом"); 
    } 
   } 
   else 
   { 
    Console.WriteLine("Число не является пятизначным"); 
   }