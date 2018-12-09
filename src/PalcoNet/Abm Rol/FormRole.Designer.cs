namespace PalcoNet.Abm_Rol
{
    partial class FormRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRole));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.chk_available = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btn_reestablish = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.dg_rol = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.addToolStripMenuItem.Text = "Agregar";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyToolStripMenuItem.Image")));
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.modifyToolStripMenuItem.Text = "Modificar";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.deleteToolStripMenuItem.Text = "Eliminar";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToolStripMenuItem.Image")));
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.returnToolStripMenuItem.Text = "Volver";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.chk_available);
            this.groupBoxAdd.Controls.Add(this.label5);
            this.groupBoxAdd.Controls.Add(this.txt_add_name);
            this.groupBoxAdd.Controls.Add(this.btn_save);
            this.groupBoxAdd.Location = new System.Drawing.Point(63, 49);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(352, 70);
            this.groupBoxAdd.TabIndex = 20;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Agregar Rol";
            // 
            // chk_available
            // 
            this.chk_available.AutoSize = true;
            this.chk_available.Location = new System.Drawing.Point(257, 18);
            this.chk_available.Name = "chk_available";
            this.chk_available.Size = new System.Drawing.Size(73, 17);
            this.chk_available.TabIndex = 15;
            this.chk_available.Text = "Habilitado";
            this.chk_available.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre:";
            // 
            // txt_add_name
            // 
            this.txt_add_name.Location = new System.Drawing.Point(65, 19);
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(171, 20);
            this.txt_add_name.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(257, 41);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Roles disponibles:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(306, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Rol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btn_reestablish);
            this.groupBoxSearch.Controls.Add(this.btn_search);
            this.groupBoxSearch.Controls.Add(this.lbl_nombre);
            this.groupBoxSearch.Controls.Add(this.txt_search_name);
            this.groupBoxSearch.Location = new System.Drawing.Point(63, 125);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(352, 94);
            this.groupBoxSearch.TabIndex = 15;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Búsqueda";
            // 
            // btn_reestablish
            // 
            this.btn_reestablish.Location = new System.Drawing.Point(252, 65);
            this.btn_reestablish.Name = "btn_reestablish";
            this.btn_reestablish.Size = new System.Drawing.Size(78, 23);
            this.btn_reestablish.TabIndex = 6;
            this.btn_reestablish.Text = "Reestablecer";
            this.btn_reestablish.UseVisualStyleBackColor = true;
            this.btn_reestablish.Click += new System.EventHandler(this.btn_reestablish_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(65, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 31);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(65, 28);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(267, 20);
            this.txt_search_name.TabIndex = 1;
            // 
            // dg_rol
            // 
            this.dg_rol.AllowUserToAddRows = false;
            this.dg_rol.AllowUserToDeleteRows = false;
            this.dg_rol.AllowUserToResizeColumns = false;
            this.dg_rol.AllowUserToResizeRows = false;
            this.dg_rol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rol.Location = new System.Drawing.Point(63, 249);
            this.dg_rol.MultiSelect = false;
            this.dg_rol.Name = "dg_rol";
            this.dg_rol.ReadOnly = true;
            this.dg_rol.RowHeadersVisible = false;
            this.dg_rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_rol.Size = new System.Drawing.Size(352, 156);
            this.dg_rol.TabIndex = 14;
            // 
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 436);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dg_rol);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.FormRole_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.CheckBox chk_available;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_add_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btn_reestablish;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.DataGridView dg_rol;
    }
}