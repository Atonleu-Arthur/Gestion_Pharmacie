namespace FormPharmacie
{
    partial class FormChoixProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoixProduit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnQuitter = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrechercher = new Guna.UI.WinForms.GunaTextBox();
            this.BtnAjoutProduit = new Guna.UI.WinForms.GunaCircleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuitter.AnimationHoverSpeed = 0.07F;
            this.BtnQuitter.AnimationSpeed = 0.03F;
            this.BtnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuitter.BaseColor = System.Drawing.Color.White;
            this.BtnQuitter.BorderColor = System.Drawing.Color.Silver;
            this.BtnQuitter.BorderSize = 1;
            this.BtnQuitter.FocusedColor = System.Drawing.Color.Empty;
            this.BtnQuitter.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.Color.Black;
            this.BtnQuitter.Image = null;
            this.BtnQuitter.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnQuitter.Location = new System.Drawing.Point(828, 688);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnQuitter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnQuitter.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnQuitter.OnHoverImage = null;
            this.BtnQuitter.OnPressedColor = System.Drawing.Color.Black;
            this.BtnQuitter.Radius = 10;
            this.BtnQuitter.Size = new System.Drawing.Size(144, 34);
            this.BtnQuitter.TabIndex = 111;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 112;
            this.label1.Text = "Medicament";
            // 
            // txtrechercher
            // 
            this.txtrechercher.BackColor = System.Drawing.Color.Transparent;
            this.txtrechercher.BaseColor = System.Drawing.Color.White;
            this.txtrechercher.BorderColor = System.Drawing.Color.Silver;
            this.txtrechercher.BorderSize = 1;
            this.txtrechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrechercher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtrechercher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtrechercher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtrechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtrechercher.Location = new System.Drawing.Point(237, 95);
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.PasswordChar = '\0';
            this.txtrechercher.Radius = 10;
            this.txtrechercher.Size = new System.Drawing.Size(365, 32);
            this.txtrechercher.TabIndex = 113;
            this.txtrechercher.TextChanged += new System.EventHandler(this.GunaTextBox1_TextChanged);
            // 
            // BtnAjoutProduit
            // 
            this.BtnAjoutProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAjoutProduit.AnimationHoverSpeed = 0.07F;
            this.BtnAjoutProduit.AnimationSpeed = 0.03F;
            this.BtnAjoutProduit.BaseColor = System.Drawing.Color.Sienna;
            this.BtnAjoutProduit.BorderColor = System.Drawing.Color.Black;
            this.BtnAjoutProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAjoutProduit.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAjoutProduit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjoutProduit.ForeColor = System.Drawing.Color.Black;
            this.BtnAjoutProduit.Image = null;
            this.BtnAjoutProduit.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnAjoutProduit.Location = new System.Drawing.Point(640, 95);
            this.BtnAjoutProduit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjoutProduit.Name = "BtnAjoutProduit";
            this.BtnAjoutProduit.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.BtnAjoutProduit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutProduit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.BtnAjoutProduit.OnHoverImage = null;
            this.BtnAjoutProduit.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutProduit.Size = new System.Drawing.Size(43, 32);
            this.BtnAjoutProduit.TabIndex = 115;
            this.BtnAjoutProduit.Text = "F9";
            this.BtnAjoutProduit.Click += new System.EventHandler(this.BtnAjoutProduit_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(403, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 171;
            this.button1.Text = "Choisir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 29;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column5,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridView1.Location = new System.Drawing.Point(5, 145);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(976, 523);
            this.DataGridView1.TabIndex = 172;
            this.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nom_medicament";
            this.Column2.HeaderText = "Nom du medicament";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Dosage";
            this.Column1.HeaderText = "Dosage";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DCI";
            this.Column5.HeaderText = "Dci";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Forme";
            this.Column3.HeaderText = "Forme";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Conditionnement";
            this.Column4.HeaderText = "Conditionnement";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 64);
            this.label2.TabIndex = 115;
            this.label2.Text = "Choix produit";
            // 
            // FormChoixProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAjoutProduit);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChoixProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Pharma";
            this.Load += new System.EventHandler(this.FormChoixProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton BtnQuitter;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtrechercher;
        private Guna.UI.WinForms.GunaCircleButton BtnAjoutProduit;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaDataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
    }
}