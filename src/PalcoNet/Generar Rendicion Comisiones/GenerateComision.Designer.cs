namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class GenerateComision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateComision));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_empresa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.txt_id_empresa = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gb_empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToolStripMenuItem.Image")));
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.returnToolStripMenuItem.Text = "Volver";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // gb_empresa
            // 
            this.gb_empresa.Controls.Add(this.txt_id_empresa);
            this.gb_empresa.Controls.Add(this.label3);
            this.gb_empresa.Controls.Add(this.label2);
            this.gb_empresa.Controls.Add(this.label4);
            this.gb_empresa.Controls.Add(this.txt_razon_social);
            this.gb_empresa.Controls.Add(this.txt_email);
            this.gb_empresa.Controls.Add(this.txt_cuit);
            this.gb_empresa.Controls.Add(this.label1);
            this.gb_empresa.Location = new System.Drawing.Point(30, 37);
            this.gb_empresa.Name = "gb_empresa";
            this.gb_empresa.Size = new System.Drawing.Size(609, 96);
            this.gb_empresa.TabIndex = 5;
            this.gb_empresa.TabStop = false;
            this.gb_empresa.Text = "Datos de la Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CUIT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Razón Social:";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Location = new System.Drawing.Point(98, 49);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(149, 20);
            this.txt_razon_social.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(305, 49);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(149, 20);
            this.txt_email.TabIndex = 8;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Enabled = false;
            this.txt_cuit.Location = new System.Drawing.Point(305, 23);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(149, 20);
            this.txt_cuit.TabIndex = 9;
            // 
            // txt_id_empresa
            // 
            this.txt_id_empresa.Enabled = false;
            this.txt_id_empresa.Location = new System.Drawing.Point(98, 23);
            this.txt_id_empresa.Name = "txt_id_empresa";
            this.txt_id_empresa.Size = new System.Drawing.Size(149, 20);
            this.txt_id_empresa.TabIndex = 1;
            // 
            // GenerateComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 425);
            this.Controls.Add(this.gb_empresa);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GenerateComision";
            this.Text = "Generar Rendicion de Comisiones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_empresa.ResumeLayout(false);
            this.gb_empresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_empresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_cuit;
    }
}