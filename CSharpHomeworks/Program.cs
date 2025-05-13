#region Homework1

#region Task1
//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
//остатка) нужно вывести слово Fizz. Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5 
//нужно вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число.
//Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.

/*while (true)
{
    Console.Write("Input number between 1 and 100: ");
    string? input = Console.ReadLine();
    
    if (int.TryParse(input, out int result))
    {
        if (result < 1 || result > 100)
        {
            Console.WriteLine("Incorrect input");
            continue;
        }
        
        if (result % 3 == 0 && result % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
            break;
        }
        else if (result % 3 == 0)
        {
            Console.WriteLine("Fizz");
            break;
        }
        else if (result % 5 == 0)
        {
            Console.WriteLine("Buzz");
            break;
        }
        else
        {
            Console.WriteLine(result);
            break;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input");
        continue;
    }
}*/

#endregion

#region Task2
//Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, который необходимо 
//посчитать. Например, мы ввели с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90. Результат: 9.

// while (true)
// {
//     Console.Write("Input number: ");
//     string? input1 = Console.ReadLine();
//     Console.Write("Input percent: ");
//     string? input2 = Console.ReadLine();
//
//     int number1;
//     int number2;
//     
//     if (!int.TryParse(input1, out number1)){Console.WriteLine("Incorrect input"); continue;}
//     if (!int.TryParse(input2, out number2)){Console.WriteLine("Incorrect input"); continue;}
//     if(number2 < 0){Console.WriteLine("Incorrect input"); continue;}
//     
//     Console.WriteLine("Result: {0}%", number1 * number2 / 100);
//     
//     break;
// }
#endregion

#region Task3
//Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, содержащее эти цифры. Например, если с 
//клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.

// int[] arr = new int[4];
//
// for (uint i = 0; i < arr.Length; i++)
// {
//     while (true)
//     {
//         Console.Write($"Input {i+1}-number: ");
//         string? input = Console.ReadLine();
//         if (!int.TryParse(input, out int temp)){Console.WriteLine("Incorrect input"); continue;}
//         if(temp < 1 || temp > 9){Console.WriteLine("Incorrect input"); continue;}
//         
//         arr[i] = temp;
//         break;
//     }
// }
//
// Console.Write("Your number: ");
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i]);
// }

#endregion

#region Task4
//Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр. Например, если 
//пользователь ввёл один и шесть — это значит, что надо обменять местами первую и шестую цифры.

//Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

// string? numberInput;
//
// while (true)
// {
//     Console.Write("Input a 6-digit number: ");
//     numberInput = Console.ReadLine();
//     
//     // я посмотрел в интернете, что .All(char.IsDigit) позволяет определить состоит ли число только из цифр
//     if (numberInput == null || numberInput.Length != 6 || !numberInput.All(char.IsDigit))
//     {
//         Console.WriteLine("Error: Not a 6-digit number");
//         continue;
//     }
//
//     break;
// }
//
// int[] arr = new int[6];
// for (int i = 0; i < 6; i++)
// {
//     arr[i] = numberInput[i] - '0';
// }
//
// int GetDigitPosition(string prompt)
// {
//     while (true)
//     {
//         Console.Write(prompt);
//         string? input = Console.ReadLine();
//         if (!int.TryParse(input, out int pos))
//         {
//             Console.WriteLine("Incorrect input");
//             continue;
//         }
//         if (pos < 1 || pos > 6)
//         {
//             Console.WriteLine("Incorrect input");
//             continue;
//         }
//         return pos - 1;
//     }
// }
//
// int index1 = GetDigitPosition("Enter first digit position to swap (1-6): ");
// int index2 = GetDigitPosition("Enter second digit position to swap (1-6): ");
//
// int temp2 = arr[index1];
// arr[index1] = arr[index2];
// arr[index2] = temp2;
//
// Console.Write("Result: ");
// foreach (var digit in arr)
// {
//     Console.Write(digit);
// }
// Console.WriteLine();

#endregion

#region Task5
//Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. Например, если 
//введено 22.12.2021, приложение должно отобразить Winter Wednesday.

// using System;
// using System.Globalization;
//
// DateTime date;
//
// while (true)
// {
//     Console.WriteLine("Enter a date (dd.MM.yyyy):");
//     string? input = Console.ReadLine();
//
//     //эту часть кода смотрел в интернете, так как не знал, как правильно
//     if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, 
//             DateTimeStyles.None, out date))
//     {
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Invalid date format. Please try again.");
//     }
//     //
// }
//
// string season = GetSeason(date.Month);
// string dayOfWeek = date.DayOfWeek.ToString();
//
// Console.WriteLine($"{season} {dayOfWeek}");
// string GetSeason(int month)
// {
//     if (month == 12 || month == 1 || month == 2)
//         return "Winter";
//     else if (month >= 3 && month <= 5)
//         return "Spring";
//     else if (month >= 6 && month <= 8)
//         return "Summer";
//     else
//         return "Autumn";
// }

