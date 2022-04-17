using System.Text;

// IsDigit является ли числом
// Append добавить чар в стринг билдер
// \b \b удалить крайний символ в консоле
// stringBuilder.ToString(); вернуть строку
//  stringBuilder.Clear();

//while (true)
//{
//    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
//    if (char.IsDigit(consoleKeyInfo.KeyChar))
//    {
//        stringBuilder.Append(consoleKeyInfo.KeyChar);
//        Console.Write(consoleKeyInfo.KeyChar);
//    }
//    else if (consoleKeyInfo.Key == ConsoleKey.Backspace)
//    {
//        Console.Write("\b \b");
//    }
//}
//public static class Program
//{
//    public static void Main()
//    {
//        StringBuilder stringBuilder = new StringBuilder();
//        while (true)
//        {
//            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
//            if (char.IsDigit(consoleKeyInfo.KeyChar))
//            {
//                stringBuilder.Append(consoleKeyInfo.KeyChar);
//                Console.Write(consoleKeyInfo.KeyChar);
//            }
//            else if (consoleKeyInfo.Key == ConsoleKey.Backspace && stringBuilder.Length != 0)
//            {
//                stringBuilder.Remove(stringBuilder.Length - 1, 1);
//                Console.Write("\b \b");
//            }
//        }
//    }
//}

public static class Program
{
    public static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Operations operations = new Operations();
       
        operations.calculations(Convert.ToInt32(operations.num1()), operations.symbols(), Convert.ToInt32(operations.num2()));
    }

    public class Operations
    {
        StringBuilder stringBuilder = new StringBuilder();
        public char num1()
        {
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                if (char.IsDigit(consoleKeyInfo.KeyChar))
                {
                    Console.Write(consoleKeyInfo.KeyChar);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Backspace && stringBuilder.Length != 0)
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                {
                    stringBuilder.Append(consoleKeyInfo.KeyChar);
                    return consoleKeyInfo.KeyChar;
                }
                
            }
        } 
        public char num2()
        {
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                if (char.IsDigit(consoleKeyInfo.KeyChar))
                {
                    Console.Write(consoleKeyInfo.KeyChar);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Backspace && stringBuilder.Length != 0)
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                {
                    stringBuilder.Append(consoleKeyInfo.KeyChar);
                    return consoleKeyInfo.KeyChar;
                }
            }
        }
        public char symbols()
        {
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                if (consoleKeyInfo.KeyChar == '+' || consoleKeyInfo.KeyChar == '-' || consoleKeyInfo.KeyChar == '+' || consoleKeyInfo.KeyChar == '+')
                {
                    Console.Write(consoleKeyInfo.KeyChar);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Backspace && stringBuilder.Length != 0)
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                {
                    stringBuilder.Append(consoleKeyInfo.KeyChar);
                    return consoleKeyInfo.KeyChar;
                }
            }

        }
        public void calculations(int a, char b, int c)
        { 
            if (b == '+')
            {
                Console.Write(a + b);
            }
            if (b == '-')
            { 
                Console.Write(a - c);
            }
            if (b == '/')
            { 
                Console.Write(a / c);
            }
            if (b == '*')
            { 
                Console.Write(a * c);
            }
        }

    }
}