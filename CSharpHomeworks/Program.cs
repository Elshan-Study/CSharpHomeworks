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

#region Homework2

#region Task1

// while (true) 
// {
//     Console.WriteLine("Numeral System Converter:");
//     Console.WriteLine("1. Decimal -> Binary");
//     Console.WriteLine("2. Decimal -> Hexadecimal");
//     Console.WriteLine("3. Binary -> Decimal");
//     Console.WriteLine("4. Hexadecimal -> Decimal");
//     Console.WriteLine("5. Exit");
//     Console.Write("Choose an option: ");
//
//     string? choice = Console.ReadLine();
//
//     if (choice == "5")
//         break;
//
//     Console.Write("Enter a number: ");
//     string? input = Console.ReadLine();
//
//     try
//     {
//         switch (choice)
//         {
//             case "1":
//                 int decToBin = int.Parse(input);
//                 Console.WriteLine($"Result: {Convert.ToString(decToBin, 2)}");
//                 break;
//
//             case "2":
//                 int decToHex = int.Parse(input);
//                 Console.WriteLine($"Result: {Convert.ToString(decToHex, 16).ToUpper()}");
//                 break;
//
//             case "3":
//                 int binToDec = Convert.ToInt32(input, 2);
//                 Console.WriteLine($"Result: {binToDec}");
//                 break;
//
//             case "4":
//                 int hexToDec = Convert.ToInt32(input, 16);
//                 Console.WriteLine($"Result: {hexToDec}");
//                 break;
//
//             default:
//                 Console.WriteLine("Invalid option. Please try again.");
//                 break;
//         }
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Error: Invalid number format.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("Error: Number is out of range for type int.");
//     }
//
//     Console.WriteLine();
// }
//
// Console.WriteLine("Exiting program...");

#endregion

#region Task2

// Console.Write("Input word from 'zero' to 'nine': ");
// string? input = Console.ReadLine().ToLower().Trim();
//
// int number = -1;
//
// switch (input)
// {
//     case "zero":
//         number = 0;
//         break;
//     case "one":
//         number = 1;
//         break;
//     case "two":
//         number = 2;
//         break;
//     case "three":
//         number = 3;
//         break;
//     case "four":
//         number = 4;
//         break;
//     case "five":
//         number = 5;
//         break;
//     case "six":
//         number = 6;
//         break;
//     case "seven":
//         number = 7;
//         break;
//     case "eight":
//         number = 8;
//         break;
//     case "nine":
//         number = 9;
//         break;
//     default:
//         Console.WriteLine("Wrong input.");
//         return;
// }
//
// Console.WriteLine("Number: " + number);

#endregion

#region Task3

// using CSharpHomeworks;
//
// try
// {
//     ForeignPassport passport = new ForeignPassport("MP1234567", "Bagdagul Bagdagul Bagdagul Qizi", 
//         new DateTime(2020, 5, 15), "Azerbaijan");
//     Console.WriteLine(passport); 
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine("Error: " + ex.Message);
// }

#endregion

#region Task4

// static bool EvaluateExpression(string expression)
// {
//     string[] operators = { ">=", "<=", "==", "!=", ">", "<" };
//     foreach (string op in operators)
//     {
//         int index = expression.IndexOf(op);
//         if (index != -1)
//         {
//             string left = expression.Substring(0, index).Trim();
//             string right = expression.Substring(index + op.Length).Trim();
//
//             if (!int.TryParse(left, out int leftValue))
//                 throw new FormatException("The left side is not an integer.");
//
//             if (!int.TryParse(right, out int rightValue))
//                 throw new FormatException("The right side is not an integer.");
//
//             switch (op)
//             {
//                 case ">": return leftValue > rightValue;
//                 case "<": return leftValue < rightValue;
//                 case ">=": return leftValue >= rightValue;
//                 case "<=": return leftValue <= rightValue;
//                 case "==": return leftValue == rightValue;
//                 case "!=": return leftValue != rightValue;
//             }
//         }
//     }
//
//     throw new InvalidOperationException("Operator not recognized or expression format is invalid.");
// }
//
// Console.Write("Enter a logical expression (eg 3>2): ");
// string? input = Console.ReadLine().Trim();
//
// try
// {
//     bool result = EvaluateExpression(input);
//     Console.WriteLine("Result: " + result);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error: " + ex.Message);
// }

