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
    public partial class EenvsEenQuizscmer : Form
    {
        // Hieronder staan alle variabelen gesorteerd op type
        string Naam1;
        string Naam2;
        string Naamvs;
        string CorrectAnswer = "";
        string GegevenAndwoord;

        int userId1;
        int userId2;
        int AantalFouteVragen1;
        int AantalGoedBeandwoordeVragen1;
        int AantalFouteVragen2;
        int AantalGoedBeandwoordeVragen2;
        int aantalVragen;
        int tijdPerVraag;
        int strafTijd;
        int puntenSpeler1 = 0;
        int puntenSpeler2 = 0;
        int QuestionsCurrentListIndex = 0;
        int VraagNummer = 0;
        int TijdVanBeantwoorden;
        int defaultQuestionIndividualTimer = 10;
        int QuestionIndividualTimer = 10; 
        int GlobalTimer = 0;
        int idSpeler1 = 0;
        int idSpeler2 = 0;
        int defaultAftelNaarVolgende = 3;
        int AftelNaarVolgende = 3;
        int aantathuidigestrafseconde;
        int aantatstrafseconde;
        int antwoordint;
        int fout1;
        int fout2;

        bool isdebeurtgekaapt = false;
        bool TimerPlaying = false;
        bool AcceptingInput = false;
        bool HasGivenInput = false;
        bool CorrectInput;
        bool IsCountingDown = false;
        bool IsGoedBeandwoord;
        bool beurtspeler1 = false;
        bool beurtspeler2= false;
        bool speler1heeftgoedandwoord;
        bool speler2heeftgoedandwoord;

        List<VraagClass> Questions;
        VraagClass currentquestion;

        Color IncorrectColor = Color.FromArgb(216, 34, 10);
        Color CorrectColor = Color.FromArgb(54, 183, 47);
        Color SelectedColor = Color.FromArgb(234, 228, 171);
        Color DefaultColor = Color.FromArgb(41, 76, 146);
        /// <summary>
        /// Dit is de functie die de quiz start, bij het openen van het scherm worden de hieronder genoemde gegevens meegestuurt en op basis hiervan wordt de quiz geconfigureerd.
        /// </summary>
        /// <param name="QuizIsCustom"></param>
        /// <param name="AantalVragen"></param>
        /// <param name="TijdPerVraag"></param>
        /// <param name="StrafTijd"></param>
        /// <param name="naam1"></param>
        /// <param name="naam2"></param>
        /// <param name="naamvs"></param>
        public EenvsEenQuizscmer(bool QuizIsCustom, int AantalVragen, int TijdPerVraag, int StrafTijd, string naam1, string naam2, string naamvs)
        {
            InitializeComponent();

            aantalVragen = AantalVragen;
            tijdPerVraag = TijdPerVraag;
            strafTijd = StrafTijd;
            Naam1 = naam1;
            Naam2 = naam2;
            Naamvs = naamvs;
            
            Questions = GetQuestions(aantalVragen);
            setlabels();
            AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);

        }
        /// <summary>
        /// Hier wordt een lijst met nummers gemaakt, dit is de lijst met vragen ids
        /// </summary>
        /// <param name="Amount"></param>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <returns></returns>
        private List<int> NewNumber(int Amount, int Start, int End)
        {

            int MyNumber = 0;
            Random Number = new Random();
            List<int> randomList = new List<int>();

            while (randomList.Count < Amount)
            {
                MyNumber = Number.Next(Start, End);
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                }
            }

            return randomList;
        }
        /// <summary>
        /// Deze functie kiest een vraag en wijst het goede en foute antwoord toe aan a of b.
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="QIndex"></param>
        private void AskQuestion(VraagClass Question, int QIndex)
        {
            VraagNummer++;

            TijdVanBeantwoorden = 0;
            VraagLable.Text = Question.vraag;
            currentquestion = Question;

            QuestionIndividualTimer = defaultQuestionIndividualTimer;

            ResetColors();

            // Random selecteren van correct antwoord positie A of B
            var random = new Random();
            var randomBool = random.Next(2) == 1;

            if (randomBool == true)
            {
                CorrectAnswer = "A";
                AnswerA.Text = Question.correctantwoord;
                AnswerB.Text = Question.incorrectantwoord;
            }
            else
            {
                CorrectAnswer = "B";
                AnswerA.Text = Question.incorrectantwoord;
                AnswerB.Text = Question.correctantwoord;
            }

            Questions.RemoveAt(QIndex);

            QuestionsCurrentListIndex = GetRandomQuestionListId();

            QuestionIndividualTimer = defaultQuestionIndividualTimer;
            TimerPlaying = true;
            AcceptingInput = true;
        }
        /// <summary>
        /// Hier worden de labels terug naar de originele kleur terug gezet
        /// </summary>
        private void ResetColors()
        {
            AnswerA.BackColor = DefaultColor;
            ALetter.BackColor = DefaultColor;

            AnswerB.BackColor = DefaultColor;
            BLetter.BackColor = DefaultColor;

            AnswerA.ForeColor = Color.White;
            AnswerB.ForeColor = Color.White;

            ALetter.ForeColor = Color.White;
            BLetter.ForeColor = Color.White;

            SelectedA.BackColor = DefaultColor;
            SelectedB.BackColor = DefaultColor;

            NaamSpeler1.ForeColor = Color.White;
            NaamSpeler2.ForeColor = Color.White;
        }
        private int GetRandomQuestionListId()
        {
            int Rid = 0;

            if (Questions.Count > 0)
            {
                Random rnd = new Random();
                Rid = rnd.Next(0, Questions.Count - 1);
            }

            return Rid;
        }
        /// <summary>
        /// Deze functie haalt alle vragen op uit de database en voert deze in in een lijst
        /// </summary>
        /// <param name="Amount"></param>
        /// <returns></returns>
        private List<VraagClass> GetQuestions(int Amount)
        {
            string query = "SELECT * FROM vragen";

            var Vragen = new List<VraagClass>();


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
                            VraagClass LeVraag = new VraagClass();
                            LeVraag.id = reader.GetInt32(0);
                            LeVraag.vraag = reader.GetString(1);
                            LeVraag.correctantwoord = reader.GetString(2);
                            LeVraag.incorrectantwoord = reader.GetString(3);

                            Vragen.Add(LeVraag);
                        }
                    }
                    reader.Close();
                }
            }

            // unieke ids van de vragen.
            List<int> Qids = NewNumber(Amount, 1, Vragen.Count);

            // de vragen die bij de ids (zie hierboven) horen.
            List<VraagClass> SortedQuestions = Vragen.Where(vraag => Qids.Contains(vraag.id)).ToList();

            return SortedQuestions;
        }
        /// <summary>
        /// Deze functie vraagt op je zeker weet dat je de quiz wilt sluiten en sluit hem bij ja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            string message = "Weet je zeker dat je de quiz wilt beëindigen? Je scores zullen verloren raken.";
            string caption = "Quiz beëindigen";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        /// <summary>
        /// Hier wordt de naam van de spelers in het label geplaats samen met de punten
        /// </summary>
        private void setlabels()
        {
            NaamSpeler1.Text = Naam1;
            NaamSpeler2.Text = Naam2;
            PuntenSpeler1.Text = puntenSpeler1.ToString();
            PuntenSpeler2.Text = puntenSpeler2.ToString();
        }
        /// <summary>
        /// Deze timer doet verschillende dingen maar de mail objective is dat als je niet optijd antwoord dat de vraag dan wordt fout gerekend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            if (TimerPlaying == true)
            {
                GlobalTimer++;
                GlobalTimeLabel.Text = GlobalTimer.ToString() + "s";
            }

            if (TimerPlaying == true && QuestionIndividualTimer > 0)
            {
                QuestionIndividualTimer--;
                GlobalTimeLabel.Text = QuestionIndividualTimer.ToString() + "s";
            }
            else if (QuestionIndividualTimer <= 0 && AcceptingInput == true)
            {
                // De speler heeft niks beantwoord binnen de tijd
                AcceptingInput = false;
                HasGivenInput = true;
                TimerPlaying = false;

                // Score opslaan vars
                int vraagId = currentquestion.id;

                if (CorrectAnswer == "A")
                {
                    AnswerA.BackColor = CorrectColor;
                    ALetter.BackColor = CorrectColor;
                    SelectedA.BackColor = CorrectColor;

                    AnswerB.BackColor = IncorrectColor;
                    BLetter.BackColor = IncorrectColor;
                    SelectedB.BackColor = IncorrectColor;
                }
                else
                {
                    AnswerA.BackColor = IncorrectColor;
                    ALetter.BackColor = IncorrectColor;
                    SelectedA.BackColor = IncorrectColor;

                    AnswerB.BackColor = CorrectColor;
                    BLetter.BackColor = CorrectColor;
                    SelectedB.BackColor = CorrectColor;
                }

                CorrectInput = false;
                AftelNaarVolgende = defaultAftelNaarVolgende;
                IsCountingDown = true;
                progress();
            }
        }
        /// <summary>
        /// Hier wordt het gegeven antwoord opgeslagen met de megegeven gegevens.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="vraagId"></param>
        /// <param name="antwoord"></param>
        private void AntwoordOpslaan(int userId, int vraagId, bool antwoord)
        { 
            if(antwoord == true)
            {
                antwoordint = 1;
            }
            else if(antwoord == false)
            {
                antwoordint = 0;
            }

            string query = "INSERT INTO andwoordvs (userId, vraagId, IsGoedBeandwoord, datum) VALUES ('" + userId + "', '" + vraagId + "', '" + antwoordint + "', now())";


            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Deze update de progress bar
        /// </summary>
        public void progress()
        {
            int Step = 100 / aantalVragen;

            progressBar.Step = Step;
            progressBar.Value = Step * VraagNummer;
        }
        /// <summary>
        /// Deze haalt de naam van speler 1 op uit de database
        /// </summary>
        /// <param name="Naam1"></param>
        /// <returns></returns>
        int GetIdByName1(string Naam1)
        {
            string query = "SELECT id FROM speler WHERE naam = '" + Naam1 + "'";

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
                            idSpeler1 = (int)reader["id"];
                        }
                    }
                    reader.Close();

                }
            }

            return idSpeler1;
        }
        /// <summary>
        /// Deze haalt de naam van speler 2 op uit de database
        /// </summary>
        /// <param name="Naam2"></param>
        /// <returns></returns>
        int GetIdByName2(string Naam2)
        {
            string query = "SELECT id FROM speler WHERE naam = '" + Naam2 + "'";

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
                            idSpeler2 = (int)reader["id"];
                        }
                    }
                    reader.Close();

                }
            }

            return idSpeler2;
        }
        /// <summary>
        /// Bij een keypress wordt er als eerst gekeken naar of a of b. Als het a is krijgt speler a de beurt. Hierna wordt er gekeken naar arrow up en down. Bij arrow up geef je antwoord a en bij down geef je b. Dan worden de label kleuren geupdate en de punten toegekend.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EenvsEenQuizscerm_KeyDown(object sender, KeyEventArgs e)
        {
            GetIdByName1(Naam1);
            GetIdByName2(Naam2);
            int vraagId = currentquestion.id;

            if (AcceptingInput)
            {
                if (e.KeyCode == Keys.A && isdebeurtgekaapt == false)
                {
                    beurtspeler1 = true;
                    beurtspeler2 = false;
                    isdebeurtgekaapt = true;
                    NaamSpeler1.ForeColor = Color.Green;
                    NaamSpeler2.ForeColor = Color.Red;

                }
                else if (e.KeyCode == Keys.B && isdebeurtgekaapt == false)
                {
                    beurtspeler2 = true;
                    beurtspeler1 = false;
                    isdebeurtgekaapt = true;
                    NaamSpeler2.ForeColor = Color.Green;
                    NaamSpeler1.ForeColor = Color.Red;
                }

                if (beurtspeler1 == true)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        HasGivenInput = true;
                        isdebeurtgekaapt = false;
                        AnswerA.ForeColor = SelectedColor;
                        ALetter.ForeColor = SelectedColor;
                        SelectedA.BackColor = SelectedColor;

                        if (CorrectAnswer == "A")
                        {
                            ALetter.BackColor = CorrectColor;
                            AnswerA.BackColor = CorrectColor;

                            CorrectInput = true;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = true;
                            puntenSpeler1 = puntenSpeler1 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                            progress();
                            speler1heeftgoedandwoord = true;
                        }
                        else if (CorrectAnswer == "B")
                        {
                            AnswerA.BackColor = IncorrectColor;
                            ALetter.BackColor = IncorrectColor;
                            BLetter.BackColor = CorrectColor;
                            AnswerB.BackColor = CorrectColor;
                            SelectedB.BackColor = CorrectColor;

                            CorrectInput = false;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = false;
                            fout1 = fout1 + 1;
                            puntenSpeler2 = puntenSpeler2 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                            progress();
                        }
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        HasGivenInput = true;
                        isdebeurtgekaapt = false;
                        AnswerB.ForeColor = SelectedColor;
                        BLetter.ForeColor = SelectedColor;
                        SelectedB.BackColor = SelectedColor;

                        if (CorrectAnswer == "B")
                        {
                            BLetter.BackColor = CorrectColor;
                            AnswerB.BackColor = CorrectColor;
                            
                            CorrectInput = true;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = true;
                            puntenSpeler1 = puntenSpeler1 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                            progress();
                            speler1heeftgoedandwoord = true;
                        }
                        else if (CorrectAnswer == "A")
                        {
                            AnswerB.BackColor = IncorrectColor;
                            BLetter.BackColor = IncorrectColor;
                            ALetter.BackColor = CorrectColor;
                            AnswerA.BackColor = CorrectColor;
                            SelectedA.BackColor = CorrectColor;

                            CorrectInput = false;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = false;
                            fout1 = fout1 + 1;
                            puntenSpeler2 = puntenSpeler2 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                            progress();
                        }
                    }
                }
                else if (beurtspeler2 == true)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        HasGivenInput = true;
                        isdebeurtgekaapt = false;
                        AnswerA.ForeColor = SelectedColor;
                        ALetter.ForeColor = SelectedColor;
                        SelectedA.BackColor = SelectedColor;

                        if (CorrectAnswer == "A")
                        {
                            ALetter.BackColor = CorrectColor;
                            AnswerA.BackColor = CorrectColor;

                            CorrectInput = true;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = true;
                            puntenSpeler2 = puntenSpeler2 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                            progress();
                            speler2heeftgoedandwoord = true;
                        }
                        else if (CorrectAnswer == "B")
                        {
                            AnswerA.BackColor = IncorrectColor;
                            ALetter.BackColor = IncorrectColor;
                            BLetter.BackColor = CorrectColor;
                            AnswerB.BackColor = CorrectColor;
                            SelectedB.BackColor = CorrectColor;

                            CorrectInput = false;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = false;
                            fout2 = fout2 + 1;
                            puntenSpeler1 = puntenSpeler1 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                            progress();
                        }
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        HasGivenInput = true;
                        isdebeurtgekaapt = false;
                        AnswerB.ForeColor = SelectedColor;
                        BLetter.ForeColor = SelectedColor;
                        SelectedB.BackColor = SelectedColor;

                        if (CorrectAnswer == "B")
                        {
                            BLetter.BackColor = CorrectColor;
                            AnswerB.BackColor = CorrectColor;

                            CorrectInput = true;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = true;
                            puntenSpeler2 = puntenSpeler2 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                            progress();
                            speler2heeftgoedandwoord = true;
                        }
                        else
                        {
                            AnswerB.BackColor = IncorrectColor;
                            BLetter.BackColor = IncorrectColor;
                            ALetter.BackColor = CorrectColor;
                            AnswerA.BackColor = CorrectColor;
                            SelectedA.BackColor = CorrectColor;

                            CorrectInput = false;
                            AftelNaarVolgende = defaultAftelNaarVolgende;
                            IsCountingDown = true;
                            IsGoedBeandwoord = false;
                            fout2 = fout2 + 1;
                            puntenSpeler1 = puntenSpeler1 + 10;
                            setlabels();
                            AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                            progress();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// na het geven van een antwoord heb je 3 seconden en dan komt de volgende vraag. als er verder geen vragen meer zijn opent het resultaten scherm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AftelTimerVolgendeVraag_Tick(object sender, EventArgs e)
        {
            if (HasGivenInput == true && IsCountingDown == true)
            {
                if (AftelNaarVolgende > 0)
                {
                    AftelNaarVolgende--;
                }

                if (AftelNaarVolgende == 0)
                {
                    IsCountingDown = false;

                    if (Questions.Count > 0)
                    {
                        AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);
                    }
                    else
                    {
                        CheckAantalVragen();
                        resultatenvs myForm = new resultatenvs(Naam1, Naam2, AantalGoedBeandwoordeVragen1, AantalGoedBeandwoordeVragen2, fout1, fout2);
                        myForm.ShowDialog();
                        Close();
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void CheckAantalVragen()
        {
            string query = "SELECT id FROM speler WHERE naam = '" + Naam1 + "'";

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
                            userId1 = (int)reader["id"];
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            string query2 = "SELECT id FROM speler WHERE naam = '" + Naam2 + "'";
            using (MySqlConnection connection2 = new MySqlConnection())
            {
                connection2.ConnectionString = DatabaseSettings.Connectionstring;
                using (MySqlCommand command2 = new MySqlCommand(query2, connection2))
                {
                    connection2.Open();
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            userId2 = (int)reader2["id"];
                        }
                    }
                    reader2.Close();
                    connection2.Close();
                }
            }



            if(speler1heeftgoedandwoord == true)
            {
                string query3 = "SELECT sum(IsGoedBeandwoord) AS IsGoedBeandwoord FROM andwoordvs WHERE userId = " + userId1 + "";

                using (MySqlConnection connection3 = new MySqlConnection())
                {
                    connection3.ConnectionString = DatabaseSettings.Connectionstring;
                    using (MySqlCommand command3 = new MySqlCommand(query3, connection3))
                    {
                        connection3.Open();
                        MySqlDataReader reader3 = command3.ExecuteReader();
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                AantalGoedBeandwoordeVragen1 = Convert.ToInt32(reader3["IsGoedBeandwoord"]);

                            }
                        }
                        reader3.Close();
                        connection3.Close();
                        AantalFouteVragen1 = aantalVragen - AantalGoedBeandwoordeVragen1;
                    }
                }
            }
            
            if (speler2heeftgoedandwoord == true)
            {
                string query4 = "SELECT sum(IsGoedBeandwoord) AS IsGoedBeandwoord FROM andwoordvs WHERE userId = " + userId2 + "";

                using (MySqlConnection connection4 = new MySqlConnection())
                {
                    connection4.ConnectionString = DatabaseSettings.Connectionstring;
                    using (MySqlCommand command4 = new MySqlCommand(query4, connection4))
                    {
                        connection4.Open();
                        MySqlDataReader reader4 = command4.ExecuteReader();
                        if (reader4.HasRows)
                        {
                            while (reader4.Read())
                            {
                                AantalGoedBeandwoordeVragen2 = Convert.ToInt32(reader4["IsGoedBeandwoord"]);

                            }
                        }
                        reader4.Close();
                        connection4.Close();
                        AantalFouteVragen2 = aantalVragen - AantalGoedBeandwoordeVragen2;
                    }
                }
            }
        }
    }
}