#endregion

#region Task6
//Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит
//температуру из Фаренгейта в Цельсий или наоборот.

// string? tempInput;
// double temperature;
//
// while (true)
// {
//     Console.WriteLine("Enter temperature:");
//     tempInput = Console.ReadLine();
//     if (!double.TryParse(tempInput, out temperature))
//     {
//         Console.WriteLine("Invalid temperature input.");
//         continue;
//     }
//
//     break;
// }
//
// Console.WriteLine("Choose conversion:");
// Console.WriteLine("1 - Fahrenheit to Celsius");
// Console.WriteLine("2 - Celsius to Fahrenheit");
//
// string? choiceInput;
// int choice;
//
// while (true)
// {
//     Console.WriteLine("Enter temperature:");
//     choiceInput = Console.ReadLine();
//     if (!int.TryParse(choiceInput, out choice))
//     {
//         Console.WriteLine("Invalid choice input.");
//         continue;
//     }
//
//     break;
// }
//
// switch (choice)
// {
//     case 1:
//         double celsius = (temperature - 32) * 5 / 9;
//         Console.WriteLine("Temperature in Celsius: " + celsius);
//         break;
//     case 2:
//         double fahrenheit = (temperature * 9 / 5) + 32;
//         Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
//         break;
//     default:
//         Console.WriteLine("Invalid choice.");
//         break;
// }

#endregion

#region Task7
//Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа в указанном диапазоне. Если границы
//диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь ввел 20 и 11,
//требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.

// int start, end;
//
// while (true)
// {
//     Console.WriteLine("Enter two numbers (start and end of the range):");
//     //Тут я использовал метод Split по умолчанию, чтобы разбить строку по пробелам, использовал логику питона
//     string[]? input = Console.ReadLine().Split();
//
//     if (input.Length == 2 && int.TryParse(input[0], out start) && int.TryParse(input[1], out end))
//     {
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Invalid input. Please enter two integers.");
//     }
// }
//
// if (start > end)
// {
//     int temp = start;
//     start = end;
//     end = temp;
// }
//
// Console.WriteLine($"Even numbers between {start} and {end}:");
// for (int i = start; i <= end; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

#endregion

#region Task8
//Пользователь вводит число. Программа должна определить, является ли это число числом Армстронга (число Армстронга —
//это такое число, которое равно сумме своих цифр, возведённых в степень, равную количеству этих цифр). Например, число
//153 является числом Армстронга, так как 1^3 + 5^3 + 3^3 = 153.

// Console.WriteLine("Enter a number:");
// string input = Console.ReadLine();
// int number;
//
// if (int.TryParse(input, out number) && number >= 0)
// {
//     string numStr = number.ToString();
//     int numDigits = numStr.Length;
//     int sum = 0;
//     
//     foreach (char digit in numStr)
//     {
//         int digitValue = int.Parse(digit.ToString());
//         
//         int digitPower = 1;
//         for (int i = 0; i < numDigits; i++)
//         {
//             digitPower *= digitValue;
//         }
//
//         sum += digitPower;
//     }
//     
//     if (sum == number)
//     {
//         Console.WriteLine($"{number} is an Armstrong number.");
//     }
//     else
//     {
//         Console.WriteLine($"{number} is not an Armstrong number.");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter a valid positive integer.");
// }

#endregion

#region Task9
//Пользователь вводит число. Программа должна определить, является ли это число совершенным. Совершенное число — это
//число, которое равно сумме всех своих делителей, кроме самого себя (например, 28 = 1 + 2 + 4 + 7 + 14).

// Console.WriteLine("Enter a number:");
// string? input = Console.ReadLine();
// int number;
//
// if (int.TryParse(input, out number) && number > 0)
// {
//     int sumOfDivisors = 0;
//     
//     for (int i = 1; i <= number / 2; i++)
//     {
//         if (number % i == 0)
//         {
//             sumOfDivisors += i;
//         }
//     }
//     
//     if (sumOfDivisors == number)
//     {
//         Console.WriteLine($"{number} is a perfect number.");
//     }
//     else
//     {
//         Console.WriteLine($"{number} is not a perfect number.");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter a valid positive integer.");
// }
#endregion

#endregion