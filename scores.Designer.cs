
namespace UitbereidingQuiz
{
    partial class scores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.VraagLable = new System.Windows.Forms.Label();
            this.AntwoordGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gebruiktetijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.straftijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotaleTijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntwoordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1120, 10);
            this.label4.TabIndex = 54;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(18, 16);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(41, 44);
            this.BackBtn.TabIndex = 53;
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
            this.VraagLable.Location = new System.Drawing.Point(9, 7);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1120, 61);
            this.VraagLable.TabIndex = 52;
            this.VraagLable.Text = "Scores";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AntwoordGrid
            // 
            this.AntwoordGrid.AllowUserToAddRows = false;
            this.AntwoordGrid.AllowUserToDeleteRows = false;
            this.AntwoordGrid.AllowUserToOrderColumns = true;
            this.AntwoordGrid.AllowUserToResizeColumns = false;
            this.AntwoordGrid.AllowUserToResizeRows = false;
            this.AntwoordGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AntwoordGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AntwoordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AntwoordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AntwoordGrid.ColumnHeadersHeight = 40;
            this.AntwoordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Naam,
            this.gebruiktetijd,
            this.straftijd,
            this.TotaleTijd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AntwoordGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AntwoordGrid.EnableHeadersVisualStyles = false;
            this.AntwoordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.Location = new System.Drawing.Point(9, 98);
            this.AntwoordGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AntwoordGrid.MultiSelect = false;
            this.AntwoordGrid.Name = "AntwoordGrid";
            this.AntwoordGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AntwoordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.AntwoordGrid.RowHeadersVisible = false;
            this.AntwoordGrid.RowHeadersWidth = 51;
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AntwoordGrid.RowTemplate.Height = 30;
            this.AntwoordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AntwoordGrid.ShowCellErrors = false;
            this.AntwoordGrid.ShowCellToolTips = false;
            this.AntwoordGrid.ShowEditingIcon = false;
            this.AntwoordGrid.ShowRowErrors = false;
            this.AntwoordGrid.Size = new System.Drawing.Size(1118, 599);
            this.AntwoordGrid.TabIndex = 55;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.MinimumWidth = 300;
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            this.Naam.Width = 300;
            // 
            // gebruiktetijd
            // 
            this.gebruiktetijd.HeaderText = "Gebruikte Tijd";
            this.gebruiktetijd.MinimumWidth = 300;
            this.gebruiktetijd.Name = "gebruiktetijd";
            this.gebruiktetijd.ReadOnly = true;
            this.gebruiktetijd.Width = 300;
            // 
            // straftijd
            // 
            this.straftijd.HeaderText = "Straf Tijd";
            this.straftijd.MinimumWidth = 300;
            this.straftijd.Name = "straftijd";
            this.straftijd.ReadOnly = true;
            this.straftijd.Width = 300;
            // 
            // TotaleTijd
            // 
            this.TotaleTijd.HeaderText = "Totale tijd";
            this.TotaleTijd.MinimumWidth = 300;
            this.TotaleTijd.Name = "TotaleTijd";
            this.TotaleTijd.ReadOnly = true;
            this.TotaleTijd.Width = 300;
            // 
            // scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1138, 707);
            this.Controls.Add(this.AntwoordGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.VraagLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "scores";
            this.Text = "scores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntwoordGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.DataGridView AntwoordGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebruiktetijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn straftijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotaleTijd;
    }
}