#endregion

#region Task5

// using CSharpHomeworks;
//
// try
// {
//     var account = new BankAccount("John Doe", 1000m);
//     Console.WriteLine(account); 
//
//     account.Deposit(250m);
//     account.Withdraw(150m);
//     // account.Withdraw(2000m); // ← раскомментируйте для проверки ошибки
//
//     Console.WriteLine(account);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }

#endregion

#endregion

#region Homework3

#region Task1-2

//Мы делали это задание на С++. Просто переделал под С#

// TicTacToeGame.Game.Run();
//
// namespace TicTacToeGame
// {
//     enum CellState { Empty, X, O }
//
//     struct Move
//     {
//         public int Row;
//         public int Col;
//
//         public Move(int row, int col)
//         {
//             Row = row;
//             Col = col;
//         }
//     }
//
//     static class Game
//     {
//         public static CellState[,] Board = new CellState[3, 3];
//         public static Random Rng = new Random(); //использовал класс для рандома
//         public static bool IsVsComputer;
//
//         public static void Run()
//         {
//             Console.WriteLine("Select game mode:");
//             Console.WriteLine("1 - Player vs Computer");
//             Console.WriteLine("2 - Player vs Player");
//             string? choice = Console.ReadLine();
//             IsVsComputer = choice == "1";
//
//             Console.WriteLine("Deciding who goes first...");
//             bool isPlayer1Turn = Rng.Next(2) == 0; //прочел что это метод для рандомных чисел
//
//             InitBoard();
//             PrintBoard();
//
//             while (true)
//             {
//                 if (isPlayer1Turn || !IsVsComputer)
//                     PlayerTurn(isPlayer1Turn ? CellState.X : CellState.O);
//                 else
//                     ComputerTurn(CellState.O);
//
//                 PrintBoard();
//
//                 var winner = CheckWinner();
//                 if (winner != null)
//                 {
//                     Console.WriteLine(winner == CellState.X ? "Player X wins!" : "Player O wins!");
//                     break;
//                 }
//
//                 if (IsBoardFull())
//                 {
//                     Console.WriteLine("It's a draw!");
//                     break;
//                 }
//
//                 isPlayer1Turn = !isPlayer1Turn;
//             }
//         }
//
//         public static void InitBoard()
//         {
//             for (int i = 0; i < 3; i++)
//                 for (int j = 0; j < 3; j++)
//                     Board[i, j] = CellState.Empty;
//         }
//
//         public static void PrintBoard()
//         {
//             Console.WriteLine("  0 1 2");
//             for (int i = 0; i < 3; i++)
//             {
//                 Console.Write(i + " ");
//                 for (int j = 0; j < 3; j++)
//                 {
//                     char c = Board[i, j] switch
//                     {
//                         CellState.X => 'X',
//                         CellState.O => 'O',
//                         _ => '.'
//                     };
//                     Console.Write(c + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//
//         public static void PlayerTurn(CellState symbol)
//         {
//             while (true)
//             {
//                 Console.WriteLine($"Player {symbol}, enter your move (row and column):");
//                 string? input = Console.ReadLine();
//                 if (input == null) continue;
//
//                 string[] parts = input.Split();
//                 if (parts.Length == 2 &&
//                     int.TryParse(parts[0], out int row) &&
//                     int.TryParse(parts[1], out int col) &&
//                     row >= 0 && row < 3 &&
//                     col >= 0 && col < 3 &&
//                     Board[row, col] == CellState.Empty)
//                 {
//                     Board[row, col] = symbol;
//                     break;
//                 }
//
//                 Console.WriteLine("Invalid input. Try again.");
//             }
//         }
//
//         public static void ComputerTurn(CellState symbol)
//         {
//             Console.WriteLine("Computer is thinking...");
//             while (true)
//             {
//                 int row = Rng.Next(3);
//                 int col = Rng.Next(3);
//                 if (Board[row, col] == CellState.Empty)
//                 {
//                     Board[row, col] = symbol;
//                     break;
//                 }
//             }
//         }
//
//         public static CellState? CheckWinner()
//         {
//             for (int i = 0; i < 3; i++)
//             {
//                 if (Board[i, 0] != CellState.Empty &&
//                     Board[i, 0] == Board[i, 1] &&
//                     Board[i, 1] == Board[i, 2])
//                     return Board[i, 0];
//
//                 if (Board[0, i] != CellState.Empty &&
//                     Board[0, i] == Board[1, i] &&
//                     Board[1, i] == Board[2, i])
//                     return Board[0, i];
//             }
//
//             if (Board[0, 0] != CellState.Empty &&
//                 Board[0, 0] == Board[1, 1] &&
//                 Board[1, 1] == Board[2, 2])
//                 return Board[0, 0];
//
//             if (Board[0, 2] != CellState.Empty &&
//                 Board[0, 2] == Board[1, 1] &&
//                 Board[1, 1] == Board[2, 0])
//                 return Board[0, 2];
//
//             return null;
//         }
//
//         public static bool IsBoardFull()
//         {
//             foreach (var cell in Board)
//                 if (cell == CellState.Empty)
//                     return false;
//             return true;
//         }
//     }
// }

