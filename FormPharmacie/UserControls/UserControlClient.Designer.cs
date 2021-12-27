namespace FormPharmacie.UserControls
{
    partial class UserControlClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClient));
            this.TxtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualiser = new Guna.UI.WinForms.GunaButton();
            this.BtnSupprimerUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnModifierUtilisateur = new Guna.UI.WinForms.GunaButton();
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
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
            this.TxtRechercher.Location = new System.Drawing.Point(319, 41);
            this.TxtRechercher.Name = "TxtRechercher";
            this.TxtRechercher.PasswordChar = '\0';
            this.TxtRechercher.Radius = 10;
            this.TxtRechercher.Size = new System.Drawing.Size(262, 26);
            this.TxtRechercher.TabIndex = 110;
            // 
            // lblRechercher
            // 
            this.lblRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(235, 44);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(78, 19);
            this.lblRechercher.TabIndex = 109;
            this.lblRechercher.Text = "Rechercher";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(995, 456);
            this.listView1.TabIndex = 108;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID DU CLIENT";
            this.columnHeader1.Width = 483;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOM DU CLIENT";
            this.columnHeader2.Width = 550;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 107;
            this.label1.Text = "Liste des Clients";
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
            this.BtnActualiser.Location = new System.Drawing.Point(967, 54);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BtnActualiser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualiser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualiser.OnHoverImage = null;
            this.BtnActualiser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualiser.Radius = 10;
            this.BtnActualiser.Size = new System.Drawing.Size(42, 28);
            this.BtnActualiser.TabIndex = 116;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
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
            this.BtnSupprimerUtilisateur.Location = new System.Drawing.Point(610, 564);
            this.BtnSupprimerUtilisateur.Name = "BtnSupprimerUtilisateur";
            this.BtnSupprimerUtilisateur.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.BtnSupprimerUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSupprimerUtilisateur.OnHoverImage = null;
            this.BtnSupprimerUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnSupprimerUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSupprimerUtilisateur.Radius = 5;
            this.BtnSupprimerUtilisateur.Size = new System.Drawing.Size(192, 31);
            this.BtnSupprimerUtilisateur.TabIndex = 114;
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
            this.BtnModifierUtilisateur.Location = new System.Drawing.Point(205, 564);
            this.BtnModifierUtilisateur.Name = "BtnModifierUtilisateur";
            this.BtnModifierUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnModifierUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnModifierUtilisateur.OnHoverImage = null;
            this.BtnModifierUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnModifierUtilisateur.Radius = 5;
            this.BtnModifierUtilisateur.Size = new System.Drawing.Size(196, 31);
            this.BtnModifierUtilisateur.TabIndex = 113;
            this.BtnModifierUtilisateur.Text = "Modifier ";
            this.BtnModifierUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnModifierUtilisateur.Click += new System.EventHandler(this.BtnModifierUtilisateur_Click);
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
            this.BtnRechercher.Location = new System.Drawing.Point(610, 41);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRechercher.OnHoverImage = null;
            this.BtnRechercher.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRechercher.Radius = 10;
            this.BtnRechercher.Size = new System.Drawing.Size(152, 26);
            this.BtnRechercher.TabIndex = 111;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.BtnSupprimerUtilisateur);
            this.Controls.Add(this.BtnModifierUtilisateur);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.TxtRechercher);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1023, 611);
            this.Load += new System.EventHandler(this.UserControlClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton BtnActualiser;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSupprimerUtilisateur;
        private Guna.UI.WinForms.GunaButton BtnModifierUtilisateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaTextBox TxtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}
