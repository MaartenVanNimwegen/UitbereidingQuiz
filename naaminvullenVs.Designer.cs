
namespace UitbereidingQuiz
{
    partial class naaminvullenVs
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
            this.Speler1NaamLabel = new System.Windows.Forms.Label();
            this.Speler2NaamLabel = new System.Windows.Forms.Label();
            this.NaamSpeler1 = new System.Windows.Forms.TextBox();
            this.NaamSpeler2 = new System.Windows.Forms.TextBox();
            this.StartOnevsOneQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speler1NaamLabel
            // 
            this.Speler1NaamLabel.AutoSize = true;
            this.Speler1NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speler1NaamLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Speler1NaamLabel.Location = new System.Drawing.Point(5, 7);
            this.Speler1NaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Speler1NaamLabel.Name = "Speler1NaamLabel";
            this.Speler1NaamLabel.Size = new System.Drawing.Size(72, 20);
            this.Speler1NaamLabel.TabIndex = 0;
            this.Speler1NaamLabel.Text = "Speler 1:\r\n";
            // 
            // Speler2NaamLabel
            // 
            this.Speler2NaamLabel.AutoSize = true;
            this.Speler2NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speler2NaamLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Speler2NaamLabel.Location = new System.Drawing.Point(5, 72);
            this.Speler2NaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Speler2NaamLabel.Name = "Speler2NaamLabel";
            this.Speler2NaamLabel.Size = new System.Drawing.Size(68, 20);
            this.Speler2NaamLabel.TabIndex = 1;
            this.Speler2NaamLabel.Text = "Speler 2";
            // 
            // NaamSpeler1
            // 
            this.NaamSpeler1.Location = new System.Drawing.Point(9, 30);
            this.NaamSpeler1.Margin = new System.Windows.Forms.Padding(2);
            this.NaamSpeler1.Name = "NaamSpeler1";
            this.NaamSpeler1.Size = new System.Drawing.Size(76, 20);
            this.NaamSpeler1.TabIndex = 2;
            // 
            // NaamSpeler2
            // 
            this.NaamSpeler2.Location = new System.Drawing.Point(9, 94);
            this.NaamSpeler2.Margin = new System.Windows.Forms.Padding(2);
            this.NaamSpeler2.Name = "NaamSpeler2";
            this.NaamSpeler2.Size = new System.Drawing.Size(76, 20);
            this.NaamSpeler2.TabIndex = 3;
            // 
            // StartOnevsOneQuiz
            // 
            this.StartOnevsOneQuiz.Location = new System.Drawing.Point(106, 95);
            this.StartOnevsOneQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.StartOnevsOneQuiz.Name = "StartOnevsOneQuiz";
            this.StartOnevsOneQuiz.Size = new System.Drawing.Size(72, 24);
            this.StartOnevsOneQuiz.TabIndex = 4;
            this.StartOnevsOneQuiz.Text = "Start quiz";
            this.StartOnevsOneQuiz.UseVisualStyleBackColor = true;
            this.StartOnevsOneQuiz.Click += new System.EventHandler(this.StartOnevsOneQuiz_Click);
            // 
            // naaminvullenVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(187, 129);
            this.Controls.Add(this.StartOnevsOneQuiz);
            this.Controls.Add(this.NaamSpeler2);
            this.Controls.Add(this.NaamSpeler1);
            this.Controls.Add(this.Speler2NaamLabel);
            this.Controls.Add(this.Speler1NaamLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "naaminvullenVs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vul jullie namen in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Speler1NaamLabel;
        private System.Windows.Forms.Label Speler2NaamLabel;
        private System.Windows.Forms.TextBox NaamSpeler1;
        private System.Windows.Forms.TextBox NaamSpeler2;
        private System.Windows.Forms.Button StartOnevsOneQuiz;
    }
}