//  1. Napraviti klasu Kurs(ImeKursa, FondCasova, MaksimalnoPrijava) koja implementira generički
//  interfejs IComparable.Ubaciti par kurseva u listu kurseva i sortirati ih po maksimalnom broju
//  prijava implementacijom CompareTo metode.

//  2. Napraviti hijerarhiju klasa ko izboru koja će sadržati: interfejs, apstraktnu klasu i konkretne
//  klase.Prikazati sve osobine koje su obrađivane na predavanjima.
public interface IStudira
{
    void UpisiKurs(Kurs kurs);
    void IspisOcene();
}

public abstract class Osoba
{
    public string Ime { get; set; }
    public string Prezime { get; set; }

    public Osoba(string ime, string prezime)
    {
        Ime = ime;
        Prezime = prezime;
    }

    public override string ToString()
    {
        return $"{Ime} {Prezime}";
    }
}

public class Student : Osoba, IStudira
{
    public List<Kurs> Kursevi { get; set; }
    public string? Ocena { get; set; }

    public Student(string ime, string prezime) : base(ime, prezime)
    {
        Kursevi = new List<Kurs>();
    }

    public void UpisiKurs(Kurs kurs)
    {
        Kursevi.Add(kurs);
        Console.WriteLine($"{Ime} {Prezime} se upisao na kurs: {kurs.Naziv}");
    }

    public void IspisOcene()
    {
        Console.WriteLine($"{Ime} {Prezime} ima ocenu: {Ocena}");
    }
}

public class Kurs : IComparable<Kurs>
{
    public string Naziv { get; set; }
    public int FondCasova { get; set; }
    public int MaksimalnoPrijava { get; set; }

    public Kurs(string naziv, int fondCasova, int maksimalnoPrijava)
    {
        Naziv = naziv;
        FondCasova = fondCasova;
        MaksimalnoPrijava = maksimalnoPrijava;
    }

    public int CompareTo(Kurs? drugi)
    {
        if (drugi == null) return 1;
        return MaksimalnoPrijava.CompareTo(drugi.MaksimalnoPrijava);
    }

    public override string ToString()
    {
        return $"{Naziv} ({FondCasova} časova, Maksimalno prijava: {MaksimalnoPrijava})";
    }
}

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Kurs matematika = new Kurs("Matematika", 120, 50);
        Kurs programiranje = new Kurs("Programiranje", 150, 70);
        Kurs fizika = new Kurs("Fizika", 100, 30);
        Kurs hemija = new Kurs("Hemija", 90, 40);

        Student student = new Student("Marko", "Marković");

        student.UpisiKurs(matematika);
        student.UpisiKurs(programiranje);
        student.UpisiKurs(fizika);
        student.UpisiKurs(hemija);
        student.Ocena = "9";

        Console.WriteLine($"{student.ToString()} je upisan na sledeće kurseve:");
        foreach (var kurs in student.Kursevi)
        {
            Console.WriteLine(kurs.ToString());
        }

        student.IspisOcene();

        List<Kurs> kursevi = new List<Kurs> { matematika, programiranje, fizika, hemija };

        Console.WriteLine("\nKursevi pre sortiranja:");
        foreach (var kurs in kursevi)
        {
            Console.WriteLine(kurs);
        }

        kursevi.Sort();

        Console.WriteLine("\nKursevi posle sortiranja:");
        foreach (var kurs in kursevi)
        {
            Console.WriteLine(kurs);
        }
    }
}