﻿namespace PalcoNet.Abm_Grado
{
    partial class FormAMGrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAMGrado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aceptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_empresa = new System.Windows.Forms.GroupBox();
            this.txt_prioridad = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_comision = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.group_empresa.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 60;
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
            this.group_empresa.Controls.Add(this.txt_prioridad);
            this.group_empresa.Controls.Add(this.txt_peso);
            this.group_empresa.Controls.Add(this.label3);
            this.group_empresa.Controls.Add(this.label2);
            this.group_empresa.Controls.Add(this.label1);
            this.group_empresa.Controls.Add(this.txt_comision);
            this.group_empresa.Location = new System.Drawing.Point(12, 27);
            this.group_empresa.Name = "group_empresa";
            this.group_empresa.Size = new System.Drawing.Size(302, 135);
            this.group_empresa.TabIndex = 61;
            this.group_empresa.TabStop = false;
            this.group_empresa.Text = "Datos Empresa";
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.Location = new System.Drawing.Point(88, 63);
            this.txt_prioridad.MaxLength = 255;
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Size = new System.Drawing.Size(184, 20);
            this.txt_prioridad.TabIndex = 60;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(89, 97);
            this.txt_peso.MaxLength = 255;
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(184, 20);
            this.txt_peso.TabIndex = 61;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_comision_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prioridad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comisión (%):";
            // 
            // txt_comision
            // 
            this.txt_comision.Location = new System.Drawing.Point(89, 29);
            this.txt_comision.MaxLength = 255;
            this.txt_comision.Name = "txt_comision";
            this.txt_comision.Size = new System.Drawing.Size(184, 20);
            this.txt_comision.TabIndex = 0;
            this.txt_comision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_comision_KeyPress);
            // 
            // FormAMGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 171);
            this.Controls.Add(this.group_empresa);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAMGrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_empresa.ResumeLayout(false);
            this.group_empresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aceptarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.GroupBox group_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_comision;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prioridad;
    }
}