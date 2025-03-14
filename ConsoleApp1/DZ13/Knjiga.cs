using System.ComponentModel.DataAnnotations;

namespace DZ13
{
    internal class Knjiga
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string? Naziv { get; set; }
        [MaxLength(50)]
        public string? Autor { get; set; }
        [MaxLength(20)]
        public string? Zanr { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumIzdavanja { get; set; }
        public int BrojPrimeraka { get; set; }

        private List<Iznajmljivanje>? iznajmljivanja;

        public List<Iznajmljivanje>? GetIznajmljivanja() => iznajmljivanja;
        public void SetIznajmljivanja(List<Iznajmljivanje> value) => iznajmljivanja = value;
    }
}
