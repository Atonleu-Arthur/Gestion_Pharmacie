namespace FormPharmacie.UserControls
{
    partial class UserControlPamRayon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPamRayon));
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEnregistrer1 = new Guna.UI.WinForms.GunaButton();
            this.txtQuafRayon = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboxGroupe = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCentre1 = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnFermer = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.panelCentre1.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Groupe";
            this.Column2.HeaderText = "Groupe lié";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 700;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 29;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DataGridView1.Location = new System.Drawing.Point(3, 484);
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
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.ShowCellErrors = false;
            this.DataGridView1.Size = new System.Drawing.Size(1203, 285);
            this.DataGridView1.TabIndex = 148;
            this.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Nom_rayon";
            this.Column1.HeaderText = "Qualification du rayon";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 500;
            // 
            // BtnEnregistrer1
            // 
            this.BtnEnregistrer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEnregistrer1.Animated = true;
            this.BtnEnregistrer1.AnimationHoverSpeed = 0.02F;
            this.BtnEnregistrer1.AnimationSpeed = 0.03F;
            this.BtnEnregistrer1.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnregistrer1.BaseColor = System.Drawing.Color.White;
            this.BtnEnregistrer1.BorderColor = System.Drawing.Color.Silver;
            this.BtnEnregistrer1.BorderSize = 1;
            this.BtnEnregistrer1.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEnregistrer1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer1.ForeColor = System.Drawing.Color.Black;
            this.BtnEnregistrer1.Image = null;
            this.BtnEnregistrer1.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEnregistrer1.Location = new System.Drawing.Point(356, 786);
            this.BtnEnregistrer1.Name = "BtnEnregistrer1";
            this.BtnEnregistrer1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnEnregistrer1.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEnregistrer1.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer1.OnHoverImage = null;
            this.BtnEnregistrer1.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEnregistrer1.OnPressedDepth = 100;
            this.BtnEnregistrer1.Radius = 20;
            this.BtnEnregistrer1.Size = new System.Drawing.Size(434, 52);
            this.BtnEnregistrer1.TabIndex = 109;
            this.BtnEnregistrer1.Text = "Enregistrer";
            this.BtnEnregistrer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEnregistrer1.Click += new System.EventHandler(this.BtnEnregistrer1_Click_1);
            // 
            // txtQuafRayon
            // 
            this.txtQuafRayon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuafRayon.BackColor = System.Drawing.Color.Transparent;
            this.txtQuafRayon.BaseColor = System.Drawing.Color.White;
            this.txtQuafRayon.BorderColor = System.Drawing.Color.Silver;
            this.txtQuafRayon.BorderSize = 1;
            this.txtQuafRayon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuafRayon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuafRayon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuafRayon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuafRayon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuafRayon.ForeColor = System.Drawing.Color.Black;
            this.txtQuafRayon.Location = new System.Drawing.Point(73, 389);
            this.txtQuafRayon.Name = "txtQuafRayon";
            this.txtQuafRayon.PasswordChar = '\0';
            this.txtQuafRayon.Radius = 15;
            this.txtQuafRayon.Size = new System.Drawing.Size(358, 42);
            this.txtQuafRayon.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "Qualification du rayon *";
            // 
            // comboxGroupe
            // 
            this.comboxGroupe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboxGroupe.BackColor = System.Drawing.Color.Transparent;
            this.comboxGroupe.BaseColor = System.Drawing.Color.White;
            this.comboxGroupe.BorderColor = System.Drawing.Color.Silver;
            this.comboxGroupe.BorderSize = 1;
            this.comboxGroupe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxGroupe.FocusedColor = System.Drawing.Color.Empty;
            this.comboxGroupe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboxGroupe.ForeColor = System.Drawing.Color.Black;
            this.comboxGroupe.FormattingEnabled = true;
            this.comboxGroupe.Location = new System.Drawing.Point(736, 387);
            this.comboxGroupe.MaxDropDownItems = 100;
            this.comboxGroupe.Name = "comboxGroupe";
            this.comboxGroupe.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboxGroupe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboxGroupe.Radius = 15;
            this.comboxGroupe.Size = new System.Drawing.Size(379, 31);
            this.comboxGroupe.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(733, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Choix du Groupe *";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(233, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(763, 64);
            this.label15.TabIndex = 112;
            this.label15.Text = "Proceder a la configuration du rayonnage de votre pharmacie";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel1.Controls.Add(this.BtnFermer);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Controls.Add(this.label9);
            this.gunaElipsePanel1.Controls.Add(this.label8);
            this.gunaElipsePanel1.Controls.Add(this.label15);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1206, 301);
            this.gunaElipsePanel1.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(330, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(526, 40);
            this.label9.TabIndex = 114;
            this.label9.Text = "Grace a cette classification , Global Pharma vous aidera a localiser \r\nrapidement" +
    " vos médicaments lors de la vente";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(290, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(592, 20);
            this.label8.TabIndex = 113;
            this.label8.Text = "Pourquoi proceder a une classification des rayons de stockages ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(436, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Entrer les informations suivantes";
            // 
            // panelCentre1
            // 
            this.panelCentre1.Controls.Add(this.DataGridView1);
            this.panelCentre1.Controls.Add(this.pictureBox2);
            this.panelCentre1.Controls.Add(this.gunaElipsePanel1);
            this.panelCentre1.Controls.Add(this.BtnEnregistrer1);
            this.panelCentre1.Controls.Add(this.txtQuafRayon);
            this.panelCentre1.Controls.Add(this.label4);
            this.panelCentre1.Controls.Add(this.comboxGroupe);
            this.panelCentre1.Controls.Add(this.label3);
            this.panelCentre1.Controls.Add(this.label1);
            this.panelCentre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre1.Location = new System.Drawing.Point(0, 0);
            this.panelCentre1.Name = "panelCentre1";
            this.panelCentre1.Size = new System.Drawing.Size(1206, 850);
            this.panelCentre1.TabIndex = 0;
            this.panelCentre1.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentre1_Paint);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelCentre1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1206, 850);
            this.panelCenter.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(520, 389);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // BtnFermer
            // 
            this.BtnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFermer.Animated = true;
            this.BtnFermer.AnimationHoverSpeed = 0.02F;
            this.BtnFermer.AnimationSpeed = 0.03F;
            this.BtnFermer.BackColor = System.Drawing.Color.Transparent;
            this.BtnFermer.BaseColor = System.Drawing.Color.Transparent;
            this.BtnFermer.BorderColor = System.Drawing.Color.Silver;
            this.BtnFermer.FocusedColor = System.Drawing.Color.Empty;
            this.BtnFermer.Font = new System.Drawing.Font("Georgia", 11F);
            this.BtnFermer.ForeColor = System.Drawing.Color.Black;
            this.BtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.Image")));
            this.BtnFermer.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnFermer.Location = new System.Drawing.Point(1059, 3);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnFermer.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.BtnFermer.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnFermer.OnHoverImage = null;
            this.BtnFermer.OnPressedColor = System.Drawing.Color.Black;
            this.BtnFermer.OnPressedDepth = 100;
            this.BtnFermer.Radius = 10;
            this.BtnFermer.Size = new System.Drawing.Size(144, 36);
            this.BtnFermer.TabIndex = 236;
            this.BtnFermer.Text = "Retour";
            this.BtnFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlPamRayon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCenter);
            this.Name = "UserControlPamRayon";
            this.Size = new System.Drawing.Size(1206, 850);
            this.Load += new System.EventHandler(this.UserControlPamRayon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.panelCentre1.ResumeLayout(false);
            this.panelCentre1.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI.WinForms.GunaDataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton BtnEnregistrer1;
        private Guna.UI.WinForms.GunaTextBox txtQuafRayon;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox comboxGroupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton BtnFermer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCentre1;
        private System.Windows.Forms.Panel panelCenter;
    }
}
