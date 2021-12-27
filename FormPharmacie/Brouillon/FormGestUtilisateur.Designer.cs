namespace FormPharmacie
{
    partial class FormGestUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestUtilisateur));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDroitUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnAjoutUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSupprimerUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnModifierUtilisateur = new Guna.UI.WinForms.GunaButton();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.BtnAccueil = new Guna.UI.WinForms.GunaButton();
            this.BtnActualiser = new Guna.UI.WinForms.GunaButton();
            this.TxtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ComboRole = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.Telephone,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(1, 229);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1425, 507);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "COMPTE";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOM ";
            this.columnHeader2.Width = 197;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ROLE";
            this.columnHeader3.Width = 199;
            // 
            // Telephone
            // 
            this.Telephone.Text = "TELEPHONE";
            this.Telephone.Width = 255;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DERNIERE CONNEXION";
            this.columnHeader5.Width = 221;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion des utilisateurs";
            // 
            // BtnDroitUtilisateur
            // 
            this.BtnDroitUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDroitUtilisateur.AnimationHoverSpeed = 0.07F;
            this.BtnDroitUtilisateur.AnimationSpeed = 0.03F;
            this.BtnDroitUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.BtnDroitUtilisateur.BaseColor = System.Drawing.Color.White;
            this.BtnDroitUtilisateur.BorderColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.BorderSize = 1;
            this.BtnDroitUtilisateur.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnDroitUtilisateur.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.CheckedForeColor = System.Drawing.Color.White;
            this.BtnDroitUtilisateur.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnDroitUtilisateur.CheckedImage")));
            this.BtnDroitUtilisateur.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnDroitUtilisateur.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDroitUtilisateur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDroitUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnDroitUtilisateur.Image")));
            this.BtnDroitUtilisateur.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDroitUtilisateur.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnDroitUtilisateur.Location = new System.Drawing.Point(1036, 97);
            this.BtnDroitUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDroitUtilisateur.Name = "BtnDroitUtilisateur";
            this.BtnDroitUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnDroitUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDroitUtilisateur.OnHoverImage = null;
            this.BtnDroitUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnDroitUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.Radius = 10;
            this.BtnDroitUtilisateur.Size = new System.Drawing.Size(184, 38);
            this.BtnDroitUtilisateur.TabIndex = 13;
            this.BtnDroitUtilisateur.Text = "Gérer les droits";
            this.BtnDroitUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAjoutUtilisateur
            // 
            this.BtnAjoutUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAjoutUtilisateur.AnimationHoverSpeed = 0.07F;
            this.BtnAjoutUtilisateur.AnimationSpeed = 0.03F;
            this.BtnAjoutUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjoutUtilisateur.BaseColor = System.Drawing.Color.White;
            this.BtnAjoutUtilisateur.BorderColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.BorderSize = 1;
            this.BtnAjoutUtilisateur.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnAjoutUtilisateur.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.CheckedForeColor = System.Drawing.Color.White;
            this.BtnAjoutUtilisateur.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnAjoutUtilisateur.CheckedImage")));
            this.BtnAjoutUtilisateur.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnAjoutUtilisateur.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAjoutUtilisateur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjoutUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjoutUtilisateur.Image")));
            this.BtnAjoutUtilisateur.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAjoutUtilisateur.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutUtilisateur.Location = new System.Drawing.Point(0, 98);
            this.BtnAjoutUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjoutUtilisateur.Name = "BtnAjoutUtilisateur";
            this.BtnAjoutUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnAjoutUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAjoutUtilisateur.OnHoverImage = null;
            this.BtnAjoutUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.Radius = 10;
            this.BtnAjoutUtilisateur.Size = new System.Drawing.Size(203, 37);
            this.BtnAjoutUtilisateur.TabIndex = 12;
            this.BtnAjoutUtilisateur.Text = "Ajouter un Utilisateur";
            this.BtnAjoutUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAjoutUtilisateur.Click += new System.EventHandler(this.BtnAjoutUtilisateur_Click);
            // 
            // BtnSupprimerUtilisateur
            // 
            this.BtnSupprimerUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSupprimerUtilisateur.AnimationHoverSpeed = 0.07F;
            this.BtnSupprimerUtilisateur.AnimationSpeed = 0.03F;
            this.BtnSupprimerUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.BtnSupprimerUtilisateur.BaseColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.BorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.BorderSize = 1;
            this.BtnSupprimerUtilisateur.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSupprimerUtilisateur.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSupprimerUtilisateur.CheckedImage")));
            this.BtnSupprimerUtilisateur.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSupprimerUtilisateur.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSupprimerUtilisateur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSupprimerUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimerUtilisateur.Image")));
            this.BtnSupprimerUtilisateur.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSupprimerUtilisateur.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupprimerUtilisateur.Location = new System.Drawing.Point(1260, 97);
            this.BtnSupprimerUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupprimerUtilisateur.Name = "BtnSupprimerUtilisateur";
            this.BtnSupprimerUtilisateur.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.BtnSupprimerUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.OnHoverImage = null;
            this.BtnSupprimerUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupprimerUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.Radius = 10;
            this.BtnSupprimerUtilisateur.Size = new System.Drawing.Size(168, 38);
            this.BtnSupprimerUtilisateur.TabIndex = 11;
            this.BtnSupprimerUtilisateur.Text = "Supprimer";
            this.BtnSupprimerUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnSupprimerUtilisateur.Click += new System.EventHandler(this.BtnSupprimerUtilisateur_Click);
            // 
            // BtnModifierUtilisateur
            // 
            this.BtnModifierUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModifierUtilisateur.AnimationHoverSpeed = 0.07F;
            this.BtnModifierUtilisateur.AnimationSpeed = 0.03F;
            this.BtnModifierUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.BtnModifierUtilisateur.BaseColor = System.Drawing.Color.White;
            this.BtnModifierUtilisateur.BorderColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.BorderSize = 1;
            this.BtnModifierUtilisateur.FocusedColor = System.Drawing.Color.Empty;
            this.BtnModifierUtilisateur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnModifierUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifierUtilisateur.Image")));
            this.BtnModifierUtilisateur.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnModifierUtilisateur.Location = new System.Drawing.Point(231, 98);
            this.BtnModifierUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifierUtilisateur.Name = "BtnModifierUtilisateur";
            this.BtnModifierUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnModifierUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnModifierUtilisateur.OnHoverImage = null;
            this.BtnModifierUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.Radius = 10;
            this.BtnModifierUtilisateur.Size = new System.Drawing.Size(217, 37);
            this.BtnModifierUtilisateur.TabIndex = 10;
            this.BtnModifierUtilisateur.Text = "Modifier un utilisateur";
            this.BtnModifierUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnModifierUtilisateur.Click += new System.EventHandler(this.BtnModifierUtilisateur_Click);
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 20;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // BtnAccueil
            // 
            this.BtnAccueil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAccueil.AnimationHoverSpeed = 0.07F;
            this.BtnAccueil.AnimationSpeed = 0.03F;
            this.BtnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.BtnAccueil.BaseColor = System.Drawing.Color.White;
            this.BtnAccueil.BorderColor = System.Drawing.Color.Black;
            this.BtnAccueil.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAccueil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAccueil.ForeColor = System.Drawing.Color.Black;
            this.BtnAccueil.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccueil.Image")));
            this.BtnAccueil.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAccueil.Location = new System.Drawing.Point(1235, 42);
            this.BtnAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAccueil.Name = "BtnAccueil";
            this.BtnAccueil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnAccueil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAccueil.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAccueil.OnHoverImage = null;
            this.BtnAccueil.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAccueil.Radius = 10;
            this.BtnAccueil.Size = new System.Drawing.Size(124, 37);
            this.BtnAccueil.TabIndex = 15;
            this.BtnAccueil.Text = "Accueil";
            this.BtnAccueil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnActualiser.AnimationHoverSpeed = 0.07F;
            this.BtnActualiser.AnimationSpeed = 0.03F;
            this.BtnActualiser.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.BaseColor = System.Drawing.Color.White;
            this.BtnActualiser.BorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnActualiser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActualiser.ForeColor = System.Drawing.Color.Black;
            this.BtnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualiser.Image")));
            this.BtnActualiser.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnActualiser.Location = new System.Drawing.Point(1288, 745);
            this.BtnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnActualiser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualiser.OnHoverImage = null;
            this.BtnActualiser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualiser.Radius = 10;
            this.BtnActualiser.Size = new System.Drawing.Size(140, 37);
            this.BtnActualiser.TabIndex = 17;
            this.BtnActualiser.Text = "Actualiser";
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // TxtRechercher
            // 
            this.TxtRechercher.BackColor = System.Drawing.Color.Transparent;
            this.TxtRechercher.BaseColor = System.Drawing.Color.White;
            this.TxtRechercher.BorderColor = System.Drawing.Color.Silver;
            this.TxtRechercher.BorderSize = 1;
            this.TxtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRechercher.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtRechercher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtRechercher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRechercher.Location = new System.Drawing.Point(449, 161);
            this.TxtRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRechercher.Name = "TxtRechercher";
            this.TxtRechercher.PasswordChar = '\0';
            this.TxtRechercher.Radius = 10;
            this.TxtRechercher.Size = new System.Drawing.Size(349, 37);
            this.TxtRechercher.TabIndex = 72;
            // 
            // lblRechercher
            // 
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(337, 164);
            this.lblRechercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(101, 23);
            this.lblRechercher.TabIndex = 71;
            this.lblRechercher.Text = "Rechercher";
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnRechercher.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnRechercher.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.Location = new System.Drawing.Point(1036, 161);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRechercher.OnHoverImage = null;
            this.BtnRechercher.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRechercher.Radius = 10;
            this.BtnRechercher.Size = new System.Drawing.Size(184, 38);
            this.BtnRechercher.TabIndex = 73;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // ComboRole
            // 
            this.ComboRole.BackColor = System.Drawing.Color.Transparent;
            this.ComboRole.BaseColor = System.Drawing.Color.White;
            this.ComboRole.BorderColor = System.Drawing.Color.Silver;
            this.ComboRole.BorderSize = 1;
            this.ComboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRole.FocusedColor = System.Drawing.Color.Empty;
            this.ComboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboRole.ForeColor = System.Drawing.Color.Black;
            this.ComboRole.FormattingEnabled = true;
            this.ComboRole.Location = new System.Drawing.Point(833, 164);
            this.ComboRole.Margin = new System.Windows.Forms.Padding(4);
            this.ComboRole.Name = "ComboRole";
            this.ComboRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboRole.Radius = 10;
            this.ComboRole.Size = new System.Drawing.Size(212, 31);
            this.ComboRole.TabIndex = 88;
            // 
            // FormGestUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 811);
            this.Controls.Add(this.ComboRole);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.TxtRechercher);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.BtnAccueil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDroitUtilisateur);
            this.Controls.Add(this.BtnAjoutUtilisateur);
            this.Controls.Add(this.BtnSupprimerUtilisateur);
            this.Controls.Add(this.BtnModifierUtilisateur);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestUtilisateur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestUtilisateur_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGestUtilisateur_FormClosed);
            this.Load += new System.EventHandler(this.FormGestUtilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDroitUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAjoutUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupprimerUtilisateur;
        private Guna.UI.WinForms.GunaButton BtnModifierUtilisateur;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private Guna.UI.WinForms.GunaButton BtnAccueil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Telephone;
        private Guna.UI.WinForms.GunaButton BtnActualiser;
        private Guna.UI.WinForms.GunaTextBox TxtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaComboBox ComboRole;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView listView1;
    }
}