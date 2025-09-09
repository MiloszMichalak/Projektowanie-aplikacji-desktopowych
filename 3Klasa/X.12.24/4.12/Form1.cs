using System.Text;
using Microsoft.Data.Sqlite;

namespace SqLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLInit();
        }

        private void SQLInit()
        {
            String cs = "Data Source=baza.db";
            SqliteConnection connection = new SqliteConnection(cs);

            connection.Open();

            SqliteCommand command = connection.CreateCommand();
            StringBuilder builder = new StringBuilder();
            builder.Append(@"CREATE TABLE IF NOT EXISTS Pracownik (id INTEGER PRIMARY KEY AUTOINCREMENT, imie TEXT, nazwisko TEXT, wiek INT);");
            
            command.CommandText = builder.ToString();
            command.ExecuteNonQuery();

            SqliteCommand command2 = connection.CreateCommand();
            StringBuilder builder2 = new StringBuilder();
            builder2.Append(InsertValue("Bartosz", "Sigma", 13));
            builder2.Append(" ");
            builder2.Append(InsertValue("Jonasz", "Muzykant", 18));
            command2.CommandText = builder2.ToString();
            command2.ExecuteNonQuery();

            connection.Close();
        }

        public static string InsertValue(string imie, string nazwisko, byte wiek)
        {
            return @$"INSERT INTO Pracownik VALUES(NULL, '{imie}', '{nazwisko}', {wiek})";
        }
    }
}
