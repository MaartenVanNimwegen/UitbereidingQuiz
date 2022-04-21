
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
            this.StartquizQuick = new System.Windows.Forms.Button();
            this.NaamSpelerTextbox = new System.Windows.Forms.TextBox();
            this.SpelerNaamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartquizQuick
            // 
            this.StartquizQuick.Location = new System.Drawing.Point(13, 53);
            this.StartquizQuick.Margin = new System.Windows.Forms.Padding(2);
            this.StartquizQuick.Name = "StartquizQuick";
            this.StartquizQuick.Size = new System.Drawing.Size(75, 24);
            this.StartquizQuick.TabIndex = 9;
            this.StartquizQuick.Text = "Start quiz";
            this.StartquizQuick.UseVisualStyleBackColor = true;
            this.StartquizQuick.Click += new System.EventHandler(this.StartquizQuick_Click);
            // 
            // NaamSpelerTextbox
            // 
            this.NaamSpelerTextbox.Location = new System.Drawing.Point(13, 30);
            this.NaamSpelerTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NaamSpelerTextbox.Name = "NaamSpelerTextbox";
            this.NaamSpelerTextbox.Size = new System.Drawing.Size(76, 20);
            this.NaamSpelerTextbox.TabIndex = 7;
            // 
            // SpelerNaamLabel
            // 
            this.SpelerNaamLabel.AutoSize = true;
            this.SpelerNaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelerNaamLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SpelerNaamLabel.Location = new System.Drawing.Point(9, 7);
            this.SpelerNaamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpelerNaamLabel.Name = "SpelerNaamLabel";
            this.SpelerNaamLabel.Size = new System.Drawing.Size(150, 20);
            this.SpelerNaamLabel.TabIndex = 5;
            this.SpelerNaamLabel.Text = "Vul hier uw naam in:";
            // 
            // naaminvullen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(162, 101);
            this.Controls.Add(this.StartquizQuick);
            this.Controls.Add(this.NaamSpelerTextbox);
            this.Controls.Add(this.SpelerNaamLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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

        private System.Windows.Forms.Button StartquizQuick;
        private System.Windows.Forms.TextBox NaamSpelerTextbox;
        private System.Windows.Forms.Label SpelerNaamLabel;
    }
}