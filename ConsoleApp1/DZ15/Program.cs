//Napraviti kalkulator procenata i kamata u C#-u. (Uzeti sajt neke banke kao primer).
//Primeniti debugging i tehniku izuzetaka.

class Program
{
    static float IzracunajJednostavnuKamatu(float glavnica, float stopa, int godine) =>
        glavnica + (glavnica * (stopa / 100) * godine);

    static float IzracunajSlozenuKamatu(float glavnica, float stopa, int godine) =>
        (float)((double)glavnica * Math.Pow(1 + (double)stopa / 100, godine));

    [STAThread]
    static void Main(string[] args)
    {
        try
        {
            string? text = "";

            Console.Write("Unesite iznos glavnice (RSD): ");
            text = Console.ReadLine();
            if (text == null) return;
            float glavnica = float.Parse(text);

            Console.Write("Unesite godisnju kamatnu stopu (%): ");
            text = Console.ReadLine();
            if (text == null) return;
            float godisnjaStopa = float.Parse(text);

            Console.Write("Unesite period otplate (u godinama): ");
            text = Console.ReadLine();
            if (text == null) return;
            int godine = int.Parse(text);

            Console.Write("Odaberite vrstu kamate (1 - Jednostavna, 2 - Slozena): ");
            text = Console.ReadLine();
            if (text == null) return;
            int izbor = int.Parse(text);

            float ukupanIznos = 0;

            switch (izbor)
            {
                case 1:
                    ukupanIznos = IzracunajJednostavnuKamatu(glavnica, godisnjaStopa, godine);
                    break;
                case 2:
                    ukupanIznos = IzracunajSlozenuKamatu(glavnica, godisnjaStopa, godine);
                    break;
                default:
                    Console.WriteLine("Pogresan unos! Odaberite 1 ili 2.");
                    return;
            }

            Console.WriteLine($"Ukupan iznos nakon {godine} godina: {ukupanIznos:C}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Greska u unosu!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Doslo je do neocekivane greske.\n {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Hvala sto koristite nas kalkulator!");
        }

    }
}