#endregion

#region Task3-4

// using System.Text;
//
// MorseConverterApp.MorseApp.Run();
//
// namespace MorseConverterApp
// {
//     static class MorseApp
//     {
//         public static void Run()
//         {
//             Console.OutputEncoding = Encoding.UTF8;
//             Console.WriteLine("Morse Code Translator");
//             Console.WriteLine("1 - Text to Morse");
//             Console.WriteLine("2 - Morse to Text");
//             Console.Write("Choose an option: ");
//             string? choice = Console.ReadLine();
//
//             if (choice == "1")
//             {
//                 Console.Write("Enter text: ");
//                 string? text = Console.ReadLine();
//                 if (text != null)
//                 {
//                     string morse = MorseTranslator.TextToMorse(text);
//                     Console.WriteLine("Morse Code:");
//                     Console.WriteLine(morse);
//                 }
//             }
//             else if (choice == "2")
//             {
//                 Console.Write("Enter Morse code (letters separated by spaces, words by /): ");
//                 string? morse = Console.ReadLine();
//                 if (morse != null)
//                 {
//                     string text = MorseTranslator.MorseToText(morse);
//                     Console.WriteLine("Translated Text:");
//                     Console.WriteLine(text);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid choice.");
//             }
//         }
//     }
//
//     static class MorseTranslator
//     {
//         private static char[] characters = new char[]
//         {
//             'A','B','C','D','E','F','G','H','I','J','K','L',
//             'M','N','O','P','Q','R','S','T','U','V','W','X',
//             'Y','Z',
//             '0','1','2','3','4','5','6','7','8','9',
//             '.',' ',',','?','!',' '
//         };
//
//         private static string[] morseCodes = new string[]
//         {
//             ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
//             "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
//             "..-", "...-", ".--", "-..-", "-.--", "--..",
//             "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
//             ".-.-.-", "--..--", "/", "..--..", "-.-.--", "/"
//         };
//
//         public static string TextToMorse(string input)
//         {
//             input = input.ToUpper();
//             StringBuilder result = new StringBuilder();
//
//             foreach (char c in input)
//             {
//                 int index = FindCharacterIndex(c);
//                 if (index != -1)
//                 {
//                     result.Append(morseCodes[index]).Append(" ");
//                 }
//                 else
//                 {
//                     result.Append("? ");
//                 }
//             }
//
//             return result.ToString().Trim();
//         }
//
//         public static string MorseToText(string input)
//         {
//             StringBuilder result = new StringBuilder();
//             string[] words = input.Split(" / "); // Morse words
//
//             foreach (string word in words)
//             {
//                 string[] letters = word.Split(' ');
//                 foreach (string morseLetter in letters)
//                 {
//                     int index = FindMorseIndex(morseLetter);
//                     if (index != -1)
//                     {
//                         result.Append(characters[index]);
//                     }
//                     else
//                     {
//                         result.Append('?');
//                     }
//                 }
//                 result.Append(' ');
//             }
//
//             return result.ToString().Trim();
//         }
//
//         private static int FindCharacterIndex(char c)
//         {
//             for (int i = 0; i < characters.Length; i++)
//             {
//                 if (characters[i] == c)
//                     return i;
//             }
//             return -1;
//         }
//
//         private static int FindMorseIndex(string code)
//         {
//             for (int i = 0; i < morseCodes.Length; i++)
//             {
//                 if (morseCodes[i] == code)
//                     return i;
//             }
//             return -1;
//         }
//     }
// }


