namespace FormPharmacie
{
    partial class FormChoixClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoixClient));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.BtnRechercher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.BtnFermer = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAjoutUtilisateru = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAjoutUtilisateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnValideCli = new System.Windows.Forms.Button();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 112);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(517, 483);
            this.listView1.TabIndex = 109;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOM DU CLIENT";
            this.columnHeader2.Width = 504;
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
            this.TxtRechercher.Location = new System.Drawing.Point(123, 52);
            this.TxtRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRechercher.Name = "TxtRechercher";
            this.TxtRechercher.PasswordChar = '\0';
            this.TxtRechercher.Radius = 10;
            this.TxtRechercher.Size = new System.Drawing.Size(224, 37);
            this.TxtRechercher.TabIndex = 113;
            // 
            // lblRechercher
            // 
            this.lblRechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(13, 56);
            this.lblRechercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(101, 23);
            this.lblRechercher.TabIndex = 112;
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
            this.BtnRechercher.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnRechercher.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.Location = new System.Drawing.Point(367, 52);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRechercher.OnHoverImage = null;
            this.BtnRechercher.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRechercher.Radius = 10;
            this.BtnRechercher.Size = new System.Drawing.Size(51, 32);
            this.BtnRechercher.TabIndex = 114;
            this.BtnRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 15;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // BtnFermer
            // 
            this.BtnFermer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnFermer.AnimationHoverSpeed = 0.07F;
            this.BtnFermer.AnimationSpeed = 0.03F;
            this.BtnFermer.BackColor = System.Drawing.Color.Transparent;
            this.BtnFermer.BaseColor = System.Drawing.Color.White;
            this.BtnFermer.BorderColor = System.Drawing.Color.Black;
            this.BtnFermer.BorderSize = 1;
            this.BtnFermer.FocusedColor = System.Drawing.Color.Empty;
            this.BtnFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFermer.ForeColor = System.Drawing.Color.Black;
            this.BtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.Image")));
            this.BtnFermer.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnFermer.Location = new System.Drawing.Point(16, 620);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.BtnFermer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnFermer.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnFermer.OnHoverImage = null;
            this.BtnFermer.OnPressedColor = System.Drawing.Color.Black;
            this.BtnFermer.Radius = 10;
            this.BtnFermer.Size = new System.Drawing.Size(215, 32);
            this.BtnFermer.TabIndex = 116;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 663);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 4);
            this.panel3.TabIndex = 120;
            // 
            // panelAjoutUtilisateru
            // 
            this.panelAjoutUtilisateru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panelAjoutUtilisateru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAjoutUtilisateru.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAjoutUtilisateru.Location = new System.Drawing.Point(0, 0);
            this.panelAjoutUtilisateru.Margin = new System.Windows.Forms.Padding(4);
            this.panelAjoutUtilisateru.Name = "panelAjoutUtilisateru";
            this.panelAjoutUtilisateru.Size = new System.Drawing.Size(3, 667);
            this.panelAjoutUtilisateru.TabIndex = 119;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(523, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 667);
            this.panel2.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 121;
            this.label1.Text = "Choix du Client";
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
            this.BtnAjoutUtilisateur.Location = new System.Drawing.Point(445, 52);
            this.BtnAjoutUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjoutUtilisateur.Name = "BtnAjoutUtilisateur";
            this.BtnAjoutUtilisateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.BtnAjoutUtilisateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAjoutUtilisateur.OnHoverImage = null;
            this.BtnAjoutUtilisateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAjoutUtilisateur.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAjoutUtilisateur.Radius = 10;
            this.BtnAjoutUtilisateur.Size = new System.Drawing.Size(52, 32);
            this.BtnAjoutUtilisateur.TabIndex = 122;
            this.BtnAjoutUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAjoutUtilisateur.Click += new System.EventHandler(this.BtnAjoutUtilisateur_Click);
            // 
            // BtnValideCli
            // 
            this.BtnValideCli.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnValideCli.Location = new System.Drawing.Point(288, 620);
            this.BtnValideCli.Name = "BtnValideCli";
            this.BtnValideCli.Size = new System.Drawing.Size(117, 32);
            this.BtnValideCli.TabIndex = 123;
            this.BtnValideCli.Text = "button1";
            this.BtnValideCli.UseVisualStyleBackColor = true;
            this.BtnValideCli.Click += new System.EventHandler(this.BtnValideCli_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 5;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(520, 31);
            this.gunaElipsePanel1.TabIndex = 168;
            // 
            // FormChoixClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 667);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.BtnValideCli);
            this.Controls.Add(this.BtnAjoutUtilisateur);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelAjoutUtilisateru);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.TxtRechercher);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChoixClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChoixClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChoixClient_FormClosed);
            this.Load += new System.EventHandler(this.FormChoixClient_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Guna.UI.WinForms.GunaAdvenceButton BtnRechercher;
        private Guna.UI.WinForms.GunaTextBox TxtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private Guna.UI.WinForms.GunaButton BtnFermer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAjoutUtilisateru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAjoutUtilisateur;
        private System.Windows.Forms.Button BtnValideCli;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}