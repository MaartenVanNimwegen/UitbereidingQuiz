using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UitbereidingQuiz
{
    public partial class scores : Form
    {
        public scores()
        {
            InitializeComponent();
           
            RefreshAntwoordGridQuick();
            RefreshAntwoordGridCustom();
            RefreshAntwoordGridOne();
        }
        /// <summary>
        /// Maakt grid leeg en vult hem opnieuw met de informatie
        /// </summary>
        private void RefreshAntwoordGridQuick()
        {
            AntwoordGridQuick.Rows.Clear();

            string query = "SELECT andwoord.userId, speler.naam, SUM(andwoord.tijd) AS Tijd, SUM(andwoord.strafTijd) AS StrafTijd,SUM(andwoord.tijd+andwoord.strafTijd) AS TotaalScore FROM andwoord INNER JOIN speler ON andwoord.userId = speler.id WHERE custom = 0 GROUP BY andwoord.userId, speler.naam";
            var Antwoorden = new List<AntwoordenClass>();

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AntwoordenClass LeAntwoord = new AntwoordenClass();
                            LeAntwoord.userId = (int)reader["userId"];
                            LeAntwoord.naam = reader.GetString(1);
                            LeAntwoord.tijd = reader.GetInt32(2);
                            LeAntwoord.strafTijd = reader.GetInt32(3);
                            LeAntwoord.TotaalScore = reader.GetInt32(4);

                            Antwoorden.Add(LeAntwoord);
                        }
                    }
                    reader.Close();
                }
            }
            for (int i = 1; i <= Antwoorden.Count; i++)
            {
                var Andwoord = Antwoorden[i - 1];

                if (Andwoord != null)
                {
                    AntwoordGridQuick.Rows.Add(Andwoord.userId, Andwoord.naam, Andwoord.TotaalScore);
                }
            }
        }
        /// <summary>
        /// sluit het scherm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RefreshAntwoordGridCustom()
        {
            AntwoordGridCustom.Rows.Clear();

            string query = "SELECT andwoord.userId, speler.naam, SUM(andwoord.tijd) AS Tijd, SUM(andwoord.strafTijd) AS StrafTijd,SUM(andwoord.tijd+andwoord.strafTijd) AS TotaalScore FROM andwoord INNER JOIN speler ON andwoord.userId = speler.id WHERE custom = 1 GROUP BY andwoord.userId, speler.naam";
            var Antwoorden = new List<AntwoordenClass>();

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AntwoordenClass LeAntwoord = new AntwoordenClass();
                            LeAntwoord.userId = (int)reader["userId"];
                            LeAntwoord.naam = reader.GetString(1);
                            LeAntwoord.tijd = reader.GetInt32(2);
                            LeAntwoord.strafTijd = reader.GetInt32(3);
                            LeAntwoord.TotaalScore = reader.GetInt32(4);

                            Antwoorden.Add(LeAntwoord);
                        }
                    }
                    reader.Close();
                }
            }
            for (int i = 1; i <= Antwoorden.Count; i++)
            {
                var Andwoord = Antwoorden[i - 1];

                if (Andwoord != null)
                {
                    AntwoordGridCustom.Rows.Add(Andwoord.userId, Andwoord.naam, Andwoord.TotaalScore);
                }
            }
        }
        private void RefreshAntwoordGridOne()
        {
            AntwoordGridOne.Rows.Clear();

            string query = "SELECT andwoordvs.userId, speler.naam, SUM(andwoordvs.userId*andwoordvs.IsGoedBeandwoord) AS TotaalScore FROM andwoordvs INNER JOIN speler ON andwoordvs.userId = speler.id GROUP BY andwoordvs.userId, speler.naam";
            var Antwoordenvs = new List<AntwoordenClassvs>();

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AntwoordenClassvs LeAntwoordvs = new AntwoordenClassvs();
                            LeAntwoordvs.userId = (int)reader["userId"];
                            LeAntwoordvs.naam = reader.GetString(1);
                            LeAntwoordvs.TotaalScore = reader.GetInt32(2);

                            Antwoordenvs.Add(LeAntwoordvs);
                        }
                    }
                    reader.Close();
                }
            }
            for (int i = 1; i <= Antwoordenvs.Count; i++)
            {
                var Andwoord = Antwoordenvs[i - 1];

                if (Andwoord != null)
                {
                    AntwoordGridOne.Rows.Add(Andwoord.userId, Andwoord.naam, Andwoord.TotaalScore);
                }
            }
        }
    }
}
