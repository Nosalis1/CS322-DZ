using MySql.Data.MySqlClient;

namespace DZ13
{
    internal class Biblioteka
    {
        const string INSERT_USER_QUERY = "INSERT INTO Korisnik (Ime, Prezime, DatumRodjenja, Pol, BrojIznajmljenihKnjiga) " +
                           "VALUES (@Ime, @Prezime, @DatumRodjenja, @Pol, @BrojIznajmljenihKnjiga)";
        const string INSERT_BOOK_QUERY = "INSERT INTO Knjiga (Naziv, Autor, Zanr, DatumIzdavanja, BrojPrimeraka) " +
                           "VALUES (@Naziv, @Autor, @Zanr, @DatumIzdavanja, @BrojPrimeraka)";
        const string INSERT_RESERVATION_QUERY = "INSERT INTO Iznajmljivanje (DatumIznajmljivanja, RokZaVracanje, KorisnikID, KnjigaID) " +
                           "VALUES (@DatumIznajmljivanja, @RokZaVracanje, @KorisnikID, @KnjigaID)";

        public List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();
        public List<Knjiga> Knjige { get; set; } = new List<Knjiga>();
        public List<Iznajmljivanje> Iznajmljivanja { get; set; } = new List<Iznajmljivanje>();

        public void DodajKorisnika(Korisnik korisnik, MySqlConnection connection)
        {
            Korisnici.Add(korisnik);

            using (MySqlCommand cmd = new MySqlCommand(INSERT_USER_QUERY, connection))
            {
                cmd.Parameters.AddWithValue("@Ime", korisnik.Ime);
                cmd.Parameters.AddWithValue("@Prezime", korisnik.Prezime);
                cmd.Parameters.AddWithValue("@DatumRodjenja", korisnik.DatumRodjenja);
                cmd.Parameters.AddWithValue("@Pol", korisnik.Pol);
                cmd.Parameters.AddWithValue("@BrojIznajmljenihKnjiga", korisnik.BrojIznajmljenihKnjiga);
                cmd.ExecuteNonQuery();
            }
        }

        public void DodajKnjigu(Knjiga knjiga, MySqlConnection connection)
        {
            Knjige.Add(knjiga);

            using (MySqlCommand cmd = new MySqlCommand(INSERT_BOOK_QUERY, connection))
            {
                cmd.Parameters.AddWithValue("@Naziv", knjiga.Naziv);
                cmd.Parameters.AddWithValue("@Autor", knjiga.Autor);
                cmd.Parameters.AddWithValue("@Zanr", knjiga.Zanr);
                cmd.Parameters.AddWithValue("@DatumIzdavanja", knjiga.DatumIzdavanja);
                cmd.Parameters.AddWithValue("@BrojPrimeraka", knjiga.BrojPrimeraka);
                cmd.ExecuteNonQuery();
            }
        }

        public void DodajIznajmljivanje(Iznajmljivanje iznajmljivanje, MySqlConnection connection)
        {
            Iznajmljivanja.Add(iznajmljivanje);

            using (MySqlCommand cmd = new MySqlCommand(INSERT_RESERVATION_QUERY, connection))
            {
                cmd.Parameters.AddWithValue("@DatumIznajmljivanja", iznajmljivanje.DatumIznajmljivanja);
                cmd.Parameters.AddWithValue("@RokZaVracanje", iznajmljivanje.RokZaVracanje);
                cmd.Parameters.AddWithValue("@KorisnikID", iznajmljivanje.GetKorisnik().ID);
                cmd.Parameters.AddWithValue("@KnjigaID", iznajmljivanje.GetKnjiga().ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}