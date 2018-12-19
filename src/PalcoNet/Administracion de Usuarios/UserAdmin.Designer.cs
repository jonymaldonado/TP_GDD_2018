namespace PalcoNet.Administracion_de_Usuarios
{
    partial class UserAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_deshabilitar = new System.Windows.Forms.Button();
            this.btn_pass = new System.Windows.Forms.Button();
            this.btn_rol = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 50;
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Habilitado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.AllowUserToResizeColumns = false;
            this.dgv_list.AllowUserToResizeRows = false;
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(11, 114);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowHeadersVisible = false;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(352, 263);
            this.dgv_list.TabIndex = 51;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(256, 19);
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
            this.lbl_nombre.Location = new System.Drawing.Point(7, 24);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(58, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Username:";
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(66, 21);
            this.txt_search_name.MaxLength = 100;
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(183, 20);
            this.txt_search_name.TabIndex = 1;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btn_search);
            this.groupBoxSearch.Controls.Add(this.lbl_nombre);
            this.groupBoxSearch.Controls.Add(this.txt_search_name);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 28);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(352, 51);
            this.groupBoxSearch.TabIndex = 55;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Búsqueda";
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Location = new System.Drawing.Point(15, 85);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(62, 23);
            this.btn_habilitar.TabIndex = 6;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // btn_deshabilitar
            // 
            this.btn_deshabilitar.Location = new System.Drawing.Point(83, 85);
            this.btn_deshabilitar.Name = "btn_deshabilitar";
            this.btn_deshabilitar.Size = new System.Drawing.Size(78, 23);
            this.btn_deshabilitar.TabIndex = 7;
            this.btn_deshabilitar.Text = "Deshabilitar";
            this.btn_deshabilitar.UseVisualStyleBackColor = true;
            this.btn_deshabilitar.Click += new System.EventHandler(this.btn_deshabilitar_Click);
            // 
            // btn_pass
            // 
            this.btn_pass.Location = new System.Drawing.Point(167, 85);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(102, 23);
            this.btn_pass.TabIndex = 8;
            this.btn_pass.Text = "Cambiar Password";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // btn_rol
            // 
            this.btn_rol.Location = new System.Drawing.Point(275, 85);
            this.btn_rol.Name = "btn_rol";
            this.btn_rol.Size = new System.Drawing.Size(78, 23);
            this.btn_rol.TabIndex = 56;
            this.btn_rol.Text = "Roles";
            this.btn_rol.UseVisualStyleBackColor = true;
            this.btn_rol.Click += new System.EventHandler(this.btn_rol_Click);
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 389);
            this.Controls.Add(this.btn_rol);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.btn_deshabilitar);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserAdmin";
            this.Text = "Administración de Usuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btn_deshabilitar;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Button btn_rol;
    }
}
