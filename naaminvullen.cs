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
    public partial class naaminvullen : Form
    {
        public static string naam = "";
        int QuizIsCustom = 0;

        public naaminvullen(int IsQuizCustom)
        {
            InitializeComponent();
            QuizIsCustom = IsQuizCustom;
        }

        public void StartquizQuick_Click(object sender, EventArgs e)
        {
            if (NaamSpelerTextbox.Text.Length > 0)
            {
                naam = NaamSpelerTextbox.Text;

                string query = "INSERT INTO speler (naam, QuizIsCustom) VALUES ('" + naam + "', '" + QuizIsCustom + "')";

                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = DatabaseSettings.Connectionstring;
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        connection.Close();
                        Close();
                    }
                }
                
                if (QuizIsCustom == 0)
                {
                    quizscherm myForm = new quizscherm(false, 10, 10, 10, naam);
                    myForm.ShowDialog();
                }
                else if (QuizIsCustom == 1)
                {
                    customquizconfig myForm = new customquizconfig(naam);
                    myForm.ShowDialog();
                }
                
                
            }
            else if (NaamSpelerTextbox.Text.Length == 0)
            {
                MessageBox.Show("Vul uw naam in!");
            }

            Close();
        }
    }
}
