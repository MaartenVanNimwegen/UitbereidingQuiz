
namespace UitbereidingQuiz
{
    partial class naaminvullen
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
            this.button1 = new System.Windows.Forms.Button();
            this.NaamSpeler1 = new System.Windows.Forms.TextBox();
            this.SpelerNaamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start quiz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NaamSpeler1
            // 
            this.NaamSpeler1.Location = new System.Drawing.Point(17, 37);
            this.NaamSpeler1.Name = "NaamSpeler1";
            this.NaamSpeler1.Size = new System.Drawing.Size(100, 22);
            this.NaamSpeler1.TabIndex = 7;
            // 
            // SpelerNaamLabel
            // 
            this.SpelerNaamLabel.AutoSize = true;
            this.SpelerNaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelerNaamLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SpelerNaamLabel.Location = new System.Drawing.Point(12, 9);
            this.SpelerNaamLabel.Name = "SpelerNaamLabel";
            this.SpelerNaamLabel.Size = new System.Drawing.Size(188, 25);
            this.SpelerNaamLabel.TabIndex = 5;
            this.SpelerNaamLabel.Text = "Vul hier uw naam in:";
            // 
            // naaminvullen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(216, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NaamSpeler1);
            this.Controls.Add(this.SpelerNaamLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "naaminvullen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "naaminvullen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NaamSpeler1;
        private System.Windows.Forms.Label SpelerNaamLabel;
    }
}