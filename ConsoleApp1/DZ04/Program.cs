class Program
{

    //  1. Ispisati sumu neparnih brojeva od 1 do n.
    public static void Task1()
    {
        Console.WriteLine("Enter num n:");
        string? text = Console.ReadLine();

        if (String.IsNullOrEmpty(text))
        {
            Console.WriteLine("Not valid input!");
            return;
        }
        try
        {
            int n = int.Parse(text);

            int sum = 0;
            for (int i = 1; i < n; i += 2)
            {
                sum += i;
            }

            Console.WriteLine($"Sum is {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input is not a number!");
        }
    }

    //  2. Ispisati dvostruku vrednost prirodnih brojeva od 8 do 16 unazad.
    public static void Task2()
    {
        for (int i = 16; i >= 8; i--)
            Console.WriteLine(i * 2);
    }

    //3.) Napisati program koji učitava sa standardnog ulaza prirodan broj manji od milijarde i na
    //standardni izlaz ispisuje da li cifre tog broja obrazuju strogo rastući niz. Na primer, cifre broja
    //118 ne obrazuju strogo rastući niz, cifre broja 8876551 ne obrazuju strogo rastući niz, dok
    //cifre broja 1234569 obrazuju strogo rastući niz.
    public static void Task3()
    {
        Console.WriteLine("Enter num n:");
        string? text = Console.ReadLine();

        if (String.IsNullOrEmpty(text))
        {
            Console.WriteLine("Not valid input!");
            return;
        }
        try
        {
            long n = long.Parse(text);
            if (n < 0 || n > 1_000_000_000) return;

            char[] chars = text.ToCharArray();
            bool isAscending = true;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] <= chars[i - 1])
                {
                    isAscending = false;
                    break;
                }
            }
            if (isAscending) Console.WriteLine("Number is ascending!");
            else Console.WriteLine("Number is not ascending!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input is not a number!");
        }
    }

    [STAThread]
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
    }
}