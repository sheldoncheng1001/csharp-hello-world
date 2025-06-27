using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你好");
            Console.WriteLine("歡迎使用 C# 程式設計!");
            
            Console.Write("請輸入您的名字: ");
            string? name = Console.ReadLine();
            name = string.IsNullOrEmpty(name) ? "訪客" : name;
            Console.WriteLine($"您好, {name}! 祝您有美好的一天!");
            
            // 添加簡單計算功能進行測試
            Console.WriteLine("\n--- 簡單計算測試 ---");
            Console.Write("請輸入一個數字: ");
            if (int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.Write("請輸入另一個數字: ");
                if (int.TryParse(Console.ReadLine(), out int number2))
                {
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                    
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("除數不能為零");
                    }
                }
                else
                {
                    Console.WriteLine("輸入無效，請輸入有效的數字");
                }
            }
            else
            {
                Console.WriteLine("輸入無效，請輸入有效的數字");
            }
            
            Console.WriteLine("\n按任意鍵結束程式...");
            Console.ReadKey();
        }
    }
}