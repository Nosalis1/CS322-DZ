
//2. Napraviti klasu Posetioc koja ima od podataka Ime, Prezime i broj ulaznice. Zatim napraviti
//pomoćnu klasu koja ima metodu koja vraća reč od 8 random slova pri čemu je prvo slovo
//veliko
//a ostala su mala, i metodu koja vraća slučajni ceo broj u intervalu od 1 do 200. Obratiti paznju
//na prava pristupa osobinama/varijablama klase, i kreirati potrebne getere i setere.
//U pokretackoj klasi kreirati dve instance klase Posetioc i svaku od njih napuniti random
//podacima koristeći pomoćnu klasu. Prikazati rezultat rada.

internal static class VisitorHelper
{
    public static string RndWord()
    {
        char[] chars = new char[8];
        chars[0] = (char)new Random().Next(65, 91);
        for (int i = 1; i < chars.Length; i++)
        {
            chars[i] = (char)new Random().Next(97, 123);
        }

        return new string(chars);
    }
    public static int RndNumber() => new Random().Next(1, 201);
}

internal class Visitor
{
    private string name;
    private string surname;
    private int ticketNumber;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Surname
    {
        get => surname;
        set => surname = value;
    }
    public int TicketNumber
    {
        get => ticketNumber;
        set => ticketNumber = value;
    }

    public Visitor()
    {
        this.name = VisitorHelper.RndWord();
        this.surname = VisitorHelper.RndWord();
        this.ticketNumber = VisitorHelper.RndNumber();
    }

    public void Info() => Console.WriteLine($"Name {name}\nSurname {surname}\nTicketNumber {ticketNumber}\n");
}

class Program
{
    //1.Napisati program u jeziku C# koji poziva funkciju koja vraća rezultat stepenovanja
    //parametra.
    //Funkciji prosleđujemo vrednost promenljive koja treba biti dignuta na određeni stepen, kao i
    //vrednost stepena(ove vrednosti korisnik unosi preko tastature). Treba proveriti da vrednost
    //parametra koji treba biti stepenovan (x) bude razilticod nule, a vrednost stepena(n) veća ili
    //jednaka nuli. U suprotnom prikazati grkeus .
    public static float CustomPow(float x, float n)
    {
        if (x != 0 && n >= 0) return MathF.Pow(x, n);
        else Console.WriteLine("Error");
        return 0;
    }

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
            Console.WriteLine("Enter pow:");
            text = Console.ReadLine();

            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("Not valid input!");
                return;
            }
            int pow = int.Parse(text);

            float result = CustomPow(n, pow);
            Console.WriteLine($"Number {n} on pow {pow} is {result}");
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

        Visitor v1 = new Visitor();
        Visitor v2 = new Visitor();
        v1.Info();
        v2.Info();
    }
}