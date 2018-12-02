namespace PalcoNet.Abm_Empresa_Espectaculo
{
    partial class FormAMEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAMEmpresa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aceptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_empresa = new System.Windows.Forms.GroupBox();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_postal_code = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_number_street = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.group_empresa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aceptarToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.limpiarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aceptarToolStripMenuItem
            // 
            this.aceptarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aceptarToolStripMenuItem.Image")));
            this.aceptarToolStripMenuItem.Name = "aceptarToolStripMenuItem";
            this.aceptarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aceptarToolStripMenuItem.Text = "Aceptar";
            this.aceptarToolStripMenuItem.Click += new System.EventHandler(this.aceptarToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToolStripMenuItem.Image")));
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.returnToolStripMenuItem.Text = "Volver";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // group_empresa
            // 
            this.group_empresa.Controls.Add(this.chk_active);
            this.group_empresa.Controls.Add(this.groupBox1);
            this.group_empresa.Controls.Add(this.label4);
            this.group_empresa.Controls.Add(this.txt_cuit);
            this.group_empresa.Controls.Add(this.label3);
            this.group_empresa.Controls.Add(this.txt_phone);
            this.group_empresa.Controls.Add(this.label2);
            this.group_empresa.Controls.Add(this.txt_email);
            this.group_empresa.Controls.Add(this.label1);
            this.group_empresa.Controls.Add(this.txt_razon_social);
            this.group_empresa.Location = new System.Drawing.Point(13, 37);
            this.group_empresa.Name = "group_empresa";
            this.group_empresa.Size = new System.Drawing.Size(547, 296);
            this.group_empresa.TabIndex = 60;
            this.group_empresa.TabStop = false;
            this.group_empresa.Text = "Datos Empresa";
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Location = new System.Drawing.Point(20, 253);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(73, 17);
            this.chk_active.TabIndex = 9;
            this.chk_active.Text = "Habilitado";
            this.chk_active.UseVisualStyleBackColor = true;
            this.chk_active.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_city);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_postal_code);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_location);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_department);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_floor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_number_street);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_street);
            this.groupBox1.Location = new System.Drawing.Point(20, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Ciudad:";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(334, 84);
            this.txt_city.MaxLength = 50;
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(185, 20);
            this.txt_city.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "Código postal:";
            // 
            // txt_postal_code
            // 
            this.txt_postal_code.Location = new System.Drawing.Point(334, 31);
            this.txt_postal_code.MaxLength = 50;
            this.txt_postal_code.Name = "txt_postal_code";
            this.txt_postal_code.Size = new System.Drawing.Size(186, 20);
            this.txt_postal_code.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Localidad:";
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(334, 58);
            this.txt_location.MaxLength = 50;
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(185, 20);
            this.txt_location.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Depto:";
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(197, 82);
            this.txt_department.MaxLength = 50;
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(56, 20);
            this.txt_department.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Piso:";
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(68, 82);
            this.txt_floor.MaxLength = 18;
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(52, 20);
            this.txt_floor.TabIndex = 71;
            this.txt_floor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_floor_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Número:";
            // 
            // txt_number_street
            // 
            this.txt_number_street.Location = new System.Drawing.Point(68, 56);
            this.txt_number_street.MaxLength = 18;
            this.txt_number_street.Name = "txt_number_street";
            this.txt_number_street.Size = new System.Drawing.Size(185, 20);
            this.txt_number_street.TabIndex = 69;
            this.txt_number_street.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_street_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Calle:";
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(69, 30);
            this.txt_street.MaxLength = 50;
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(184, 20);
            this.txt_street.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CUIT:";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(357, 65);
            this.txt_cuit.MaxLength = 255;
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(184, 20);
            this.txt_cuit.TabIndex = 6;
            this.txt_cuit.Validating += txt_cuit_Validating;        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teléfono:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(357, 29);
            this.txt_phone.MaxLength = 20;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(184, 20);
            this.txt_phone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(89, 65);
            this.txt_email.MaxLength = 255;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(184, 20);
            this.txt_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razón Social:";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(89, 29);
            this.txt_razon_social.MaxLength = 255;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(184, 20);
            this.txt_razon_social.TabIndex = 0;
            // 
            // FormAMEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.group_empresa);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAMEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_empresa.ResumeLayout(false);
            this.group_empresa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aceptarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox group_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_postal_code;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_floor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_number_street;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_active;
    }
}