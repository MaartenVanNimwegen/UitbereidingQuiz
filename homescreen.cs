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
    public partial class homescreen : Form
    {
        public homescreen()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void QuickplayLable_Click(object sender, EventArgs e)
        {
            naaminvullen myForm = new naaminvullen();
            myForm.Show();
        }

        private void CustomQuizLable_Click(object sender, EventArgs e)
        {
            customquizconfig myForm = new customquizconfig();
            myForm.Show();
        }

        private void EenVsEenLable_Click(object sender, EventArgs e)
        {
            naaminvullenVs myForm = new naaminvullenVs();
            myForm.Show();
        }

        private void VraagBeheerLable_Click(object sender, EventArgs e)
        {
            vraagbeheer myForm = new vraagbeheer();
            myForm.Show();
        }

        private void ScoresLable_Click(object sender, EventArgs e)
        {
            scores myForm = new scores();
            myForm.Show();
        }
    }
}
