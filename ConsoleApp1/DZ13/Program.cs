using MySql.Data.MySqlClient;

namespace DZ13
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=biblioteka;User Id=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Konekcija uspešno otvorena!");

                    var biblioteka = new Biblioteka();

                    Knjiga knjiga = new Knjiga
                    {
                        ID = 1,
                        Naziv = "Book Of Ra",
                        Autor = "Max Bet",
                        Zanr = "Fantastika",
                        DatumIzdavanja = DateTime.Now,
                        BrojPrimeraka = 10
                    };
                    Korisnik korisnik = new Korisnik
                    {
                        ID = 1,
                        Ime = "Aleksa",
                        Prezime = "Stanojevic",
                        DatumRodjenja = new DateTime(2000, 1, 1),
                        Pol = "M",
                        BrojIznajmljenihKnjiga = 1
                    };
                    Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                    {
                        ID = 1,
                        DatumIznajmljivanja = knjiga.DatumIzdavanja,
                        RokZaVracanje = 14
                    };

                    biblioteka.DodajKnjigu(knjiga, connection);
                    biblioteka.DodajKorisnika(korisnik, connection);

                    iznajmljivanje.SetKorisnik(korisnik);
                    iznajmljivanje.SetKnjiga(knjiga);
                    biblioteka.DodajIznajmljivanje(iznajmljivanje, connection);

                    var korisniciSaJednomKnjigom = biblioteka.Korisnici
                        .Where(k => k.BrojIznajmljenihKnjiga == 1)
                        .Select(k => new { k.Ime, k.Prezime });

                    Console.WriteLine("Korisnici sa jednom iznajmljenom knjigom:");
                    foreach (var k in korisniciSaJednomKnjigom)
                    {
                        Console.WriteLine($"{k.Ime} {k.Prezime}");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Greška: {ex.Message}");
                }
            }
        }
    }
}