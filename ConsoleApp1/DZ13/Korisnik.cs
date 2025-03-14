using System.ComponentModel.DataAnnotations;

namespace DZ13
{
    internal class Korisnik
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string? Ime { get; set; }
        [MaxLength(50)]
        public string? Prezime { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        [RegularExpression("(M|Z)")]
        public string? Pol { get; set; }
        public int BrojIznajmljenihKnjiga { get; set; }

        private List<Iznajmljivanje>? iznajmljivanja;

        public List<Iznajmljivanje>? GetIznajmljivanja() => iznajmljivanja;

        public void SetIznajmljivanja(List<Iznajmljivanje> value) => iznajmljivanja = value;
    }
}
