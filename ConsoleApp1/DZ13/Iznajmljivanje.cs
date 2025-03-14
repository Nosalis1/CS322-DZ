using System.ComponentModel.DataAnnotations;

namespace DZ13
{
    internal class Iznajmljivanje
    {
        [Key]
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumIznajmljivanja { get; set; }
        public int RokZaVracanje { get; set; }

        private Korisnik? korisnik;
        public Korisnik? GetKorisnik() => korisnik;
        public void SetKorisnik(Korisnik value) => korisnik = value;

        private Knjiga? knjiga;

        public Knjiga? GetKnjiga() => knjiga;

        public void SetKnjiga(Knjiga value) => knjiga = value;
    }
}
