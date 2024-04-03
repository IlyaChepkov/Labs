
using Labs;

public class Program
{
    public static void Main()
    {
        bool mode = bool.Parse(Console.ReadLine());
        if(mode)
        {
            UserMode();
        }
        else
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
        Console.ReadLine();
    }

    public static void UserMode()
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
}