#endregion

#region Task5

// using Library;
//
// LibrarySystem.Run();

#endregion

#region Task6

// using static TodoApp.TaskManager;
//
// AddTask(new TodoApp.Task("Buy groceries", "Milk, Bread, Eggs"));
// AddTask(new TodoApp.Task("Fix bug", "NullReferenceException in TaskManager"));
// AddTask(new TodoApp.Task("Read book", "Learn C#"));
//
// GetTask(1)?.ChangeStatus(TodoApp.TaskStatus.InProgress);
// GetTask(2)?.ChangeStatus(TodoApp.TaskStatus.Completed);
//
// ShowTasksByStatus(TodoApp.TaskStatus.NotStarted);
// ShowTasksByStatus(TodoApp.TaskStatus.Completed);
//
// ShowAllTasks();
//
// namespace TodoApp
// {
//     enum TaskStatus
//     {
//         NotStarted,
//         InProgress,
//         Completed,
//         Deferred
//     }
//
//     class Task
//     {
//         public string Title;
//         public string Description;
//         public TaskStatus Status;
//
//         public Task(string title, string description)
//         {
//             Title = title;
//             Description = description;
//             Status = TaskStatus.NotStarted;
//         }
//
//         public void ChangeStatus(TaskStatus newStatus)
//         {
//             Status = newStatus;
//         }
//
//         public void Print()
//         {
//             Console.WriteLine($"Title: {Title}");
//             Console.WriteLine($"Description: {Description}");
//             Console.WriteLine($"Status: {Status}");
//             Console.WriteLine(new string('-', 30));
//         }
//     }
//
//     static class TaskManager
//     {
//         private const int MaxTasks = 100;
//         private static Task[] _tasks = new Task[MaxTasks];
//         private static int _taskCount = 0;
//
//         public static void AddTask(Task task)
//         {
//             if (_taskCount < MaxTasks)
//             {
//                 _tasks[_taskCount++] = task;
//             }
//             else
//             {
//                 Console.WriteLine("Task list is full.");
//             }
//         }
//
//         public static void ShowTasksByStatus(TaskStatus status)
//         {
//             Console.WriteLine($"--- Tasks with status: {status} ---");
//             for (int i = 0; i < _taskCount; i++)
//             {
//                 if (_tasks[i].Status == status)
//                 {
//                     _tasks[i].Print();
//                 }
//             }
//         }
//
//         public static void ShowAllTasks()
//         {
//             Console.WriteLine("--- All Tasks ---");
//             for (int i = 0; i < _taskCount; i++)
//             {
//                 _tasks[i].Print();
//             }
//         }
//
//         public static Task GetTask(int index)
//         {
//             if (index >= 0 && index < _taskCount)
//             {
//                 return _tasks[index];
//             }
//             return null;
//         }
//     }
// }

#endregion

#endregion

#region Homework4

#region Task1-3

// using CSharpHomeworks;
//
// MyArray test = new(new List<int>());
//
// test.Add(12);
// test.Add(21);
// test.Add(32);
// test.Add(43);
// test.Add(54);
//
// Console.WriteLine($"Less 12: {test.Less(12)}");
// Console.WriteLine($"Greater 21: {test.Greater(21)}");
// test.ShowOdd();
// test.ShowEven();
// Console.WriteLine(test.CountDistinct());
// Console.WriteLine(test.EqualToValue(32));

#endregion

#region Task4

