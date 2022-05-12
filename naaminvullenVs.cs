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
    public partial class naaminvullenVs : Form
    {
        string naam1 = "";
        string naam2 = "";
        string naamvs = "";

        public naaminvullenVs()
        {
            InitializeComponent();
        }

        private void StartOnevsOneQuiz_Click(object sender, EventArgs e)
        {
            if (NaamSpeler1.Text.Length > 0 && NaamSpeler2.Text.Length > 0)
            {
                naam1 = NaamSpeler1.Text;
                naam2 = NaamSpeler2.Text;
                naamvs = naam1 + ", " + naam2;
                string query = "INSERT INTO speler (naam, QuizIsCustom) VALUES ('" + naam1 + "',' 0 '), ('" + naam2 + "',' 0 ')";

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

                EenvsEenQuizscmer myForm = new EenvsEenQuizscmer(false, 10, 10, 10, naam1, naam2, naamvs);
                myForm.ShowDialog();
            }
            else if (NaamSpeler1.Text.Length <= 0 || NaamSpeler2.Text.Length <= 0)
            {
                MessageBox.Show("Vul alle namen in!");
            }
        }
    }
}
