﻿
namespace UitbereidingQuiz
{
    partial class quizscherm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizscherm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.VraagLable = new System.Windows.Forms.Label();
            this.AnswerB = new System.Windows.Forms.Label();
            this.BLetter = new System.Windows.Forms.Label();
            this.AnswerA = new System.Windows.Forms.Label();
            this.ALetter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExtraSecondsLabel = new System.Windows.Forms.Label();
            this.GlobalTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuestionTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedA = new System.Windows.Forms.Label();
            this.SelectedB = new System.Windows.Forms.Label();
            this.GlobalCountUpTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.AftelTimerVolgendeVraag = new System.Windows.Forms.Timer(this.components);
            this.TijdVanAntwoorden = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.Yellow;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Location = new System.Drawing.Point(13, 207);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1429, 12);
            this.progressBar.TabIndex = 68;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(25, 93);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(55, 50);
            this.BackBtn.TabIndex = 69;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // VraagLable
            // 
            this.VraagLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VraagLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VraagLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraagLable.ForeColor = System.Drawing.SystemColors.Control;
            this.VraagLable.Location = new System.Drawing.Point(15, 11);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1432, 208);
            this.VraagLable.TabIndex = 67;
            this.VraagLable.Text = "Vraag";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerB
            // 
            this.AnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.AnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerB.ForeColor = System.Drawing.SystemColors.Control;
            this.AnswerB.Location = new System.Drawing.Point(233, 338);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnswerB.Size = new System.Drawing.Size(723, 126);
            this.AnswerB.TabIndex = 73;
            this.AnswerB.Text = "Antwoord B";
            this.AnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BLetter
            // 
            this.BLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.BLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLetter.ForeColor = System.Drawing.SystemColors.Control;
            this.BLetter.Location = new System.Drawing.Point(45, 325);
            this.BLetter.Name = "BLetter";
            this.BLetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BLetter.Size = new System.Drawing.Size(187, 148);
            this.BLetter.TabIndex = 72;
            this.BLetter.Text = "B";
            this.BLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerA
            // 
            this.AnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.AnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerA.ForeColor = System.Drawing.Color.White;
            this.AnswerA.Location = new System.Drawing.Point(233, 99);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnswerA.Size = new System.Drawing.Size(723, 130);
            this.AnswerA.TabIndex = 71;
            this.AnswerA.Text = "Antwoord A";
            this.AnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ALetter
            // 
            this.ALetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.ALetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALetter.ForeColor = System.Drawing.SystemColors.Control;
            this.ALetter.Location = new System.Drawing.Point(45, 90);
            this.ALetter.Name = "ALetter";
            this.ALetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALetter.Size = new System.Drawing.Size(187, 148);
            this.ALetter.TabIndex = 70;
            this.ALetter.Text = "A";
            this.ALetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.ExtraSecondsLabel);
            this.panel1.Controls.Add(this.GlobalTimeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.QuestionTimeLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(981, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 544);
            this.panel1.TabIndex = 74;
            // 
            // ExtraSecondsLabel
            // 
            this.ExtraSecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExtraSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraSecondsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ExtraSecondsLabel.Location = new System.Drawing.Point(312, 170);
            this.ExtraSecondsLabel.Name = "ExtraSecondsLabel";
            this.ExtraSecondsLabel.Size = new System.Drawing.Size(115, 82);
            this.ExtraSecondsLabel.TabIndex = 3;
            this.ExtraSecondsLabel.Text = "0";
            this.ExtraSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GlobalTimeLabel
            // 
            this.GlobalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GlobalTimeLabel.Location = new System.Drawing.Point(303, 89);
            this.GlobalTimeLabel.Name = "GlobalTimeLabel";
            this.GlobalTimeLabel.Size = new System.Drawing.Size(125, 82);
            this.GlobalTimeLabel.TabIndex = 7;
            this.GlobalTimeLabel.Text = "0";
            this.GlobalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 82);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gebruikte tijd:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 82);
            this.label4.TabIndex = 2;
            this.label4.Text = "Strafseconden:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionTimeLabel
            // 
            this.QuestionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.QuestionTimeLabel.Location = new System.Drawing.Point(272, 6);
            this.QuestionTimeLabel.Name = "QuestionTimeLabel";
            this.QuestionTimeLabel.Size = new System.Drawing.Size(160, 82);
            this.QuestionTimeLabel.TabIndex = 1;
            this.QuestionTimeLabel.Text = "0";
            this.QuestionTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 82);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tijd voor deze vraag:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedA
            // 
            this.SelectedA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.SelectedA.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedA.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectedA.Location = new System.Drawing.Point(36, 89);
            this.SelectedA.Name = "SelectedA";
            this.SelectedA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedA.Size = new System.Drawing.Size(13, 149);
            this.SelectedA.TabIndex = 12;
            this.SelectedA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedB
            // 
            this.SelectedB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.SelectedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedB.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectedB.Location = new System.Drawing.Point(36, 325);
            this.SelectedB.Name = "SelectedB";
            this.SelectedB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedB.Size = new System.Drawing.Size(13, 148);
            this.SelectedB.TabIndex = 75;
            this.SelectedB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GlobalCountUpTimer
            // 
            this.GlobalCountUpTimer.Enabled = true;
            this.GlobalCountUpTimer.Interval = 1000;
            this.GlobalCountUpTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // AftelTimerVolgendeVraag
            // 
            this.AftelTimerVolgendeVraag.Enabled = true;
            this.AftelTimerVolgendeVraag.Interval = 1000;
            this.AftelTimerVolgendeVraag.Tick += new System.EventHandler(this.AftelTimerVolgendeVraag_Tick);
            // 
            // TijdVanAntwoorden
            // 
            this.TijdVanAntwoorden.Enabled = true;
            this.TijdVanAntwoorden.Interval = 1000;
            this.TijdVanAntwoorden.Tick += new System.EventHandler(this.TijdVanAntwoorden_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.panel2.Controls.Add(this.ALetter);
            this.panel2.Controls.Add(this.SelectedB);
            this.panel2.Controls.Add(this.AnswerB);
            this.panel2.Controls.Add(this.SelectedA);
            this.panel2.Controls.Add(this.AnswerA);
            this.panel2.Controls.Add(this.BLetter);
            this.panel2.Location = new System.Drawing.Point(16, 235);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 544);
            this.panel2.TabIndex = 75;
            // 
            // quizscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1461, 793);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.VraagLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "quizscherm";
            this.Text = "quizscherm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VragenScherm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.Label AnswerB;
        private System.Windows.Forms.Label BLetter;
        private System.Windows.Forms.Label AnswerA;
        private System.Windows.Forms.Label ALetter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExtraSecondsLabel;
        private System.Windows.Forms.Label GlobalTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label QuestionTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedA;
        private System.Windows.Forms.Label SelectedB;
        private System.Windows.Forms.Timer GlobalCountUpTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer AftelTimerVolgendeVraag;
        private System.Windows.Forms.Timer TijdVanAntwoorden;
        private System.Windows.Forms.Panel panel2;
    }
}