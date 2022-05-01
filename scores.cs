﻿using System;
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
            RefreshAntwoordGrid();
        }
        /// <summary>
        /// Maakt grid leeg en vult hem opnieuw met de informatie
        /// </summary>
        private void RefreshAntwoordGrid()
        {
            AntwoordGrid.Rows.Clear();

            string query = "SELECT andwoord.userId, speler.naam, SUM(andwoord.tijd) AS Tijd, SUM(andwoord.strafTijd) AS StrafTijd,SUM(andwoord.tijd+andwoord.strafTijd) AS TotaalScore FROM andwoord INNER JOIN speler ON andwoord.userId = speler.id GROUP BY andwoord.userId, speler.naam";
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
                    AntwoordGrid.Rows.Add(Andwoord.userId, Andwoord.naam, Andwoord.tijd, Andwoord.strafTijd, Andwoord.TotaalScore);
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
    }
}
