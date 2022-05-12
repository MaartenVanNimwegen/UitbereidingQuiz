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
    public partial class resultatenvs : Form
    {
        public resultatenvs(string naam1, string naam2, int goed1, int goed2, int fout1, int fout2)
        {
            InitializeComponent();

            int totaal1 = goed1 + fout2;
            int totaal2 = goed2 + fout1;
            string totaalstring1 = totaal1.ToString() + "0";
            string totaalstring2 = totaal2.ToString() + "0";

            Speler1NaamLabel.Text = naam1;
            Speler2NaamLabel.Text = naam2;
            GoedBeantwoordeVragen1.Text = goed1.ToString();
            GoedBeantwoordeVragen2.Text = goed2.ToString();
            FoutBeantwoordeVragen1.Text = fout1.ToString();
            FoutBeantwoordeVragen2.Text = fout2.ToString();
            TotaleScoreLabel1.Text = "Totaal: " + totaalstring1;
            TotaleScoreLabel2.Text = "Totaal: " + totaalstring2;

            int highest = Math.Max(totaal1, totaal2);

            if (highest == totaal1)
            {
                Speler1Won.Visible = true;
                Speler2Won.Visible = false;
            }
            else if (highest == totaal2)
            {
                Speler1Won.Visible = false;
                Speler2Won.Visible = true;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
