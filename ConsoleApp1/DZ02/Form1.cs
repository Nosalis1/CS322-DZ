using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DZ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void WriteToFile(string fileName, string data)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(data);
            writer.Flush();
            writer.Close();
        }

        private static void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static bool CheckSingleWord(string str) => str.Split(' ').Length == 1;

        private static bool CheckMultipleWord(string str) => str.Split(' ').Length > 1;


        private static bool ValidateData(string name, string surname, string adress)
        {
            if (String.IsNullOrEmpty(name))
            {
                DisplayErrorMessage("Name is empty!");
                return false;
            }
            if (String.IsNullOrEmpty(surname))
            {
                DisplayErrorMessage("Surname is empty!");
                return false;
            }
            if (String.IsNullOrEmpty(adress))
            {
                DisplayErrorMessage("Adress is empty!");
                return false;
            }

            if (!CheckSingleWord(name))
            {
                DisplayErrorMessage("Name have more than 1 word!");
                return false;
            }
            if (!CheckMultipleWord(adress))
            {
                DisplayErrorMessage("Adress have only 1 word!");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbIme.Text.Trim();
            string surname = tbPrezime.Text.Trim();
            string adress = tbAdresa.Text.Trim();

            if (!ValidateData(name, surname, adress))
                return;

            string data = String.Format(
                "Name:{0}\nSurname:{1}\nAdress:{2}", name, surname, adress);

            WriteToFile("data.txt", data);

            MessageBox.Show(data, "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}