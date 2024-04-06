
using Labs;

public class Program
{
    public static void Main(string[] mode)
    {
        if (mode.Length == 0 || mode[0] == "true")
            StackUserMode();
        else if (mode[0] == "false")
        {
            StackProgramMode();
        }
        Console.ReadLine();
    }

    public static void StackUserMode()
    {
        IlyaStack<int> stack = new IlyaStack<int>();
        Console.WriteLine("Введите поледовательность чисел (конец окончания последовательности 0)");
        while (true)
        {
            int value = int.Parse(Console.ReadLine());
            if (value == 0) break;
            stack.Push(value);
        }
        while (stack.Lenght > 0)
        {
            int value = stack.Pop();
            if (value < 0) continue;
            Console.WriteLine(value);
        }
    }

    public static void StackProgramMode()
    {
        IlyaStack<int> stack = new IlyaStack<int>();
        while (true)
        {
            int value = int.Parse(Console.ReadLine());
            if (value == 0) break;

            stack.Push(value);
        }
        while (stack.Lenght > 0)
        {
            int value = stack.Pop();
            if (value < 0) continue;
            Console.WriteLine(value);
        }
    }
}
