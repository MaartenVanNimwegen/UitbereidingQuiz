
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speler1NaamLabel
            // 
            this.Speler1NaamLabel.AutoSize = true;
            this.Speler1NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speler1NaamLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Speler1NaamLabel.Location = new System.Drawing.Point(7, 9);
            this.Speler1NaamLabel.Name = "Speler1NaamLabel";
            this.Speler1NaamLabel.Size = new System.Drawing.Size(91, 25);
            this.Speler1NaamLabel.TabIndex = 0;
            this.Speler1NaamLabel.Text = "Speler 1:\r\n";
            // 
            // Speler2NaamLabel
            // 
            this.Speler2NaamLabel.AutoSize = true;
            this.Speler2NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speler2NaamLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Speler2NaamLabel.Location = new System.Drawing.Point(7, 88);
            this.Speler2NaamLabel.Name = "Speler2NaamLabel";
            this.Speler2NaamLabel.Size = new System.Drawing.Size(85, 25);
            this.Speler2NaamLabel.TabIndex = 1;
            this.Speler2NaamLabel.Text = "Speler 2";
            // 
            // NaamSpeler1
            // 
            this.NaamSpeler1.Location = new System.Drawing.Point(12, 37);
            this.NaamSpeler1.Name = "NaamSpeler1";
            this.NaamSpeler1.Size = new System.Drawing.Size(100, 22);
            this.NaamSpeler1.TabIndex = 2;
            // 
            // NaamSpeler2
            // 
            this.NaamSpeler2.Location = new System.Drawing.Point(12, 116);
            this.NaamSpeler2.Name = "NaamSpeler2";
            this.NaamSpeler2.Size = new System.Drawing.Size(100, 22);
            this.NaamSpeler2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start quiz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // naaminvullenVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(249, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NaamSpeler2);
            this.Controls.Add(this.NaamSpeler1);
            this.Controls.Add(this.Speler2NaamLabel);
            this.Controls.Add(this.Speler1NaamLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "naaminvullenVs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "naaminvullen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Speler1NaamLabel;
        private System.Windows.Forms.Label Speler2NaamLabel;
        private System.Windows.Forms.TextBox NaamSpeler1;
        private System.Windows.Forms.TextBox NaamSpeler2;
        private System.Windows.Forms.Button button1;
    }
}