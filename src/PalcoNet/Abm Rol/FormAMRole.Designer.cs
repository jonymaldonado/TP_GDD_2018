namespace PalcoNet.Abm_Rol
{
    partial class FormAMRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAMRole));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_enabled = new System.Windows.Forms.CheckBox();
            this.btn_change_name = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_functions_added = new System.Windows.Forms.ListBox();
            this.lst_functions_not_added = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acceptToolStripMenuItem
            // 
            this.acceptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acceptToolStripMenuItem.Image")));
            this.acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            this.acceptToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.acceptToolStripMenuItem.Text = "Aceptar";
            this.acceptToolStripMenuItem.Click += new System.EventHandler(this.acceptToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToolStripMenuItem.Image")));
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.returnToolStripMenuItem.Text = "Volver";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // chk_enabled
            // 
            this.chk_enabled.AutoSize = true;
            this.chk_enabled.Location = new System.Drawing.Point(276, 73);
            this.chk_enabled.Name = "chk_enabled";
            this.chk_enabled.Size = new System.Drawing.Size(73, 17);
            this.chk_enabled.TabIndex = 19;
            this.chk_enabled.Text = "Habilitado";
            this.chk_enabled.UseVisualStyleBackColor = true;
            // 
            // btn_change_name
            // 
            this.btn_change_name.Location = new System.Drawing.Point(474, 47);
            this.btn_change_name.Name = "btn_change_name";
            this.btn_change_name.Size = new System.Drawing.Size(96, 23);
            this.btn_change_name.TabIndex = 18;
            this.btn_change_name.Text = "Cambiar Nombre";
            this.btn_change_name.UseVisualStyleBackColor = true;
            this.btn_change_name.Click += new System.EventHandler(this.btn_change_name_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(206, 47);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(221, 20);
            this.txt_name.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(281, 291);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(281, 178);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 33);
            this.btn_add.TabIndex = 15;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ASIGNADOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DISPONIBLES";
            // 
            // lst_functions_added
            // 
            this.lst_functions_added.FormattingEnabled = true;
            this.lst_functions_added.Location = new System.Drawing.Point(371, 130);
            this.lst_functions_added.Name = "lst_functions_added";
            this.lst_functions_added.Size = new System.Drawing.Size(228, 264);
            this.lst_functions_added.TabIndex = 12;
            // 
            // lst_functions_not_added
            // 
            this.lst_functions_not_added.FormattingEnabled = true;
            this.lst_functions_not_added.Location = new System.Drawing.Point(36, 130);
            this.lst_functions_not_added.Name = "lst_functions_not_added";
            this.lst_functions_not_added.Size = new System.Drawing.Size(228, 264);
            this.lst_functions_not_added.TabIndex = 10;
            // 
            // FormAMRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 414);
            this.Controls.Add(this.chk_enabled);
            this.Controls.Add(this.btn_change_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_functions_added);
            this.Controls.Add(this.lst_functions_not_added);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAMRole";
            this.Text = "Administración de funciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_enabled;
        private System.Windows.Forms.Button btn_change_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_functions_added;
        private System.Windows.Forms.ListBox lst_functions_not_added;
    }
}