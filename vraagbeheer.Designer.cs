
namespace UitbereidingQuiz
{
    partial class vraagbeheer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vraagbeheer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.VraagLable = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            this.VragenGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummerArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caregorieArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditGridBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteGridBtn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VragenGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1004, 10);
            this.label4.TabIndex = 71;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VraagLable
            // 
            this.VraagLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VraagLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VraagLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraagLable.ForeColor = System.Drawing.SystemColors.Control;
            this.VraagLable.Location = new System.Drawing.Point(10, 9);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1004, 73);
            this.VraagLable.TabIndex = 68;
            this.VraagLable.Text = "Vragenbeheer";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(22, 28);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(43, 38);
            this.CancelBtn.TabIndex = 70;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // VragenGrid
            // 
            this.VragenGrid.AllowUserToAddRows = false;
            this.VragenGrid.AllowUserToDeleteRows = false;
            this.VragenGrid.AllowUserToOrderColumns = true;
            this.VragenGrid.AllowUserToResizeColumns = false;
            this.VragenGrid.AllowUserToResizeRows = false;
            this.VragenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VragenGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VragenGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VragenGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VragenGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VragenGrid.ColumnHeadersHeight = 40;
            this.VragenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nummerArtikel,
            this.naamArtikel,
            this.caregorieArtikel,
            this.EditGridBtn,
            this.DeleteGridBtn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VragenGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.VragenGrid.EnableHeadersVisualStyles = false;
            this.VragenGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VragenGrid.Location = new System.Drawing.Point(12, 106);
            this.VragenGrid.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.VragenGrid.MultiSelect = false;
            this.VragenGrid.Name = "VragenGrid";
            this.VragenGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VragenGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.VragenGrid.RowHeadersVisible = false;
            this.VragenGrid.RowHeadersWidth = 51;
            this.VragenGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.VragenGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.VragenGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.VragenGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.VragenGrid.RowTemplate.Height = 30;
            this.VragenGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VragenGrid.ShowCellErrors = false;
            this.VragenGrid.ShowCellToolTips = false;
            this.VragenGrid.ShowEditingIcon = false;
            this.VragenGrid.ShowRowErrors = false;
            this.VragenGrid.Size = new System.Drawing.Size(1000, 574);
            this.VragenGrid.TabIndex = 72;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 608;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 608;
            // 
            // nummerArtikel
            // 
            this.nummerArtikel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nummerArtikel.HeaderText = "Vraag";
            this.nummerArtikel.MinimumWidth = 300;
            this.nummerArtikel.Name = "nummerArtikel";
            this.nummerArtikel.ReadOnly = true;
            this.nummerArtikel.Width = 300;
            // 
            // naamArtikel
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.naamArtikel.DefaultCellStyle = dataGridViewCellStyle2;
            this.naamArtikel.HeaderText = "Goed Antwoord";
            this.naamArtikel.MinimumWidth = 300;
            this.naamArtikel.Name = "naamArtikel";
            this.naamArtikel.ReadOnly = true;
            this.naamArtikel.Width = 300;
            // 
            // caregorieArtikel
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.caregorieArtikel.DefaultCellStyle = dataGridViewCellStyle3;
            this.caregorieArtikel.HeaderText = "Fout Antwoord";
            this.caregorieArtikel.MinimumWidth = 300;
            this.caregorieArtikel.Name = "caregorieArtikel";
            this.caregorieArtikel.ReadOnly = true;
            this.caregorieArtikel.Width = 300;
            // 
            // EditGridBtn
            // 
            this.EditGridBtn.HeaderText = "";
            this.EditGridBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditGridBtn.Image")));
            this.EditGridBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.EditGridBtn.MinimumWidth = 30;
            this.EditGridBtn.Name = "EditGridBtn";
            this.EditGridBtn.ReadOnly = true;
            this.EditGridBtn.Width = 30;
            // 
            // DeleteGridBtn
            // 
            this.DeleteGridBtn.HeaderText = "";
            this.DeleteGridBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteGridBtn.Image")));
            this.DeleteGridBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.DeleteGridBtn.MinimumWidth = 30;
            this.DeleteGridBtn.Name = "DeleteGridBtn";
            this.DeleteGridBtn.ReadOnly = true;
            this.DeleteGridBtn.Width = 30;
            // 
            // vraagbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1024, 690);
            this.ControlBox = false;
            this.Controls.Add(this.VragenGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.VraagLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vraagbeheer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vraagbeheer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VragenGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox CancelBtn;
        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView VragenGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn caregorieArtikel;
        private System.Windows.Forms.DataGridViewImageColumn EditGridBtn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteGridBtn;
    }
}