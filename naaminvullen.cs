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
    public partial class naaminvullen : Form
    {
        public static string naam = "";

        public naaminvullen()
        {
            InitializeComponent();
        }

        public void StartquizQuick_Click(object sender, EventArgs e)
        {
            naam = NaamSpelerTextbox.Text;
        }
    }
}