// using CSharpHomeworks;
//
// //Я не стал создавать пример с классом Радио так как логика у них была бы похожая
//
// var tv = new Tv(100);
// tv.SetChannel(5);      
// tv.TurnOn();           
// tv.SetChannel(101);    
// tv.SetChannel(5);      
// Console.WriteLine(tv.CurrentChannel()); 
//
// class Tv : IRemoteControl
// {
//     private readonly int _channelCount;
//     private bool _status = false;
//     private int _currentChannel = 1;
//     
//     public Tv(int channelCount)
//     {
//         if (channelCount <= 0)
//             throw new ArgumentException("Channel count must be greater than 0");
//
//         _channelCount = channelCount;
//     }
//     
//     public void TurnOn()
//     {
//         _status = true;
//         Console.WriteLine("Turned on");
//     }
//
//     public void TurnOff()
//     {
//         _status = false;
//         Console.WriteLine("Turned off");
//     }
//
//     public void SetChannel(int channel)
//     {
//         if (!_status)
//         {
//             Console.WriteLine("TV is off");
//             return;
//         }
//
//         if (channel < 1 || channel > _channelCount)
//         {
//             Console.WriteLine("Channel not found");
//             return;
//         }
//
//         _currentChannel = channel;
//         Console.WriteLine($"Channel changed to {channel}");
//     }
//
//     public int CurrentChannel()
//     {
//         return _currentChannel;
//     }
// }

#endregion

#region Task5

// using CSharpHomeworks;
//
// IValidator passwordValidator = new PasswordValidator("StrongP4ss");
// IValidator emailValidator = new EmailValidator("user@example.com");
//
// Console.WriteLine($"Password valid: {passwordValidator.Validate()}");
// Console.WriteLine($"Email valid: {emailValidator.Validate()}");
//
// public class PasswordValidator : IValidator
// {
//     private readonly string _password;
//
//     public PasswordValidator(string password)
//     {
//         _password = password;
//     }
//
//     public bool Validate()
//     {
//         if (string.IsNullOrWhiteSpace(_password)) return false;
//         if (_password.Length < 8) return false;
//         if (!_password.Any(char.IsDigit)) return false;
//         if (!_password.Any(char.IsUpper)) return false;
//
//         return true;
//     }
// }
//
// public class EmailValidator : IValidator
// {
//     private readonly string _email;
//
//     public EmailValidator(string email)
//     {
//         _email = email;
//     }
//
//     public bool Validate()
//     {
//         if (string.IsNullOrWhiteSpace(_email)) return false;
//
//         try
//         {
//             var addr = new System.Net.Mail.MailAddress(_email);
//             return addr.Address == _email;
//         }
//         catch
//         {
//             return false;
//         }
//     }
// }

#endregion
#endregion

#region Homework5
// using System.Text.Json;
//
// string apiKey = "4fde8f5f4d4d3c04d20cf7bfbeb76e17";
// IWeatherService weatherService = new OpenWeatherMapService(apiKey);
//
// Console.Write("Input city: ");
// string? city = Console.ReadLine();
//
// if (!string.IsNullOrWhiteSpace(city))
// {
//     string result = weatherService.GetWeather(city);
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("City name cannot be empty.");
// }
//
//
// public interface IWeatherService
// {
//     string GetWeather(string city);
// }
//
// public class OpenWeatherMapService : IWeatherService
// {
//     private readonly string _apiKey;
//
//     public OpenWeatherMapService(string apiKey)
//     {
//         _apiKey = apiKey;
//     }
//
//     public string GetWeather(string city)
//     {
//         string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric&lang=en";
//
//         using HttpClient client = new HttpClient();
//
//         try
//         {
//             string jsonResponse = client.GetStringAsync(url).GetAwaiter().GetResult();
//
//             using JsonDocument doc = JsonDocument.Parse(jsonResponse);
//             var root = doc.RootElement;
//
//             var temp = root.GetProperty("main").GetProperty("temp").GetDouble();
//             var weatherDescription = root.GetProperty("weather")[0].GetProperty("description").GetString();
//
//             return $"Weather in city {city}: {weatherDescription}, temperature {temp}°C";
//         }
//         catch (HttpRequestException e)
//         {
//             return "Error: " + e.Message;
//         }
//         catch (Exception e)
//         {
//             return "Error: " + e.Message;
//         }
//     }
// }

