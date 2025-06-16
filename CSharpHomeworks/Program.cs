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

#region Homework8

using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
	public class Debtor
	{
		public Debtor(string fullname, DateTime birthDay, string phone, string email, string address, int debt)
		{
			this.FullName = fullname;
			this.BirthDay = birthDay;
			this.Phone = phone;
			this.Email = email;
			this.Address = address;
			this.Debt = debt;
		}

		public string FullName { get; set; }
		public DateTime BirthDay { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public int Debt { get; set; }
		public override string ToString()
		{
			return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}";
		}
	}

	internal class Program
	{
		private static List<Debtor> debtors = new List<Debtor> {
			new Debtor("Shirley T. Qualls", DateTime.Parse("March 30, 1932"), "530-662-7732", "ShirleyTQualls@teleworm.us", "3565 Eagles Nest Drive Woodland, CA 95695", 2414),
			new Debtor("Danielle W. Grier", DateTime.Parse("October 18, 1953"), "321-473-4178", "DanielleWGrier@rhyta.com", "1973 Stoneybrook Road Maitland, FL 32751", 3599),
			new Debtor("Connie W. Lemire", DateTime.Parse("June 18, 1963"), "828-321-3751", "ConnieWLemire@rhyta.com", "2432 Hannah Street Andrews, NC 28901", 1219),
			new Debtor("Coy K. Adams", DateTime.Parse("March 1, 1976"), "410-347-1307", "CoyKAdams@dayrep.com", "2411 Blue Spruce Lane Baltimore, MD 21202", 3784),
			new Debtor("Bernice J. Miles", DateTime.Parse("June 1, 1988"), "912-307-6797", "BerniceJMiles@armyspy.com", "4971 Austin Avenue Savannah, GA 31401", 4060),
			new Debtor("Bob L. Zambrano", DateTime.Parse("February 28, 1990"), "706-446-1649", "BobLZambrano@armyspy.com", "2031 Limer Street Augusta, GA 30901", 6628),
			new Debtor("Adam D. Bartlett", DateTime.Parse("May 6, 1950"), "650-693-1758", "AdamDBartlett@rhyta.com", "2737 Rardin Drive San Jose, CA 95110", 5412),
			new Debtor("Pablo M. Skinner", DateTime.Parse("August 26, 1936"), "630-391-2034", "PabloMSkinner@armyspy.com", "16 Fraggle Drive Hickory Hills, IL 60457", 11097),
			new Debtor("Dorothy J. Brown", DateTime.Parse("July 9, 1971"), "270-456-3288", "DorothyJBrown@rhyta.com", "699 Harper Street Louisville, KY 40202", 7956),
			new Debtor("Larry A. Miracle", DateTime.Parse("May 22, 1998"), "301-621-3318", "LarryAMiracle@jourrapide.com", "2940 Adams Avenue Columbia, MD 21044", 7150),
			new Debtor("Donna B. Maynard", DateTime.Parse("January 26, 1944"), "520-297-0575", "DonnaBMaynard@teleworm.us", "4821 Elk Rd Little Tucson, AZ 85704", 2910),
			new Debtor("Jessica J. Stoops", DateTime.Parse("April 22, 1989"), "360-366-8101", "JessicaJStoops@dayrep.com", "2527 Terra Street Custer, WA 98240", 11805),
			new Debtor("Audry M. Styles", DateTime.Parse("February 7, 1937"), "978-773-4802", "AudryMStyles@jourrapide.com", "151 Christie Way Marlboro, MA 01752", 1001),
			new Debtor("Violet R. Anguiano", DateTime.Parse("November 4, 1958"), "585-340-7888", "VioletRAnguiano@dayrep.com", "1460 Walt Nuzum Farm Road Rochester, NY 14620", 9128),
			new Debtor("Charles P. Segundo", DateTime.Parse("October 21, 1970"), "415-367-3341", "CharlesPSegundo@dayrep.com", "1824 Roosevelt Street Fremont, CA 94539", 5648),
			new Debtor("Paul H. Sturtz", DateTime.Parse("September 15, 1944"), "336-376-1732", "PaulHSturtz@dayrep.com", "759 Havanna Street Saxapahaw, NC 27340", 10437),
			new Debtor("Doris B. King", DateTime.Parse("October 10, 1978"), "205-231-8973", "DorisBKing@rhyta.com", "3172 Bedford Street Birmingham, AL 35203", 7230),
			new Debtor("Deanna J. Donofrio", DateTime.Parse("April 16, 1983"), "952-842-7576", "DeannaJDonofrio@rhyta.com", "1972 Orchard Street Bloomington, MN 55437", 515),
			new Debtor("Martin S. Malinowski", DateTime.Parse("January 17, 1992"), "765-599-3523", "MartinSMalinowski@dayrep.com", "3749 Capitol Avenue New Castle, IN 47362", 1816),
			new Debtor("Melissa R. Arner", DateTime.Parse("May 24, 1974"), "530-508-7328", "MelissaRArner@armyspy.com", "922 Hill Croft Farm Road Sacramento, CA 95814", 5037),
			new Debtor("Kelly G. Hoffman", DateTime.Parse("September 22, 1969"), "505-876-8935", "KellyGHoffman@armyspy.com", "4738 Chapmans Lane Grants, NM 87020", 7755),
			new Debtor("Doyle B. Short", DateTime.Parse("June 15, 1986"), "989-221-4363", "DoyleBShort@teleworm.us", "124 Wood Street Saginaw, MI 48607", 11657),
			new Debtor("Lorrie R. Gilmore", DateTime.Parse("December 23, 1960"), "724-306-7138", "LorrieRGilmore@teleworm.us", "74 Pine Street Pittsburgh, PA 15222", 9693),
			new Debtor("Lionel A. Cook", DateTime.Parse("April 16, 1972"), "201-627-5962", "LionelACook@jourrapide.com", "29 Goldleaf Lane Red Bank, NJ 07701", 2712),
			new Debtor("Charlene C. Burke", DateTime.Parse("January 18, 1990"), "484-334-9729", "CharleneCBurke@armyspy.com", "4686 Renwick Drive Philadelphia, PA 19108", 4016),
			new Debtor("Tommy M. Patton", DateTime.Parse("June 30, 1981"), "774-571-6481", "TommyMPatton@rhyta.com", "748 Rockford Road Westborough, MA 01581", 349),
			new Debtor("Kristin S. Bloomer", DateTime.Parse("June 16, 1944"), "443-652-0734", "KristinSBloomer@dayrep.com", "15 Hewes Avenue Towson, MD 21204", 9824),
			new Debtor("Daniel K. James", DateTime.Parse("November 10, 1997"), "801-407-4693", "DanielKJames@rhyta.com", "3052 Walton Street Salt Lake City, UT 84104", 8215),
			new Debtor("Paula D. Henry", DateTime.Parse("September 6, 1976"), "618-378-5307", "PaulaDHenry@rhyta.com", "3575 Eagle Street Norris City, IL 62869", 5766),
			new Debtor("Donna C. Sandoval", DateTime.Parse("December 13, 1947"), "540-482-5463", "DonnaCSandoval@rhyta.com", "675 Jehovah Drive Martinsville, VA 24112", 8363),
			new Debtor("Robert T. Taylor", DateTime.Parse("August 17, 1932"), "270-596-6442", "RobertTTaylor@armyspy.com", "2812 Rowes Lane Paducah, KY 42001", 7785),
			new Debtor("Donna W. Alamo", DateTime.Parse("December 9, 1948"), "978-778-2533", "DonnaWAlamo@teleworm.us", "4367 Christie Way Marlboro, MA 01752", 10030),
			new Debtor("Amy R. Parmer", DateTime.Parse("May 19, 1995"), "480-883-4934", "AmyRParmer@armyspy.com", "85 Elmwood Avenue Chandler, AZ 85249", 5347),
			new Debtor("Newton K. Evans", DateTime.Parse("October 8, 1986"), "303-207-9084", "NewtonKEvans@rhyta.com", "3552 Columbia Road Greenwood Village, CO 80111", 9838),
			new Debtor("Kathleen C. Chaney", DateTime.Parse("January 5, 1949"), "605-245-3513", "KathleenCChaney@rhyta.com", "316 Elsie Drive Fort Thompson, SD 57339", 1672),
			new Debtor("Manuel C. Johnson", DateTime.Parse("February 23, 1957"), "606-247-2659", "ManuelCJohnson@jourrapide.com", "4146 May Street Sharpsburg, KY 40374", 9195),
			new Debtor("Carla A. Creagh", DateTime.Parse("November 21, 1988"), "614-307-8974", "CarlaACreagh@dayrep.com", "3106 Bates Brothers Road Columbus, OH 43215", 11271),
			new Debtor("Norma M. New", DateTime.Parse("May 18, 1988"), "857-492-8703", "NormaMNew@jourrapide.com", "965 Metz Lane Woburn, MA 01801", 9761),
			new Debtor("Roy D. Green", DateTime.Parse("January 27, 1983"), "308-340-5981", "RoyDGreen@jourrapide.com", "401 Romrog Way Grand Island, NE 68801", 10771),
			new Debtor("Cristy J. Jensen", DateTime.Parse("November 2, 1935"), "440-626-9550", "CristyJJensen@jourrapide.com", "2177 Harley Vincent Drive Cleveland, OH 44113", 5205),
			new Debtor("Nancy J. Fergerson", DateTime.Parse("June 10, 1993"), "219-987-8498", "NancyJFergerson@dayrep.com", "3584 Jadewood Drive Demotte, IN 46310", 1276),
			new Debtor("Dave N. Rodriguez", DateTime.Parse("January 21, 1938"), "214-540-2499", "DaveNRodriguez@rhyta.com", "1890 Poco Mas Drive Dallas, TX 75247", 9132),
			new Debtor("James E. Denning", DateTime.Parse("May 4, 1988"), "504-289-8640", "JamesEDenning@jourrapide.com", "1444 Rose Avenue Metairie, LA 70001", 8176),
			new Debtor("Richard M. Thomas", DateTime.Parse("February 13, 1972"), "510-735-3359", "RichardMThomas@jourrapide.com", "4454 Green Avenue Oakland, CA 94609", 7875),
			new Debtor("Lakisha R. Forrest", DateTime.Parse("December 1, 1973"), "334-830-1181", "LakishaRForrest@armyspy.com", "3121 Quarry Drive Montgomery, AL 36117", 3088),
			new Debtor("Pamela H. Beauchamp", DateTime.Parse("November 20, 1959"), "801-559-6347", "PamelaHBeauchamp@jourrapide.com", "3239 Tori Lane Salt Lake City, UT 84104", 6588)
		};

		public static void Main()
		{
		    var vowels = new[] { 'A', 'E', 'I', 'O', 'U' };
		    var now = DateTime.Now;

		    // 1. Name starts with a vowel
		    var q1 = debtors.Where(d => vowels.Contains(d.FullName[0]));
		    Console.WriteLine("1. Names starting with a vowel:");
		    foreach (var d in q1) Console.WriteLine(d);

		    // 2. Email ends with @rhyta.com or @dayrep.com
		    var q2 = debtors.Where(d => d.Email.EndsWith("@rhyta.com") || 
		                                d.Email.EndsWith("@dayrep.com"));
		    Console.WriteLine("\n2. Emails ending with rhyta.com or dayrep.com:");
		    foreach (var d in q2) Console.WriteLine(d);

		    // 3. Age between 26 and 36
		    var q3 = debtors.Where(d =>
		    {
		        int age = now.Year - d.BirthDay.Year;
		        if (d.BirthDay > now.AddYears(-age)) age--;
		        return age >= 26 && age <= 36;
		    });
		    Console.WriteLine("\n3. Age between 26 and 36:");
		    foreach (var d in q3) Console.WriteLine(d);

		    // 4. Debt <= 5000
		    var q4 = debtors.Where(d => d.Debt <= 5000);
		    Console.WriteLine("\n4. Debt less than or equal to 5000:");
		    foreach (var d in q4) Console.WriteLine(d);

		    // 5. Full name > 18 characters and phone contains at least two '7'
		    var q5 = debtors.Where(d => d.FullName.Length > 18 && 
		                                d.Phone.Count(c => c == '7') >= 2);
		    Console.WriteLine("\n5. Long full name and at least two '7's in phone:");
		    foreach (var d in debtors)
		    {
			    int sevens = d.Phone.Count(c => c == '7');
			    Console.WriteLine($"[{d.FullName}] len={d.FullName.Length}, 7s={sevens}");
		    }

		    // 6. Even age, sorted by digit sum of birth year
		    var q6 = debtors.Where(d =>
		    {
		        int age = now.Year - d.BirthDay.Year;
		        if (d.BirthDay > now.AddYears(-age)) age--;
		        return age % 2 == 0;
		    })
		    .OrderBy(d => d.BirthDay.Year.ToString().Sum(c => c - '0'));
		    Console.WriteLine("\n6. Even age, sorted by digit sum of birth year:");
		    foreach (var d in q6) Console.WriteLine(d);

		    // 7. Born in winter, sorted by postal code (last 5 digits in Address)
		    var q7 = debtors.Where(d => new[] { 12, 1, 2 }.Contains(d.BirthDay.Month))
		        .OrderBy(d =>
		        {
		            string address = d.Address;
		            string postalCode = address.Length >= 5 ? address.Substring(address.Length - 5) : "99999";
		            return int.TryParse(postalCode, out int code) ? code : int.MaxValue;
		        });
		    Console.WriteLine("\n7. Born in winter, sorted by postal code:");
		    foreach (var d in q7) Console.WriteLine(d);

		    // 8. Debt above average, sorted by surname and descending debt
		    var avgDebt = debtors.Average(d => d.Debt);
		    var q8 = debtors.Where(d => d.Debt > avgDebt)
		        .OrderBy(d => d.FullName.Split(' ').Last())
		        .ThenByDescending(d => d.Debt);
		    Console.WriteLine($"\n8. Debt above average ({avgDebt:F2}), sorted:");
		    foreach (var d in q8) Console.WriteLine(d);

		    // 9. No '8' in phone, output surname, age, debt
		    var q9 = debtors.Where(d => !d.Phone.Contains('8'))
		        .Select(d =>
		        {
		            int age = now.Year - d.BirthDay.Year;
		            if (d.BirthDay > now.AddYears(-age)) age--;
		            return new { Surname = d.FullName.Split(' ').Last(), Age = age, d.Debt };
		        });
		    Console.WriteLine("\n9. No '8' in phone number:");
		    foreach (var x in q9) Console.WriteLine($"{x.Surname}, Age={x.Age}, Debt={x.Debt}");

		    // 10. Longest surname among those with the shortest first name
		    var shortest = debtors.Min(d => d.FullName.Split(' ')[0].Length);
		    var best = debtors.Where(d => d.FullName.Split(' ')[0].Length == shortest)
		        .OrderByDescending(d => d.FullName.Split(' ').Last().Length)
		        .FirstOrDefault();
		    Console.WriteLine("\n10. Longest surname among shortest first names:");
		    Console.WriteLine(best);

		    // 11. Most common email domain
		    var topEmailDomain = debtors
			    .Where(d => d.Email.Contains("@"))
			    .Select(d => d.Email.Split('@')[1].Trim().ToLower())
			    .GroupBy(domain => domain)
			    .OrderByDescending(g => g.Count())
			    .FirstOrDefault();

			Console.WriteLine($"11. Most common email domain: {topEmailDomain.Key} ({topEmailDomain.Count()} times)");
			
		    // 12. Born before 2nd September 1945
		    var q12 = debtors.Where(d => d.BirthDay <= new DateTime(1945, 9, 2))
		        .Select(d => d.FullName);
		    Console.WriteLine("\n12. Born before WWII ended (02/09/1945):");
		    foreach (var n in q12) Console.WriteLine(n);

		    // 13. Born after 26th December 1991
		    var q13 = debtors.Where(d => d.BirthDay > 
		                                 new DateTime(1991, 12, 26))
		        .Select(d =>
		        {
		            int age = now.Year - d.BirthDay.Year;
		            if (d.BirthDay > now.AddYears(-age)) age--;
		            return new { Surname = d.FullName.Split(' ').Last(), Age = age };
		        });
		    Console.WriteLine("\n13. Born after 26/12/1991:");
		    foreach (var x in q13) Console.WriteLine($"{x.Surname}, Age={x.Age}");

		    // 14. Most frequent birth year
		    var mostCommonYear = debtors
			    .GroupBy(d => d.BirthDay.Year)
			    .OrderByDescending(g => g.Count())
			    .FirstOrDefault();
		    Console.WriteLine($"14. Most frequent birth year: {mostCommonYear.Key} ({mostCommonYear.Count()} times)");

		    // 15. Full name contains letters to form "smile"
		    var target = "smile";
		    var q15 = debtors.Where(d =>
		        target.All(c => d.FullName.ToLower().Count(ch => ch == c) 
		                        >= target.Count(x => x == c)))
		        .Select(d => d.FullName);
		    Console.WriteLine("\n15. Can form \"smile\" from full name:");
		    foreach (var n in q15) Console.WriteLine(n);
		}

	}
}

#endregion