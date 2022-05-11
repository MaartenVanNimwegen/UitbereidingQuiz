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
        string Naam1;
        string Naam2;
        string Naamvs;
        string CorrectAnswer = "";
        string GegevenAndwoord;
        
        int aantalVragen;
        int tijdPerVraag;
        int strafTijd;
        int puntenSpeler1 = 0;
        int puntenSpeler2 = 0;
        int QuestionAmount = 10;
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

        bool TimerPlaying = false;
        bool AcceptingInput = false;
        bool HasGivenInput = false;
        bool CorrectInput;
        bool IsCountingDown = false;
        bool IsGoedBeandwoord;
        bool beurtspeler1 = false;
        bool beurtspeler2= false;

        List<VraagClass> Questions;
        VraagClass currentquestion;

        Color IncorrectColor = Color.FromArgb(216, 34, 10);
        Color CorrectColor = Color.FromArgb(54, 183, 47);
        Color SelectedColor = Color.FromArgb(234, 228, 171);
        Color DefaultColor = Color.FromArgb(41, 76, 146);

        public EenvsEenQuizscmer(bool QuizIsCustom, int AantalVragen, int TijdPerVraag, int StrafTijd, string naam1, string naam2, string naamvs)
        {
            InitializeComponent();

            aantalVragen = AantalVragen;
            tijdPerVraag = TijdPerVraag;
            strafTijd = StrafTijd;
            Naam1 = naam1;
            Naam2 = naam2;
            Naamvs = naamvs;
            
            Questions = GetQuestions(QuestionAmount);
            setlabels();
            AskQuestion(Questions[QuestionsCurrentListIndex], QuestionsCurrentListIndex);

        }
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
        private void setlabels()
        {
            NaamSpeler1.Text = Naam1;
            NaamSpeler2.Text = Naam2;
            PuntenSpeler1.Text = puntenSpeler1.ToString();
            PuntenSpeler2.Text = puntenSpeler2.ToString();
        }
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
        private void AntwoordOpslaan(int userId, int vraagId, bool antwoord)
        { 
            string query = "INSERT INTO andwoordvs (userId, vraagId, IsGoedBeandwoord, datum) VALUES ('" + userId + "', '" + vraagId + "', '" + IsGoedBeandwoord + "', now())";


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
        public void progress()
        {
            int Step = 100 / QuestionAmount;

            progressBar.Step = Step;
            progressBar.Value = Step * VraagNummer;
        }
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
        public void EenvsEenQuizscerm_KeyDown(object sender, KeyEventArgs e)
        {
            //
            GetIdByName1(Naam1);
            GetIdByName2(Naam2);
            int vraagId = currentquestion.id;

            if (e.KeyCode == Keys.A)
            {
                beurtspeler1 = true;
                NaamSpeler1.ForeColor = Color.Green;
            }
            else if (e.KeyCode == Keys.B)
            {
                beurtspeler2 = true;
                NaamSpeler2.ForeColor = Color.Green;
            }

            if (beurtspeler1 == true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    HasGivenInput = true;
                    AnswerA.ForeColor = SelectedColor;
                    ALetter.ForeColor = SelectedColor;
                    SelectedA.BackColor = SelectedColor;

                    if (CorrectAnswer == "A")
                    {
                        SelectedB.BackColor = IncorrectColor;

                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = true;
                        AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                    else
                    {
                        SelectedB.BackColor = CorrectColor;

                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = false;
                        AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    HasGivenInput = true;
                    AnswerB.ForeColor = SelectedColor;
                    BLetter.ForeColor = SelectedColor;
                    SelectedB.BackColor = SelectedColor;

                    if (CorrectAnswer == "B")
                    {
                        SelectedA.BackColor = IncorrectColor;
                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = true;
                        AntwoordOpslaan(idSpeler1, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                    else
                    {
                        SelectedA.BackColor = CorrectColor;
                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = false;
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
                    AnswerA.ForeColor = SelectedColor;
                    ALetter.ForeColor = SelectedColor;
                    SelectedA.BackColor = SelectedColor;

                    if (CorrectAnswer == "A")
                    {
                        SelectedB.BackColor = IncorrectColor;

                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = true;
                        AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                    else
                    {
                        SelectedB.BackColor = CorrectColor;

                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = false;
                        AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    HasGivenInput = true;
                    AnswerB.ForeColor = SelectedColor;
                    BLetter.ForeColor = SelectedColor;
                    SelectedB.BackColor = SelectedColor;

                    if (CorrectAnswer == "B")
                    {
                        SelectedA.BackColor = IncorrectColor;
                        CorrectInput = true;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = true;
                        AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                    else
                    {
                        SelectedA.BackColor = CorrectColor;
                        CorrectInput = false;
                        AftelNaarVolgende = defaultAftelNaarVolgende;
                        IsCountingDown = true;
                        IsGoedBeandwoord = false;
                        AntwoordOpslaan(idSpeler2, vraagId, IsGoedBeandwoord);
                        progress();
                    }
                }
            }
        }
    }
}
