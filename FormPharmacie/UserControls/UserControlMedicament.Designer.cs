namespace FormPharmacie.UserControls
{
    partial class UserControlMedicament
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMedicament));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelCentre1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRecherche = new Guna.UI.WinForms.GunaTextBox();
            this.BtnAjoutMedocs = new Guna.UI.WinForms.GunaButton();
            this.BtnEdit = new Guna.UI.WinForms.GunaButton();
            this.BtnFermer = new Guna.UI.WinForms.GunaButton();
            this.panelCenter.SuspendLayout();
            this.panelCentre1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelCentre1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1494, 776);
            this.panelCenter.TabIndex = 0;
            // 
            // panelCentre1
            // 
            this.panelCentre1.Controls.Add(this.BtnAjoutMedocs);
            this.panelCentre1.Controls.Add(this.label9);
            this.panelCentre1.Controls.Add(this.DataGridView1);
            this.panelCentre1.Controls.Add(this.BtnEdit);
            this.panelCentre1.Controls.Add(this.BtnFermer);
            this.panelCentre1.Controls.Add(this.label11);
            this.panelCentre1.Controls.Add(this.txtRecherche);
            this.panelCentre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre1.ForeColor = System.Drawing.Color.Crimson;
            this.panelCentre1.Location = new System.Drawing.Point(0, 0);
            this.panelCentre1.Name = "panelCentre1";
            this.panelCentre1.Size = new System.Drawing.Size(1494, 776);
            this.panelCentre1.TabIndex = 0;
            this.panelCentre1.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentre1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(375, 23);
            this.label9.TabIndex = 188;
            this.label9.Text = "Doublez cliqué sur un médicament pour le modifier";
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
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 29;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 76);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 21;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.ShowCellErrors = false;
            this.DataGridView1.Size = new System.Drawing.Size(1491, 698);
            this.DataGridView1.TabIndex = 187;
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
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 21;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nom_medicament";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "DCI";
            this.Column6.HeaderText = "DCI";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 300;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Groupe";
            this.Column2.HeaderText = "Groupe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Rayon";
            this.Column3.HeaderText = "Rayon";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Dosage";
            this.Column1.HeaderText = "Dosage";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Forme";
            this.Column4.HeaderText = "Forme";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Conditionnement";
            this.Column5.HeaderText = "Conditionnement";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(395, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 138;
            this.label11.Text = "Rechercher";
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.Transparent;
            this.txtRecherche.BaseColor = System.Drawing.Color.White;
            this.txtRecherche.BorderColor = System.Drawing.Color.Silver;
            this.txtRecherche.BorderSize = 1;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRecherche.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRecherche.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.Black;
            this.txtRecherche.Location = new System.Drawing.Point(532, 13);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PasswordChar = '\0';
            this.txtRecherche.Radius = 15;
            this.txtRecherche.Size = new System.Drawing.Size(364, 30);
            this.txtRecherche.TabIndex = 137;
            this.txtRecherche.TextChanged += new System.EventHandler(this.TxtRecherche_TextChanged);
            // 
            // BtnAjoutMedocs
            // 
            this.BtnAjoutMedocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjoutMedocs.Animated = true;
            this.BtnAjoutMedocs.AnimationHoverSpeed = 0.02F;
            this.BtnAjoutMedocs.AnimationSpeed = 0.03F;
            this.BtnAjoutMedocs.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjoutMedocs.BaseColor = System.Drawing.Color.White;
            this.BtnAjoutMedocs.BorderColor = System.Drawing.Color.Silver;
            this.BtnAjoutMedocs.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAjoutMedocs.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjoutMedocs.ForeColor = System.Drawing.Color.Black;
            this.BtnAjoutMedocs.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjoutMedocs.Image")));
            this.BtnAjoutMedocs.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnAjoutMedocs.Location = new System.Drawing.Point(1191, 44);
            this.BtnAjoutMedocs.Name = "BtnAjoutMedocs";
            this.BtnAjoutMedocs.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnAjoutMedocs.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAjoutMedocs.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAjoutMedocs.OnHoverImage = null;
            this.BtnAjoutMedocs.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutMedocs.OnPressedDepth = 100;
            this.BtnAjoutMedocs.Radius = 15;
            this.BtnAjoutMedocs.Size = new System.Drawing.Size(303, 31);
            this.BtnAjoutMedocs.TabIndex = 189;
            this.BtnAjoutMedocs.Text = "Ajouter des medicaments";
            this.BtnAjoutMedocs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAjoutMedocs.Click += new System.EventHandler(this.BtnAjoutMedocs_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Animated = true;
            this.BtnEdit.AnimationHoverSpeed = 0.02F;
            this.BtnEdit.AnimationSpeed = 0.03F;
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BaseColor = System.Drawing.Color.White;
            this.BtnEdit.BorderColor = System.Drawing.Color.Silver;
            this.BtnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEdit.Location = new System.Drawing.Point(23, 13);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnEdit.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.BtnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEdit.OnHoverImage = null;
            this.BtnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEdit.OnPressedDepth = 100;
            this.BtnEdit.Radius = 10;
            this.BtnEdit.Size = new System.Drawing.Size(51, 35);
            this.BtnEdit.TabIndex = 141;
            this.BtnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFermer.Animated = true;
            this.BtnFermer.AnimationHoverSpeed = 0.02F;
            this.BtnFermer.AnimationSpeed = 0.03F;
            this.BtnFermer.BackColor = System.Drawing.Color.Transparent;
            this.BtnFermer.BaseColor = System.Drawing.Color.White;
            this.BtnFermer.BorderColor = System.Drawing.Color.Silver;
            this.BtnFermer.FocusedColor = System.Drawing.Color.Empty;
            this.BtnFermer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.Color.Black;
            this.BtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.Image")));
            this.BtnFermer.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnFermer.Location = new System.Drawing.Point(1325, 3);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnFermer.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.BtnFermer.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnFermer.OnHoverImage = null;
            this.BtnFermer.OnPressedColor = System.Drawing.Color.Black;
            this.BtnFermer.OnPressedDepth = 100;
            this.BtnFermer.Radius = 10;
            this.BtnFermer.Size = new System.Drawing.Size(166, 35);
            this.BtnFermer.TabIndex = 140;
            this.BtnFermer.Text = "Retour";
            this.BtnFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click_1);
            // 
            // UserControlMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCenter);
            this.Name = "UserControlMedicament";
            this.Size = new System.Drawing.Size(1494, 776);
            this.panelCenter.ResumeLayout(false);
            this.panelCentre1.ResumeLayout(false);
            this.panelCentre1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelCentre1;
        private Guna.UI.WinForms.GunaButton BtnFermer;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox txtRecherche;
        private Guna.UI.WinForms.GunaButton BtnEdit;
        private Guna.UI.WinForms.GunaDataGridView DataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI.WinForms.GunaButton BtnAjoutMedocs;
    }
}
