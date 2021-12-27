namespace FormPharmacie.UserControls
{
    partial class UserMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMedicament));
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TxtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSupprimerUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnModifierUtilisateur = new Guna.UI.WinForms.GunaButton();
            this.BtnAjoutNomMed = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnActualiser = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categorie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom Medicament";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Forme Pharmaceutique";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 210;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Image";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 210;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des noms des Médicaments";
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
            this.listView1.Location = new System.Drawing.Point(14, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1170, 456);
            this.listView1.TabIndex = 94;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID DU MEDICAMENT";
            this.columnHeader1.Width = 262;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOM DU MEDICAMENT";
            this.columnHeader2.Width = 437;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "INFORMATION";
            this.columnHeader3.Width = 675;
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
            this.BtnRechercher.Location = new System.Drawing.Point(696, 131);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRechercher.OnHoverImage = null;
            this.BtnRechercher.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRechercher.Radius = 10;
            this.BtnRechercher.Size = new System.Drawing.Size(152, 26);
            this.BtnRechercher.TabIndex = 97;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
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
            this.TxtRechercher.Location = new System.Drawing.Point(405, 131);
            this.TxtRechercher.Name = "TxtRechercher";
            this.TxtRechercher.PasswordChar = '\0';
            this.TxtRechercher.Radius = 10;
            this.TxtRechercher.Size = new System.Drawing.Size(262, 30);
            this.TxtRechercher.TabIndex = 96;
            // 
            // lblRechercher
            // 
            this.lblRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(275, 134);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(101, 23);
            this.lblRechercher.TabIndex = 95;
            this.lblRechercher.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 101;
            this.label2.Text = "enregistrés";
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
            this.BtnSupprimerUtilisateur.Location = new System.Drawing.Point(280, 662);
            this.BtnSupprimerUtilisateur.Name = "BtnSupprimerUtilisateur";
            this.BtnSupprimerUtilisateur.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.BtnSupprimerUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.OnHoverImage = null;
            this.BtnSupprimerUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupprimerUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.Radius = 5;
            this.BtnSupprimerUtilisateur.Size = new System.Drawing.Size(192, 31);
            this.BtnSupprimerUtilisateur.TabIndex = 103;
            this.BtnSupprimerUtilisateur.Text = "Supprimer";
            this.BtnSupprimerUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnModifierUtilisateur.Location = new System.Drawing.Point(21, 662);
            this.BtnModifierUtilisateur.Name = "BtnModifierUtilisateur";
            this.BtnModifierUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnModifierUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnModifierUtilisateur.OnHoverImage = null;
            this.BtnModifierUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.Radius = 5;
            this.BtnModifierUtilisateur.Size = new System.Drawing.Size(196, 31);
            this.BtnModifierUtilisateur.TabIndex = 102;
            this.BtnModifierUtilisateur.Text = "Modifier ";
            this.BtnModifierUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnModifierUtilisateur.Click += new System.EventHandler(this.BtnModifierUtilisateur_Click);
            // 
            // BtnAjoutNomMed
            // 
            this.BtnAjoutNomMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAjoutNomMed.AnimationHoverSpeed = 0.07F;
            this.BtnAjoutNomMed.AnimationSpeed = 0.03F;
            this.BtnAjoutNomMed.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjoutNomMed.BaseColor = System.Drawing.Color.White;
            this.BtnAjoutNomMed.BorderColor = System.Drawing.Color.Black;
            this.BtnAjoutNomMed.BorderSize = 1;
            this.BtnAjoutNomMed.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnAjoutNomMed.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutNomMed.CheckedForeColor = System.Drawing.Color.White;
            this.BtnAjoutNomMed.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnAjoutNomMed.CheckedImage")));
            this.BtnAjoutNomMed.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnAjoutNomMed.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAjoutNomMed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjoutNomMed.ForeColor = System.Drawing.Color.Black;
            this.BtnAjoutNomMed.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjoutNomMed.Image")));
            this.BtnAjoutNomMed.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAjoutNomMed.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutNomMed.Location = new System.Drawing.Point(571, 662);
            this.BtnAjoutNomMed.Name = "BtnAjoutNomMed";
            this.BtnAjoutNomMed.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnAjoutNomMed.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutNomMed.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAjoutNomMed.OnHoverImage = null;
            this.BtnAjoutNomMed.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutNomMed.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutNomMed.Radius = 5;
            this.BtnAjoutNomMed.Size = new System.Drawing.Size(286, 31);
            this.BtnAjoutNomMed.TabIndex = 104;
            this.BtnAjoutNomMed.Text = "Enregistrer un nom de medicament";
            this.BtnAjoutNomMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAjoutNomMed.Click += new System.EventHandler(this.BtnAjoutNomMed_Click);
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
            this.BtnActualiser.Location = new System.Drawing.Point(1135, 125);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualiser.OnHoverImage = null;
            this.BtnActualiser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualiser.Radius = 10;
            this.BtnActualiser.Size = new System.Drawing.Size(42, 28);
            this.BtnActualiser.TabIndex = 105;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(962, 662);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 5;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(215, 31);
            this.gunaAdvenceButton1.TabIndex = 106;
            this.gunaAdvenceButton1.Text = "Imprimer la liste";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserMedicament
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.BtnAjoutNomMed);
            this.Controls.Add(this.BtnSupprimerUtilisateur);
            this.Controls.Add(this.BtnModifierUtilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.TxtRechercher);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserMedicament";
            this.Size = new System.Drawing.Size(1208, 772);
            this.Load += new System.EventHandler(this.UserMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaTextBox TxtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupprimerUtilisateur;
        private Guna.UI.WinForms.GunaButton BtnModifierUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAjoutNomMed;
        private Guna.UI.WinForms.GunaButton BtnActualiser;
        public System.Windows.Forms.ListView listView1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}
