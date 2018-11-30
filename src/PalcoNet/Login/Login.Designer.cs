namespace PalcoNet.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_init = new System.Windows.Forms.Button();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btn_init);
            this.groupBox1.Controls.Add(this.lbl_rol);
            this.groupBox1.Controls.Add(this.cmb_rol);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.lbl_pass);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.lbl_user);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 255);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso al Sistema";
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(109, 113);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(79, 23);
            this.btn_init.TabIndex = 3;
            this.btn_init.Text = "Iniciar";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.ForeColor = System.Drawing.Color.Black;
            this.lbl_rol.Location = new System.Drawing.Point(18, 181);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(26, 13);
            this.lbl_rol.TabIndex = 8;
            this.lbl_rol.Text = "Rol:";
            this.lbl_rol.Visible = false;
            // 
            // cmb_rol
            // 
            this.cmb_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.ItemHeight = 13;
            this.cmb_rol.Location = new System.Drawing.Point(50, 178);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(189, 21);
            this.cmb_rol.Sorted = true;
            this.cmb_rol.TabIndex = 4;
            this.cmb_rol.Visible = false;
            this.cmb_rol.SelectedIndexChanged += new System.EventHandler(this.cmb_rol_SelectedIndexChanged);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(50, 42);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(189, 20);
            this.txt_user.TabIndex = 1;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Black;
            this.lbl_pass.Location = new System.Drawing.Point(49, 71);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(64, 13);
            this.lbl_pass.TabIndex = 6;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(50, 87);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(189, 20);
            this.txt_pass.TabIndex = 2;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_user.Location = new System.Drawing.Point(47, 26);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(46, 13);
            this.lbl_user.TabIndex = 5;
            this.lbl_user.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(230, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "FRBA - PalcoNet";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(119, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Regístrate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}