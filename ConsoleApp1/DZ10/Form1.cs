using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZ10
{
    public partial class Form1 : Form
    {
        private ArrayList brojLista;

        //        Tekst domaćeg zadatka 1:
        //Napraviti formu koja treba da ima dugme za dodavanja i brisanje.Pri učitavanju forme
        //potrebno je napraviti kolekciju(ArrayList) sa 100 brojeva i prikazati tu listu u ListBox-u.Klikom
        //na dugme za brisanje potrebno je da se izabrani element iz ListBox-a obriše i ListBox ažurira.
        //Klikom na dugme za dodavanje omogućiti dodavanje u listu.
        //Prethodni zadatak izmeniti tako da demonstrira rad sa stekovima i redovima koristeći primere
        //sa vežbi.
        //Tekst domaćeg zadatka 2:
        //Napraviti sopstvenu implementaciju Stack-a i Queue koristeći ArrayList.

        public Form1()
        {
            InitializeComponent();

            brojLista = new ArrayList();
            for (int i = 1; i <= 100; i++)
            {
                brojLista.Add(i);
            }
            listBox1.DataSource = brojLista;

            Stack stack = new Stack();
            stack.Push(15);
            stack.Push(25);
            stack.Push(35);

            string result = $"Top element: {stack.Peek()}\n";

            while (!stack.IsEmpty)
            {
                result += $"Popped: {stack.Pop()}\n";
            }

            MessageBox.Show(result);

            Queue queue = new Queue();
            queue.Enqueue(15);
            queue.Enqueue(25);
            queue.Enqueue(35);

            result = $"Front Element: {queue.Peek()}\n";

            while (!queue.IsEmpty)
            {
                result += $"Dequeued: {queue.Dequeue()}\n";
            }

            MessageBox.Show(result);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int noviBroj))
            {
                brojLista.Add(noviBroj);
                AzurirajListBox();
            }
            else
            {
                MessageBox.Show("Unesite validan broj!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                brojLista.Remove(listBox1.SelectedItem);
                AzurirajListBox();
            }
            else
            {
                MessageBox.Show("Odaberite broj za brisanje!");
            }
        }

        private void AzurirajListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = brojLista;
        }
    }
}