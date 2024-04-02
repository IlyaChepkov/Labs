
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
                if (value < 0) continue;
                stack.Push(value);
            }
            while (stack.Lenght > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }

    public static void UserMode()
    {
        IlyaStack<int> stack = new IlyaStack<int>();
        while (true)
        {
            Console.WriteLine("Введите число");
            int value = int.Parse(Console.ReadLine());
            if (value == 0) break;
            if (value < 0) continue;
            stack.Push(value);
        }
        while (stack.Lenght > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
