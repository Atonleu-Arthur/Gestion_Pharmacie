namespace FormPharmacie
{
    partial class FormLogin
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.ComboboxUtl = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnexion = new Guna.UI.WinForms.GunaButton();
            this.txtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-77, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "copyrights © 2019,All rights Reserved ";
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.pictureBox1);
            this.panelControls.Controls.Add(this.gunaElipsePanel1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1047, 666);
            this.panelControls.TabIndex = 39;
            this.panelControls.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelControls_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Copyriht tout droit reserve ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 48;
            this.label2.Text = "GLOBAL PHARMA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.SystemColors.Window;
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.label11);
            this.gunaElipsePanel1.Controls.Add(this.ComboboxUtl);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.btnConnexion);
            this.gunaElipsePanel1.Controls.Add(this.txtMdp);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(280, 238);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 25;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(462, 353);
            this.gunaElipsePanel1.TabIndex = 46;
            // 
            // ComboboxUtl
            // 
            this.ComboboxUtl.BackColor = System.Drawing.Color.Transparent;
            this.ComboboxUtl.BaseColor = System.Drawing.Color.White;
            this.ComboboxUtl.BorderColor = System.Drawing.Color.Silver;
            this.ComboboxUtl.BorderSize = 1;
            this.ComboboxUtl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboboxUtl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxUtl.FocusedColor = System.Drawing.Color.Empty;
            this.ComboboxUtl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboboxUtl.ForeColor = System.Drawing.Color.Black;
            this.ComboboxUtl.FormattingEnabled = true;
            this.ComboboxUtl.Location = new System.Drawing.Point(85, 119);
            this.ComboboxUtl.Name = "ComboboxUtl";
            this.ComboboxUtl.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboboxUtl.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboboxUtl.Radius = 10;
            this.ComboboxUtl.Size = new System.Drawing.Size(279, 31);
            this.ComboboxUtl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connexion";
            // 
            // btnConnexion
            // 
            this.btnConnexion.AnimationHoverSpeed = 0.07F;
            this.btnConnexion.AnimationSpeed = 0.03F;
            this.btnConnexion.BackColor = System.Drawing.Color.Transparent;
            this.btnConnexion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(199)))), ((int)(((byte)(129)))));
            this.btnConnexion.BorderColor = System.Drawing.Color.Black;
            this.btnConnexion.FocusedColor = System.Drawing.Color.Empty;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Image = null;
            this.btnConnexion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConnexion.Location = new System.Drawing.Point(131, 262);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConnexion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConnexion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConnexion.OnHoverImage = null;
            this.btnConnexion.OnPressedColor = System.Drawing.Color.Black;
            this.btnConnexion.Radius = 20;
            this.btnConnexion.Size = new System.Drawing.Size(197, 42);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Se Connecter";
            this.btnConnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            this.btnConnexion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnConnexion_KeyDown);
            this.btnConnexion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnConnexion_KeyPress);
            // 
            // txtMdp
            // 
            this.txtMdp.BackColor = System.Drawing.Color.Transparent;
            this.txtMdp.BaseColor = System.Drawing.Color.White;
            this.txtMdp.BorderColor = System.Drawing.Color.Silver;
            this.txtMdp.BorderSize = 1;
            this.txtMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMdp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMdp.Location = new System.Drawing.Point(85, 188);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '●';
            this.txtMdp.Radius = 8;
            this.txtMdp.Size = new System.Drawing.Size(279, 31);
            this.txtMdp.TabIndex = 1;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(89, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 139;
            this.label11.Text = "Choix utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 140;
            this.label4.Text = "Mot de passe";
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1047, 666);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnConnexion;
        private Guna.UI.WinForms.GunaTextBox txtMdp;
        private Guna.UI.WinForms.GunaComboBox ComboboxUtl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
    }
}

