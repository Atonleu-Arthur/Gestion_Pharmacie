namespace FormPharmacie.UserControls
{
    partial class UserControlEntre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEntre));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaTextBox9 = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.BtnChoixP = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaTextBox10 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.columnHeader6,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(22, 184);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1531, 492);
            this.listView1.TabIndex = 124;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRODUIT";
            this.columnHeader1.Width = 377;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PRIX DE VENTE";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "QUANTITE";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PEREMPTION";
            this.columnHeader5.Width = 239;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STOCK";
            this.columnHeader6.Width = 234;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total TTC";
            this.columnHeader4.Width = 408;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaElipsePanel2.Controls.Add(this.gunaTextBox9);
            this.gunaElipsePanel2.Controls.Add(this.label3);
            this.gunaElipsePanel2.Controls.Add(this.label1);
            this.gunaElipsePanel2.Controls.Add(this.flowLayoutPanel1);
            this.gunaElipsePanel2.Controls.Add(this.gunaComboBox1);
            this.gunaElipsePanel2.Controls.Add(this.BtnChoixP);
            this.gunaElipsePanel2.Controls.Add(this.gunaButton6);
            this.gunaElipsePanel2.Controls.Add(this.gunaButton5);
            this.gunaElipsePanel2.Controls.Add(this.label10);
            this.gunaElipsePanel2.Controls.Add(this.gunaButton4);
            this.gunaElipsePanel2.Controls.Add(this.gunaTextBox10);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(22, 19);
            this.gunaElipsePanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 15;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(1494, 142);
            this.gunaElipsePanel2.TabIndex = 125;
            // 
            // gunaTextBox9
            // 
            this.gunaTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaTextBox9.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox9.BaseColor = System.Drawing.Color.Khaki;
            this.gunaTextBox9.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox9.BorderSize = 1;
            this.gunaTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox9.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox9.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox9.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox9.Location = new System.Drawing.Point(953, 21);
            this.gunaTextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox9.Name = "gunaTextBox9";
            this.gunaTextBox9.PasswordChar = '\0';
            this.gunaTextBox9.Radius = 8;
            this.gunaTextBox9.ReadOnly = true;
            this.gunaTextBox9.Size = new System.Drawing.Size(200, 30);
            this.gunaTextBox9.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(833, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Code barre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 110;
            this.label1.Text = "Produit";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1418, 1);
            this.flowLayoutPanel1.TabIndex = 109;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 1;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(141, 27);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 10;
            this.gunaComboBox1.Size = new System.Drawing.Size(206, 31);
            this.gunaComboBox1.TabIndex = 108;
            // 
            // BtnChoixP
            // 
            this.BtnChoixP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnChoixP.AnimationHoverSpeed = 0.07F;
            this.BtnChoixP.AnimationSpeed = 0.03F;
            this.BtnChoixP.BaseColor = System.Drawing.Color.Sienna;
            this.BtnChoixP.BorderColor = System.Drawing.Color.Black;
            this.BtnChoixP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChoixP.FocusedColor = System.Drawing.Color.Empty;
            this.BtnChoixP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnChoixP.ForeColor = System.Drawing.Color.Black;
            this.BtnChoixP.Image = null;
            this.BtnChoixP.ImageSize = new System.Drawing.Size(52, 52);
            this.BtnChoixP.Location = new System.Drawing.Point(761, 19);
            this.BtnChoixP.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChoixP.Name = "BtnChoixP";
            this.BtnChoixP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnChoixP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnChoixP.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnChoixP.OnHoverImage = null;
            this.BtnChoixP.OnPressedColor = System.Drawing.Color.Black;
            this.BtnChoixP.Size = new System.Drawing.Size(43, 32);
            this.BtnChoixP.TabIndex = 106;
            this.BtnChoixP.Text = "F9";
            // 
            // gunaTextBox10
            // 
            this.gunaTextBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaTextBox10.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox10.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox10.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox10.BorderSize = 1;
            this.gunaTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox10.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox10.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox10.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox10.Location = new System.Drawing.Point(448, 27);
            this.gunaTextBox10.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox10.Name = "gunaTextBox10";
            this.gunaTextBox10.PasswordChar = '\0';
            this.gunaTextBox10.Radius = 8;
            this.gunaTextBox10.ReadOnly = true;
            this.gunaTextBox10.Size = new System.Drawing.Size(271, 31);
            this.gunaTextBox10.TabIndex = 56;
            // 
            // gunaButton6
            // 
            this.gunaButton6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.White;
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.BorderSize = 1;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton6.ForeColor = System.Drawing.Color.Black;
            this.gunaButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton6.Image")));
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Location = new System.Drawing.Point(1005, 100);
            this.gunaButton6.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 10;
            this.gunaButton6.Size = new System.Drawing.Size(129, 32);
            this.gunaButton6.TabIndex = 68;
            this.gunaButton6.Text = "Actualiser";
            // 
            // gunaButton5
            // 
            this.gunaButton5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.White;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.BorderSize = 1;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton5.ForeColor = System.Drawing.Color.Black;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(1161, 100);
            this.gunaButton5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(131, 32);
            this.gunaButton5.TabIndex = 67;
            this.gunaButton5.Text = "Fermer";
            // 
            // gunaButton4
            // 
            this.gunaButton4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.White;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.BorderSize = 1;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(848, 100);
            this.gunaButton4.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(110, 32);
            this.gunaButton4.TabIndex = 52;
            this.gunaButton4.Text = "Imprimer";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Fournissuer";
            // 
            // UserControlEntre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Name = "UserControlEntre";
            this.Size = new System.Drawing.Size(1579, 866);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaCircleButton BtnChoixP;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox10;
        private System.Windows.Forms.Label label10;
    }
}