#endregion

#region Homework6

// using System;
// using System.Collections.Generic;
//
// Sensor sensor = new();
// Dictionary<string, SensorHandler> subscribers = new();
//
// void AddSubscriber()
// {
//     Console.WriteLine("\nSelect subscriber type:");
//     Console.WriteLine("1. Logger");
//     Console.WriteLine("2. Alert when value is high (>70)");
//     Console.WriteLine("3. Reaction to zero");
//     Console.Write("Input number: ");
//     string type = Console.ReadLine();
//
//     string id = Guid.NewGuid().ToString();
//
//     switch (type)
//     {
//         case "1":
//             SensorHandler logger = (value) =>
//                 Console.WriteLine($"[LOG]: Value changed to {value}");
//             subscribers[id] = logger;
//             sensor.Handlers += logger;
//             Console.WriteLine("Subscriber 'Logger' added.");
//             break;
//
//         case "2":
//             SensorHandler alert = (value) =>
//             {
//                 if (value > 70)
//                     Console.WriteLine($"[ALERT]: Warning! High value: {value}");
//             };
//             subscribers[id] = alert;
//             sensor.Handlers += alert;
//             Console.WriteLine("Subscriber 'Notification' added.");
//             break;
//
//         case "3":
//             SensorHandler zeroReaction = (value) =>
//             {
//                 if (value == 0)
//                     Console.WriteLine($"[REACTION]: Null value detected!");
//             };
//             subscribers[id] = zeroReaction;
//             sensor.Handlers += zeroReaction;
//             Console.WriteLine("Subscriber 'Reaction to Zero' added.");
//             break;
//
//         default:
//             Console.WriteLine("Invalid subscriber type.");
//             break;
//     }
// }
//
// void RemoveSubscriber()
// {
//     Console.WriteLine("\nCurrent subscribers:");
//     var keys = new List<string>(subscribers.Keys);
//
//     if (keys.Count == 0)
//     {
//         Console.WriteLine("[No subscribers]");
//         return;
//     }
//
//     for (int i = 0; i < keys.Count; i++)
//     {
//         Console.WriteLine($"{i + 1}. {keys[i]}");
//     }
//
//     Console.Write("Enter subscriber number to delete: ");
//     if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= keys.Count)
//     {
//         string key = keys[index - 1];
//         sensor.Handlers -= subscribers[key];
//         subscribers.Remove(key);
//         Console.WriteLine("Subscriber deleted.");
//     }
//     else
//     {
//         Console.WriteLine("Invalid input.");
//     }
// }
//
// void SetSensorValue()
// {
//     Console.Write("\nEnter new sensor value: ");
//     if (int.TryParse(Console.ReadLine(), out int newValue))
//     {
//         sensor.SetValue(newValue);
//     }
//     else
//     {
//         Console.WriteLine("Wrong input.");
//     }
// }
//
// void ShowSubscribers()
// {
//     Console.WriteLine("\nList of subscribers:");
//     if (subscribers.Count == 0)
//     {
//         Console.WriteLine("[EMPTY]");
//         return;
//     }
//
//     int i = 1;
//     foreach (var pair in subscribers)
//     {
//         Console.WriteLine($"{i++}. {pair.Key}");
//     }
// }
//
// bool running = true;
// while (running)
// {
//     Console.WriteLine("\nSelect a command:");
//     Console.WriteLine("1. Add a subscriber");
//     Console.WriteLine("2. Remove subscriber");
//     Console.WriteLine("3. Set new value");
//     Console.WriteLine("4. Show list of subscribers");
//     Console.WriteLine("5. Exit");
//     Console.Write("Enter command number: ");
//     string input = Console.ReadLine();
//
//     switch (input)
//     {
//         case "1":
//             AddSubscriber();
//             break;
//         case "2":
//             RemoveSubscriber();
//             break;
//         case "3":
//             SetSensorValue();
//             break;
//         case "4":
//             ShowSubscribers();
//             break;
//         case "5":
//             running = false;
//             break;
//         default:
//             Console.WriteLine("Wrong command!");
//             break;
//     }
// }
// delegate void SensorHandler(int newValue);
//
// class Sensor
// {
//     private int _value;
//     
//     public SensorHandler Handlers;
//
//     public void SetValue(int newValue)
//     {
//         _value = newValue;
//         Handlers?.Invoke(_value);
//     }
// }

