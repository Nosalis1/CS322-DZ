using MySql.Data.MySqlClient;

namespace DZ12
{
    public partial class Form1 : Form
    {
        private MySqlConnection? connection;

        const string INSERT_QUERY = "INSERT INTO Korisnik (username, password) VALUES ('aleksa', 'admin')";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            Task1();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Server=localhost; Database=baza; Uid=root; Pwd=root;";
            connection = new MySqlConnection(connectionString);
            if (connection != null)
            {
                connection.Open();
            }
        }

        void Task1()
        {
            if (connection == null) return;
            using (var command = new MySqlCommand(INSERT_QUERY, connection))
            {
                try
                {

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                        Console.WriteLine("Podaci su uspešno upisani.");
                    else
                        Console.WriteLine("Došlo je do greške prilikom upisa podataka.");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Konekcija je zatvorena.");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadAndSaveFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = string.Empty;

                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.Write(fileContent);
                        }
                        MessageBox.Show("Fajl je uspešno sačuvan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom obrade fajla: " + ex.Message);
                }
            }
        }
    }
}