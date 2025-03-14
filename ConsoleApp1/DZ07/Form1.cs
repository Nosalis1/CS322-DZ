using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DZ07
{
    public partial class Form1 : Form
    {
        internal partial class StudentDTO
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Year { get; set; }

            public StudentDTO(string name, string surname, int year)
            {
                this.Name = name;
                this.Surname = surname;
                this.Year = year;
            }
        }

        private MySqlConnection? connection;

        const string TABLE_QUERY = @"
                CREATE TABLE IF NOT EXISTS Studenti (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Ime VARCHAR(100) NOT NULL,
                    Prezime VARCHAR(100) NOT NULL,
                    GodinaRodjenja INT NOT NULL
                );";
        const string GET_QUERY = "SELECT * FROM Studenti";
        const string INSERT_QUERY = "INSERT INTO Studenti (Ime, Prezime, GodinaRodjenja) VALUES (@Ime, @Prezime, @GodinaRodjenja)";
        const string UPDATE_QUERY = "UPDATE Studenti SET Ime = @Ime, Prezime = @Prezime, GodinaRodjenja = @GodinaRodjenja WHERE ID = @ID";
        const string DELETE_QUERY = "DELETE FROM Studenti WHERE ID = @ID";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Server=localhost;Database=fakultet;Uid=root;Pwd=root;";
            connection = new MySqlConnection(connectionString);
            if (connection != null)
            {
                connection.Open();
                using (var command = new MySqlCommand(TABLE_QUERY, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadData()
        {
            if (connection == null) return;
            using (var adapter = new MySqlDataAdapter(GET_QUERY, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void AddStudent(StudentDTO student)
        {
            if (connection == null) return;
            using (var command = new MySqlCommand(INSERT_QUERY, connection))
            {
                command.Parameters.AddWithValue("@Ime", student.Name);
                command.Parameters.AddWithValue("@Prezime", student.Surname);
                command.Parameters.AddWithValue("@GodinaRodjenja", student.Year);
                command.ExecuteNonQuery();
            }
            LoadData();
        }

        private void UpdateStudent(int id, StudentDTO student)
        {
            if (connection == null) return;
            using (var command = new MySqlCommand(UPDATE_QUERY, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Ime", student.Name);
                command.Parameters.AddWithValue("@Prezime", student.Surname);
                command.Parameters.AddWithValue("@GodinaRodjenja", student.Year);
                command.ExecuteNonQuery();
            }
            LoadData();
        }

        private void DeleteStudent(int id)
        {
            if (connection == null) return;
            using (var command = new MySqlCommand(DELETE_QUERY, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            LoadData();
        }


        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            var student = new StudentDTO(textBoxIme.Text, textBoxPrezime.Text, int.Parse(textBoxGodinaRodjenja.Text));
            
            AddStudent(student);
        }

        private int SelectedId()
        {
            object idObject = dataGridView1.SelectedRows[0].Cells["ID"].Value;
            string? idString = idObject.ToString();
            if (idString == null) return -1;
            int id = int.Parse(idString);
            return id;
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = SelectedId();
                var student = new StudentDTO(textBoxIme.Text, textBoxPrezime.Text, int.Parse(textBoxGodinaRodjenja.Text));

                UpdateStudent(id, student);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = SelectedId();
                DeleteStudent(id);
            }
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}