#endregion

#region Homework7
// using System.Globalization;
// using Models;
// using Services;
// using Utils;
//
// Directory.CreateDirectory("data");
//
// User? currentUser = null;
//
// void MainMenu()
// {
//     while (true)
//     {
//         Console.WriteLine("1. Login\n2. Registration\n3. Logout");
//         var choice = Console.ReadLine();
//
//         if (choice == "1")
//         {
//             Console.Write("Login: ");
//             var username = Console.ReadLine();
//             Console.Write("Password: ");
//             var password = Console.ReadLine();
//
//             currentUser = AuthService.Login(username!, password!);
//             if (currentUser != null)
//             {
//                 Console.WriteLine("Successful login!");
//                 Logger.Log($"{currentUser.Username} logged in.");
//                 DataService.LoadUserData(currentUser);
//                 UserMenu();
//             }
//             else Console.WriteLine("Incorrect data.");
//         }
//         else if (choice == "2")
//         {
//             Console.Write("Come up with a login: ");
//             var username = Console.ReadLine();
//             Console.Write("Think of a password: ");
//             var password = Console.ReadLine();
//
//             if (AuthService.Register(username!, password!))
//                 Console.WriteLine("Registration successful.");
//             else
//                 Console.WriteLine("Registration error.");
//         }
//         else if (choice == "3") break;
//     }
// }
//
// void UserMenu()
// {
//     while (true)
//     {
//         Console.WriteLine("\n1. View orders\n2. Add order\n3. Save data\n4. Load data\n5. Exit");
//         var choice = Console.ReadLine();
//
//         switch (choice)
//         {
//             case "1":
//                 ViewOrders();
//                 break;
//             case "2":
//                 AddOrder();
//                 break;
//             case "3":
//                 DataService.SaveUserData(currentUser!);
//                 Console.WriteLine("Data saved.");
//                 break;
//             case "4":
//                 DataService.LoadUserData(currentUser!);
//                 Console.WriteLine("Data loaded.");
//                 break;
//             case "5":
//                 Logger.Log($"{currentUser!.Username} logout.");
//                 return;
//         }
//     }
// }
//
// void ViewOrders()
// {
//     if (currentUser!.Orders.Count == 0)
//     {
//         Console.WriteLine("No orders.");
//         return;
//     }
//
//     for (int i = 0; i < currentUser.Orders.Count; i++)
//     {
//         var order = currentUser.Orders[i];
//         Console.WriteLine($"\nOrder #{i + 1}: {order.Title} ({order.Date.ToShortDateString()})");
//         foreach (var service in order.Services)
//             Console.WriteLine($"  - {service.Description}: {service.Price:C}");
//
//         Console.WriteLine($"Total: {order.Total:C}");
//     }
//
//     Console.WriteLine($"Total orders: {currentUser.Orders.Count}, sum: {currentUser.Orders.Sum(o => o.Total):C}");
// }
//
// void AddOrder()
// {
//     Console.Write("Order name: ");
//     var title = Console.ReadLine();
//
//     var order = new Order { Title = title! };
//     while (true)
//     {
//         Console.Write("Enter service (or 'stop'): ");
//         var desc = Console.ReadLine();
//         if (desc!.ToLower() == "stop") break;
//
//         Console.Write("Cost: ");
//         if (decimal.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, 
//                 out var price))
//         {
//             order.Services.Add(new Service { Description = desc, Price = price });
//         }
//         else
//         {
//             Console.WriteLine("Incorrect cost.");
//         }
//     }
//
//     currentUser!.Orders.Add(order);
//     Console.WriteLine("Order added.");
// }
//
// MainMenu();

#endregion