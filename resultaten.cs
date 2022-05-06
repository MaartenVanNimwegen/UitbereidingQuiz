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
    public partial class resultaten : Form
    {
        private int goedantwoord;
        private int foutantwoord;
        private int tijd;
        private int strafTijd;
        private int totaletijd;

        public resultaten(int GoedAntwoord, int FoutAntwoord, int StrafTijd, int Tijd)
        {
            InitializeComponent();

            goedantwoord = GoedAntwoord;
            foutantwoord = FoutAntwoord;
            strafTijd = StrafTijd;
            tijd = Tijd;
            totaletijd = tijd + strafTijd;

            GoedBeantwoordeVragen.Text = "Goed beantwoorde vragen: " + goedantwoord.ToString();
            FoutBeantwoordeVragen.Text = "Fout beantwoorde vragen: " + foutantwoord.ToString();
            TijdLabel.Text = "Tijd: " + tijd.ToString() + "s";
            StrafSeconden.Text = "Strafseconden: " + strafTijd.ToString() + "s";
            TotaleScore.Text = "Totale tijd: " + totaletijd.ToString() + "s";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TerugNaarHoofdmenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
