namespace FormPharmacie.UserControls
{
    partial class UserControlFichiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFichiers));
            this.tabClient = new System.Windows.Forms.TabControl();
            this.tabFournisseur = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabdepense = new System.Windows.Forms.TabPage();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnActualiser = new Guna.UI.WinForms.GunaButton();
            this.BtnAjoutNomF = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSupprimerUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnModifierUtilisateur = new Guna.UI.WinForms.GunaButton();
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TxtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tabClient.SuspendLayout();
            this.tabFournisseur.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.tabFournisseur);
            this.tabClient.Controls.Add(this.tabPage2);
            this.tabClient.Controls.Add(this.tabdepense);
            this.tabClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClient.Location = new System.Drawing.Point(0, 0);
            this.tabClient.Name = "tabClient";
            this.tabClient.SelectedIndex = 0;
            this.tabClient.Size = new System.Drawing.Size(1460, 882);
            this.tabClient.TabIndex = 0;
            // 
            // tabFournisseur
            // 
            this.tabFournisseur.BackColor = System.Drawing.Color.White;
            this.tabFournisseur.Controls.Add(this.gunaAdvenceButton1);
            this.tabFournisseur.Controls.Add(this.BtnActualiser);
            this.tabFournisseur.Controls.Add(this.BtnAjoutNomF);
            this.tabFournisseur.Controls.Add(this.BtnSupprimerUtilisateur);
            this.tabFournisseur.Controls.Add(this.BtnModifierUtilisateur);
            this.tabFournisseur.Controls.Add(this.BtnRechercher);
            this.tabFournisseur.Controls.Add(this.TxtRechercher);
            this.tabFournisseur.Controls.Add(this.lblRechercher);
            this.tabFournisseur.Controls.Add(this.listView1);
            this.tabFournisseur.Controls.Add(this.label1);
            this.tabFournisseur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFournisseur.Location = new System.Drawing.Point(4, 37);
            this.tabFournisseur.Name = "tabFournisseur";
            this.tabFournisseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabFournisseur.Size = new System.Drawing.Size(1452, 841);
            this.tabFournisseur.TabIndex = 0;
            this.tabFournisseur.Text = "Fournisseurs";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.gunaButton1);
            this.tabPage2.Controls.Add(this.gunaAdvenceButton2);
            this.tabPage2.Controls.Add(this.gunaButton2);
            this.tabPage2.Controls.Add(this.gunaAdvenceButton3);
            this.tabPage2.Controls.Add(this.gunaTextBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1452, 841);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            // 
            // tabdepense
            // 
            this.tabdepense.Location = new System.Drawing.Point(4, 37);
            this.tabdepense.Name = "tabdepense";
            this.tabdepense.Padding = new System.Windows.Forms.Padding(3);
            this.tabdepense.Size = new System.Drawing.Size(1360, 787);
            this.tabdepense.TabIndex = 2;
            this.tabdepense.Text = "Depenses";
            this.tabdepense.UseVisualStyleBackColor = true;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(1105, 740);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 5;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(287, 38);
            this.gunaAdvenceButton1.TabIndex = 127;
            this.gunaAdvenceButton1.Text = "Imprimer la liste";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnActualiser.Location = new System.Drawing.Point(1332, 130);
            this.BtnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualiser.OnHoverImage = null;
            this.BtnActualiser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualiser.Radius = 10;
            this.BtnActualiser.Size = new System.Drawing.Size(56, 34);
            this.BtnActualiser.TabIndex = 126;
            // 
            // BtnAjoutNomF
            // 
            this.BtnAjoutNomF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAjoutNomF.AnimationHoverSpeed = 0.07F;
            this.BtnAjoutNomF.AnimationSpeed = 0.03F;
            this.BtnAjoutNomF.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjoutNomF.BaseColor = System.Drawing.Color.White;
            this.BtnAjoutNomF.BorderColor = System.Drawing.Color.Black;
            this.BtnAjoutNomF.BorderSize = 1;
            this.BtnAjoutNomF.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnAjoutNomF.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutNomF.CheckedForeColor = System.Drawing.Color.White;
            this.BtnAjoutNomF.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnAjoutNomF.CheckedImage")));
            this.BtnAjoutNomF.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnAjoutNomF.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAjoutNomF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjoutNomF.ForeColor = System.Drawing.Color.Black;
            this.BtnAjoutNomF.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjoutNomF.Image")));
            this.BtnAjoutNomF.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAjoutNomF.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutNomF.Location = new System.Drawing.Point(706, 740);
            this.BtnAjoutNomF.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjoutNomF.Name = "BtnAjoutNomF";
            this.BtnAjoutNomF.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnAjoutNomF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutNomF.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAjoutNomF.OnHoverImage = null;
            this.BtnAjoutNomF.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutNomF.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutNomF.Radius = 5;
            this.BtnAjoutNomF.Size = new System.Drawing.Size(300, 38);
            this.BtnAjoutNomF.TabIndex = 125;
            this.BtnAjoutNomF.Text = "Enregistrer un fournisseur";
            this.BtnAjoutNomF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnSupprimerUtilisateur.Location = new System.Drawing.Point(365, 740);
            this.BtnSupprimerUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupprimerUtilisateur.Name = "BtnSupprimerUtilisateur";
            this.BtnSupprimerUtilisateur.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.BtnSupprimerUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.OnHoverImage = null;
            this.BtnSupprimerUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupprimerUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.Radius = 5;
            this.BtnSupprimerUtilisateur.Size = new System.Drawing.Size(256, 38);
            this.BtnSupprimerUtilisateur.TabIndex = 124;
            this.BtnSupprimerUtilisateur.Text = "Supprimer";
            this.BtnSupprimerUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnModifierUtilisateur.Location = new System.Drawing.Point(65, 740);
            this.BtnModifierUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifierUtilisateur.Name = "BtnModifierUtilisateur";
            this.BtnModifierUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnModifierUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnModifierUtilisateur.OnHoverImage = null;
            this.BtnModifierUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.Radius = 5;
            this.BtnModifierUtilisateur.Size = new System.Drawing.Size(261, 38);
            this.BtnModifierUtilisateur.TabIndex = 123;
            this.BtnModifierUtilisateur.Text = "Modifier ";
            this.BtnModifierUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnRechercher.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnRechercher.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.Location = new System.Drawing.Point(874, 97);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRechercher.OnHoverImage = null;
            this.BtnRechercher.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRechercher.Radius = 10;
            this.BtnRechercher.Size = new System.Drawing.Size(203, 32);
            this.BtnRechercher.TabIndex = 122;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRechercher
            // 
            this.TxtRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRechercher.BackColor = System.Drawing.Color.Transparent;
            this.TxtRechercher.BaseColor = System.Drawing.Color.White;
            this.TxtRechercher.BorderColor = System.Drawing.Color.Silver;
            this.TxtRechercher.BorderSize = 1;
            this.TxtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRechercher.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtRechercher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtRechercher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRechercher.Location = new System.Drawing.Point(486, 97);
            this.TxtRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRechercher.Name = "TxtRechercher";
            this.TxtRechercher.PasswordChar = '\0';
            this.TxtRechercher.Radius = 10;
            this.TxtRechercher.Size = new System.Drawing.Size(349, 37);
            this.TxtRechercher.TabIndex = 121;
            // 
            // lblRechercher
            // 
            this.lblRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(374, 100);
            this.lblRechercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(101, 23);
            this.lblRechercher.TabIndex = 120;
            this.lblRechercher.Text = "Rechercher";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 172);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1416, 560);
            this.listView1.TabIndex = 119;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOM DU FOURNISSEUR";
            this.columnHeader1.Width = 305;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADRESSE";
            this.columnHeader2.Width = 385;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEPHONE";
            this.columnHeader3.Width = 675;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 118;
            this.label1.Text = "Liste des noms des Fournisseurs";
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton1.Location = new System.Drawing.Point(1333, 111);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(56, 34);
            this.gunaButton1.TabIndex = 124;
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.BorderSize = 1;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(857, 739);
            this.gunaAdvenceButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 5;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(256, 38);
            this.gunaAdvenceButton2.TabIndex = 123;
            this.gunaAdvenceButton2.Text = "Supprimer";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.White;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.BorderSize = 1;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(317, 739);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(261, 38);
            this.gunaButton2.TabIndex = 122;
            this.gunaButton2.Text = "Modifier ";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.BorderSize = 1;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(842, 74);
            this.gunaAdvenceButton3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Radius = 10;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(203, 32);
            this.gunaAdvenceButton3.TabIndex = 121;
            this.gunaAdvenceButton3.Text = "Rechercher";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(454, 74);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(349, 37);
            this.gunaTextBox1.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 119;
            this.label2.Text = "Rechercher";
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.AllowColumnReorder = true;
            this.listView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(19, 153);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1369, 560);
            this.listView2.TabIndex = 118;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID DU CLIENT";
            this.columnHeader4.Width = 612;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "NOM DU CLIENT";
            this.columnHeader5.Width = 550;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 117;
            this.label3.Text = "Liste des Clients";
            // 
            // UserControlFichiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabClient);
            this.Name = "UserControlFichiers";
            this.Size = new System.Drawing.Size(1460, 882);
            this.tabClient.ResumeLayout(false);
            this.tabFournisseur.ResumeLayout(false);
            this.tabFournisseur.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabClient;
        private System.Windows.Forms.TabPage tabFournisseur;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabdepense;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaButton BtnActualiser;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAjoutNomF;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupprimerUtilisateur;
        private Guna.UI.WinForms.GunaButton BtnModifierUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaTextBox TxtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
    }
}
