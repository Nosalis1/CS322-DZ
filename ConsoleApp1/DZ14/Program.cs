
class Program
{
    static string HoroskopskiZnak(DateTime datum)
    {
        int dan = datum.Day;
        int mesec = datum.Month;

        return mesec switch
        {
            1 => (dan <= 19) ? "Jarac" : "Vodolija",
            2 => (dan <= 18) ? "Vodolija" : "Ribe",
            3 => (dan <= 20) ? "Ribe" : "Ovan",
            4 => (dan <= 19) ? "Ovan" : "Bik",
            5 => (dan <= 20) ? "Bik" : "Blizanci",
            6 => (dan <= 20) ? "Blizanci" : "Rak",
            7 => (dan <= 22) ? "Rak" : "Lav",
            8 => (dan <= 22) ? "Lav" : "Devica",
            9 => (dan <= 22) ? "Devica" : "Vaga",
            10 => (dan <= 22) ? "Vaga" : "Skorpija",
            11 => (dan <= 21) ? "Skorpija" : "Strelac",
            12 => (dan <= 21) ? "Strelac" : "Jarac",
            _ => "Nepoznat znak"
        };
    }

    [STAThread]
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite ime");
        string? ime = Console.ReadLine();

        Console.WriteLine("Unesite ime");
        string? prezime = Console.ReadLine();

        Console.WriteLine("Unesite datum rodjenja po formatu: dan/mesec/godina ");
        string? datumRodjenja = Console.ReadLine();

        DateTime datum;
        if (DateTime.TryParseExact(datumRodjenja, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out datum))
        {
            Console.WriteLine("Neispravan format datuma");
            return;
        }

        string hZnak = HoroskopskiZnak(datum);
        Console.WriteLine("Horoskopski znak za dat datum je " + datum);

    }
}