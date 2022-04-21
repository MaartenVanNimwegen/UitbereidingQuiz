using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UitbereidingQuiz
{
    class VraagClass
    {
        public int id { get; set; }
        public string vraag { get; set; }
        public string correctantwoord { get; set; }
        public string incorrectantwoord { get; set; }
    }
}
