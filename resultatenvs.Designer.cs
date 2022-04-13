
namespace UitbereidingQuiz
{
    partial class resultatenvs
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
            this.bg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultatenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.bg.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bg.ForeColor = System.Drawing.SystemColors.Control;
            this.bg.Location = new System.Drawing.Point(12, 113);
            this.bg.Name = "bg";
            this.bg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bg.Size = new System.Drawing.Size(1114, 460);
            this.bg.TabIndex = 62;
            this.bg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1114, 10);
            this.label4.TabIndex = 61;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultatenLabel
            // 
            this.ResultatenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultatenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.ResultatenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultatenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ResultatenLabel.Location = new System.Drawing.Point(12, 10);
            this.ResultatenLabel.Name = "ResultatenLabel";
            this.ResultatenLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultatenLabel.Size = new System.Drawing.Size(1114, 82);
            this.ResultatenLabel.TabIndex = 60;
            this.ResultatenLabel.Text = "Resultaten";
            this.ResultatenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultatenvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1138, 588);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultatenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resultatenvs";
            this.Text = "resultatenvs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label bg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResultatenLabel;
    }
}