using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitbereidingQuiz
{
    public partial class customquizconfig : Form
    {
        string Naam;

        public customquizconfig(string naam)
        {
            InitializeComponent();
            Naam = naam;
        }
        int tijdPerVraag;
        int strafseconde;
        int aantalvragen;
        bool QuizIsCustom;

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startcustomquiz_Click(object sender, EventArgs e)
        {
            tijdPerVraag = int.Parse(TijdPerVraagTextbox.Text);
            strafseconde = int.Parse(StrafsecondenTextbox.Text);
            aantalvragen = int.Parse(AantalVragenTextbox.Text);
            QuizIsCustom = true;

            quizscherm myForm = new quizscherm(QuizIsCustom, tijdPerVraag, strafseconde, aantalvragen, Naam);
            myForm.Show();
        }
    }
}
