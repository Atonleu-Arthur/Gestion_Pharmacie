namespace FormPharmacie
{
    partial class FormlistMedicament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormlistMedicament));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelRecherche = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnQuitter = new Guna.UI.WinForms.GunaButton();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.panelAjoutUtilisateru = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnActualiser = new Guna.UI.WinForms.GunaButton();
            this.ImporterListExcel = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 32);
            this.panel1.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 28);
            this.label2.TabIndex = 115;
            this.label2.Text = "Medicament enregistrés";
            // 
            // PanelRecherche
            // 
            this.PanelRecherche.BackColor = System.Drawing.Color.Transparent;
            this.PanelRecherche.BaseColor = System.Drawing.Color.White;
            this.PanelRecherche.BorderColor = System.Drawing.Color.Silver;
            this.PanelRecherche.BorderSize = 1;
            this.PanelRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelRecherche.FocusedBaseColor = System.Drawing.Color.White;
            this.PanelRecherche.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PanelRecherche.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelRecherche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PanelRecherche.Location = new System.Drawing.Point(428, 79);
            this.PanelRecherche.Name = "PanelRecherche";
            this.PanelRecherche.PasswordChar = '\0';
            this.PanelRecherche.Radius = 10;
            this.PanelRecherche.Size = new System.Drawing.Size(365, 32);
            this.PanelRecherche.TabIndex = 117;
            this.PanelRecherche.TextChanged += new System.EventHandler(this.PanelRecherche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "Rechercher";
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.AnimationHoverSpeed = 0.07F;
            this.BtnQuitter.AnimationSpeed = 0.03F;
            this.BtnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuitter.BaseColor = System.Drawing.Color.White;
            this.BtnQuitter.BorderColor = System.Drawing.Color.Silver;
            this.BtnQuitter.BorderSize = 1;
            this.BtnQuitter.FocusedColor = System.Drawing.Color.Empty;
            this.BtnQuitter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.Color.Black;
            this.BtnQuitter.Image = null;
            this.BtnQuitter.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnQuitter.Location = new System.Drawing.Point(1039, 719);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.OnHoverBaseColor = System.Drawing.Color.Red;
            this.BtnQuitter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnQuitter.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnQuitter.OnHoverImage = null;
            this.BtnQuitter.OnPressedColor = System.Drawing.Color.Black;
            this.BtnQuitter.Radius = 10;
            this.BtnQuitter.Size = new System.Drawing.Size(144, 34);
            this.BtnQuitter.TabIndex = 118;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnQuitter.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 15;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // panelAjoutUtilisateru
            // 
            this.panelAjoutUtilisateru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panelAjoutUtilisateru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAjoutUtilisateru.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAjoutUtilisateru.Location = new System.Drawing.Point(0, 32);
            this.panelAjoutUtilisateru.Margin = new System.Windows.Forms.Padding(4);
            this.panelAjoutUtilisateru.Name = "panelAjoutUtilisateru";
            this.panelAjoutUtilisateru.Size = new System.Drawing.Size(3, 733);
            this.panelAjoutUtilisateru.TabIndex = 123;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 761);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1197, 4);
            this.panel3.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1200, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 733);
            this.panel2.TabIndex = 125;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 29;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.DataGridView1.Location = new System.Drawing.Point(5, 153);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1190, 523);
            this.DataGridView1.TabIndex = 132;
            this.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_medicament";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nom_medicament";
            this.Column2.HeaderText = "Nom du medicament";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DCI";
            this.Column3.HeaderText = "Dci";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Dosage";
            this.Column4.HeaderText = "Dosage";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Forme";
            this.Column5.HeaderText = "Forme";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Conditionnement";
            this.Column6.HeaderText = "Conditionnement";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRechercher.AnimationHoverSpeed = 0.07F;
            this.BtnRechercher.AnimationSpeed = 0.03F;
            this.BtnRechercher.BackColor = System.Drawing.Color.Transparent;
            this.BtnRechercher.BaseColor = System.Drawing.Color.White;
            this.BtnRechercher.BorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.BorderSize = 1;
            this.BtnRechercher.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnRechercher.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.CheckedForeColor = System.Drawing.Color.White;
            this.BtnRechercher.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnRechercher.CheckedImage")));
            this.BtnRechercher.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnRechercher.FocusedColor = System.Drawing.Color.Empty;
            this.BtnRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRechercher.ForeColor = System.Drawing.Color.Black;
            this.BtnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("BtnRechercher.Image")));
            this.BtnRechercher.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnRechercher.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.Location = new System.Drawing.Point(832, 75);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRechercher.OnHoverImage = null;
            this.BtnRechercher.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRechercher.Radius = 10;
            this.BtnRechercher.Size = new System.Drawing.Size(203, 30);
            this.BtnRechercher.TabIndex = 131;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnActualiser.AnimationHoverSpeed = 0.07F;
            this.BtnActualiser.AnimationSpeed = 0.03F;
            this.BtnActualiser.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.BaseColor = System.Drawing.Color.White;
            this.BtnActualiser.BorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.BorderSize = 1;
            this.BtnActualiser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnActualiser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActualiser.ForeColor = System.Drawing.Color.Black;
            this.BtnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualiser.Image")));
            this.BtnActualiser.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnActualiser.Location = new System.Drawing.Point(41, 721);
            this.BtnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.OnHoverBaseColor = System.Drawing.Color.MintCream;
            this.BtnActualiser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualiser.OnHoverImage = null;
            this.BtnActualiser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualiser.Radius = 10;
            this.BtnActualiser.Size = new System.Drawing.Size(133, 32);
            this.BtnActualiser.TabIndex = 121;
            this.BtnActualiser.Text = "Actualiser";
            this.BtnActualiser.Click += new System.EventHandler(this.Btnsupprimer_Click);
            // 
            // ImporterListExcel
            // 
            this.ImporterListExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImporterListExcel.AnimationHoverSpeed = 0.07F;
            this.ImporterListExcel.AnimationSpeed = 0.03F;
            this.ImporterListExcel.BackColor = System.Drawing.Color.Transparent;
            this.ImporterListExcel.BaseColor = System.Drawing.Color.White;
            this.ImporterListExcel.BorderColor = System.Drawing.Color.Silver;
            this.ImporterListExcel.BorderSize = 1;
            this.ImporterListExcel.FocusedColor = System.Drawing.Color.Empty;
            this.ImporterListExcel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporterListExcel.ForeColor = System.Drawing.Color.DimGray;
            this.ImporterListExcel.Image = ((System.Drawing.Image)(resources.GetObject("ImporterListExcel.Image")));
            this.ImporterListExcel.ImageSize = new System.Drawing.Size(22, 22);
            this.ImporterListExcel.Location = new System.Drawing.Point(413, 719);
            this.ImporterListExcel.Name = "ImporterListExcel";
            this.ImporterListExcel.OnHoverBaseColor = System.Drawing.Color.LimeGreen;
            this.ImporterListExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ImporterListExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.ImporterListExcel.OnHoverImage = null;
            this.ImporterListExcel.OnPressedColor = System.Drawing.Color.Black;
            this.ImporterListExcel.Radius = 7;
            this.ImporterListExcel.Size = new System.Drawing.Size(378, 34);
            this.ImporterListExcel.TabIndex = 119;
            this.ImporterListExcel.Text = "Importer la liste de medicaments";
            this.ImporterListExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImporterListExcel.Click += new System.EventHandler(this.ImporterListExcel_Click);
            // 
            // FormlistMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 765);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAjoutUtilisateru);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.ImporterListExcel);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.PanelRecherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormlistMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormlistMedicament";
            this.Load += new System.EventHandler(this.FormlistMedicament_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox PanelRecherche;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton BtnQuitter;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private Guna.UI.WinForms.GunaButton ImporterListExcel;
        private Guna.UI.WinForms.GunaButton BtnActualiser;
        private System.Windows.Forms.Panel panelAjoutUtilisateru;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaDataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}