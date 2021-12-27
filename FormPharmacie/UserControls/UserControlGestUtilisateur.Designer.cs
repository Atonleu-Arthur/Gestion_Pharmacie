namespace FormPharmacie.UserControls
{
    partial class UserControlGestUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGestUtilisateur));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelCentre1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboRole = new Guna.UI.WinForms.GunaComboBox();
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TxtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.BtnDroitUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnAjoutUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSupprimerUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnModifierUtilisateur = new Guna.UI.WinForms.GunaButton();
            this.BtnActualiser = new Guna.UI.WinForms.GunaButton();
            this.BtnFermer = new Guna.UI.WinForms.GunaButton();
            this.panelCenter.SuspendLayout();
            this.panelCentre1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelCentre1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1397, 796);
            this.panelCenter.TabIndex = 0;
            // 
            // panelCentre1
            // 
            this.panelCentre1.Controls.Add(this.BtnFermer);
            this.panelCentre1.Controls.Add(this.listView1);
            this.panelCentre1.Controls.Add(this.ComboRole);
            this.panelCentre1.Controls.Add(this.BtnRechercher);
            this.panelCentre1.Controls.Add(this.TxtRechercher);
            this.panelCentre1.Controls.Add(this.lblRechercher);
            this.panelCentre1.Controls.Add(this.BtnDroitUtilisateur);
            this.panelCentre1.Controls.Add(this.BtnAjoutUtilisateur);
            this.panelCentre1.Controls.Add(this.BtnSupprimerUtilisateur);
            this.panelCentre1.Controls.Add(this.BtnModifierUtilisateur);
            this.panelCentre1.Controls.Add(this.BtnActualiser);
            this.panelCentre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre1.Location = new System.Drawing.Point(0, 0);
            this.panelCentre1.Name = "panelCentre1";
            this.panelCentre1.Size = new System.Drawing.Size(1397, 796);
            this.panelCentre1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 199);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(1396, 510);
            this.listView1.TabIndex = 103;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "COMPTE";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOM ";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ROLE";
            this.columnHeader3.Width = 209;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DERNIERE CONNEXION";
            this.columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TELEPHONE";
            this.columnHeader6.Width = 234;
            // 
            // ComboRole
            // 
            this.ComboRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.ComboRole.Location = new System.Drawing.Point(721, 38);
            this.ComboRole.Margin = new System.Windows.Forms.Padding(4);
            this.ComboRole.Name = "ComboRole";
            this.ComboRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboRole.Radius = 10;
            this.ComboRole.Size = new System.Drawing.Size(212, 31);
            this.ComboRole.TabIndex = 112;
            this.ComboRole.SelectedIndexChanged += new System.EventHandler(this.ComboRole_SelectedIndexChanged);
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
            this.BtnRechercher.Location = new System.Drawing.Point(953, 34);
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
            this.BtnRechercher.TabIndex = 111;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // TxtRechercher
            // 
            this.TxtRechercher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtRechercher.BackColor = System.Drawing.Color.Transparent;
            this.TxtRechercher.BaseColor = System.Drawing.Color.White;
            this.TxtRechercher.BorderColor = System.Drawing.Color.Silver;
            this.TxtRechercher.BorderSize = 1;
            this.TxtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRechercher.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtRechercher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtRechercher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRechercher.Location = new System.Drawing.Point(351, 34);
            this.TxtRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRechercher.Name = "TxtRechercher";
            this.TxtRechercher.PasswordChar = '\0';
            this.TxtRechercher.Radius = 10;
            this.TxtRechercher.Size = new System.Drawing.Size(349, 37);
            this.TxtRechercher.TabIndex = 110;
            // 
            // lblRechercher
            // 
            this.lblRechercher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(220, 46);
            this.lblRechercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(101, 23);
            this.lblRechercher.TabIndex = 109;
            this.lblRechercher.Text = "Rechercher";
            // 
            // BtnDroitUtilisateur
            // 
            this.BtnDroitUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnDroitUtilisateur.Location = new System.Drawing.Point(987, 139);
            this.BtnDroitUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDroitUtilisateur.Name = "BtnDroitUtilisateur";
            this.BtnDroitUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnDroitUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDroitUtilisateur.OnHoverImage = null;
            this.BtnDroitUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnDroitUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDroitUtilisateur.Radius = 10;
            this.BtnDroitUtilisateur.Size = new System.Drawing.Size(203, 38);
            this.BtnDroitUtilisateur.TabIndex = 108;
            this.BtnDroitUtilisateur.Text = "Gérer les droits";
            this.BtnDroitUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAjoutUtilisateur
            // 
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
            this.BtnAjoutUtilisateur.Location = new System.Drawing.Point(14, 139);
            this.BtnAjoutUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjoutUtilisateur.Name = "BtnAjoutUtilisateur";
            this.BtnAjoutUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnAjoutUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAjoutUtilisateur.OnHoverImage = null;
            this.BtnAjoutUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.Radius = 10;
            this.BtnAjoutUtilisateur.Size = new System.Drawing.Size(204, 38);
            this.BtnAjoutUtilisateur.TabIndex = 107;
            this.BtnAjoutUtilisateur.Text = "Ajouter un Utilisateur";
            this.BtnAjoutUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAjoutUtilisateur.Click += new System.EventHandler(this.BtnAjoutUtilisateur_Click);
            // 
            // BtnSupprimerUtilisateur
            // 
            this.BtnSupprimerUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnSupprimerUtilisateur.Location = new System.Drawing.Point(1220, 139);
            this.BtnSupprimerUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupprimerUtilisateur.Name = "BtnSupprimerUtilisateur";
            this.BtnSupprimerUtilisateur.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.BtnSupprimerUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.OnHoverImage = null;
            this.BtnSupprimerUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupprimerUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.Radius = 10;
            this.BtnSupprimerUtilisateur.Size = new System.Drawing.Size(173, 38);
            this.BtnSupprimerUtilisateur.TabIndex = 106;
            this.BtnSupprimerUtilisateur.Text = "Supprimer";
            this.BtnSupprimerUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSupprimerUtilisateur.Click += new System.EventHandler(this.BtnSupprimerUtilisateur_Click);
            // 
            // BtnModifierUtilisateur
            // 
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
            this.BtnModifierUtilisateur.Location = new System.Drawing.Point(244, 139);
            this.BtnModifierUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifierUtilisateur.Name = "BtnModifierUtilisateur";
            this.BtnModifierUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnModifierUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnModifierUtilisateur.OnHoverImage = null;
            this.BtnModifierUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.Radius = 10;
            this.BtnModifierUtilisateur.Size = new System.Drawing.Size(217, 37);
            this.BtnModifierUtilisateur.TabIndex = 105;
            this.BtnModifierUtilisateur.Text = "Modifier un utilisateur";
            this.BtnModifierUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnModifierUtilisateur.Click += new System.EventHandler(this.BtnModifierUtilisateur_Click);
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualiser.AnimationHoverSpeed = 0.07F;
            this.BtnActualiser.AnimationSpeed = 0.03F;
            this.BtnActualiser.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.BaseColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.BorderColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnActualiser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActualiser.ForeColor = System.Drawing.Color.Black;
            this.BtnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualiser.Image")));
            this.BtnActualiser.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnActualiser.Location = new System.Drawing.Point(1233, 736);
            this.BtnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualiser.OnHoverImage = null;
            this.BtnActualiser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualiser.Radius = 10;
            this.BtnActualiser.Size = new System.Drawing.Size(155, 27);
            this.BtnActualiser.TabIndex = 104;
            this.BtnActualiser.Text = "Actualiser";
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click_1);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnFermer.Animated = true;
            this.BtnFermer.AnimationHoverSpeed = 0.02F;
            this.BtnFermer.AnimationSpeed = 0.03F;
            this.BtnFermer.BackColor = System.Drawing.Color.Transparent;
            this.BtnFermer.BaseColor = System.Drawing.Color.White;
            this.BtnFermer.BorderColor = System.Drawing.Color.Silver;
            this.BtnFermer.BorderSize = 1;
            this.BtnFermer.FocusedColor = System.Drawing.Color.Empty;
            this.BtnFermer.Font = new System.Drawing.Font("Georgia", 11F);
            this.BtnFermer.ForeColor = System.Drawing.Color.Black;
            this.BtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.Image")));
            this.BtnFermer.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnFermer.Location = new System.Drawing.Point(1260, 5);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnFermer.OnHoverBorderColor = System.Drawing.Color.DimGray;
            this.BtnFermer.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnFermer.OnHoverImage = null;
            this.BtnFermer.OnPressedColor = System.Drawing.Color.Black;
            this.BtnFermer.OnPressedDepth = 100;
            this.BtnFermer.Radius = 10;
            this.BtnFermer.Size = new System.Drawing.Size(128, 36);
            this.BtnFermer.TabIndex = 196;
            this.BtnFermer.Text = "Retour";
            this.BtnFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // UserControlGestUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCenter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlGestUtilisateur";
            this.Size = new System.Drawing.Size(1397, 796);
            this.Load += new System.EventHandler(this.UserControlGestUtilisateur_Load);
            this.panelCenter.ResumeLayout(false);
            this.panelCentre1.ResumeLayout(false);
            this.panelCentre1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelCentre1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Guna.UI.WinForms.GunaComboBox ComboRole;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaTextBox TxtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDroitUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAjoutUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupprimerUtilisateur;
        private Guna.UI.WinForms.GunaButton BtnModifierUtilisateur;
        private Guna.UI.WinForms.GunaButton BtnActualiser;
        private Guna.UI.WinForms.GunaButton BtnFermer;
    }
}
