using System.Windows.Forms;

namespace DZ09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

        }

        //  1. Napraviti brojač, koji broji od jednice do 3000, i prikazuje zbir izbrojenih vrednosti.
        private int Task1()
        {
            int s = 0;
            for (int i = 1; i <= 3000; i++) { s += i; }
            Console.WriteLine("Sum from 1 to 3000 is " + s);
            return s;
        }

        //  2. Sabrati prvih 100 parnih brojeva i istampati
        private int Task2()
        {
            int s = 0;
            for (int i = 2; i <= 100; i += 2) { s += i; }
            Console.WriteLine("Sum first 100 even numbers is " + s);
            return s;
        }

        //  3. Sabrati sve parne brojeve izmedju 21 i 99
        private int Task3()
        {
            int s = 0;
            for (int i = 22; i <= 98; i += 2) { s += i; }
            Console.WriteLine("Sum even numbers from 21 to 99 is " + s);
            return s;
        }

        //  4. Napisati algoritam i aplikaciju sa prozorima za izračunavanje sume članova niza kao i
        //  nalaženje srednje vrednosti svih elemenata jednodimenzionog niza dužine n, koristeći
        //  komponentu ListBox za ispis elemenata niza.
        private int SumArray(int[] array)
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
                s += array[i];
            return s;
        }

        public float Average(int s, int length) => s / length;

        private void Task4()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int sum = SumArray(array);
            float avg = Average(sum, array.Length);

            Console.WriteLine("Sum array is " + sum + " and average value of array is " + avg);

            foreach (var el in array)
                listBox1.Items.Add(el);
        }

        //  5. Napisati algoritam i aplikaciju sa prozorima za izračunavanje minimalnog i maksimalnog
        //  člana jednodimenzionog niza dužine n, koristeći komponentu ListBox za ispis elemenata niza.
        private int MinEl(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] < min)
                    min = array[i];
            return min;
        }

        private int MaxEl(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }

        private void Task5()
        {
            int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int min = MinEl(niz);
            int max = MaxEl(niz);

            Console.WriteLine("Min element of array is " + min + " , max element of array is " + max);

            foreach (var el in niz)
                listBox2.Items.Add(el);
        }
    }
}