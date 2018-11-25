namespace PalcoNet.Listado_Estadistico
{
    partial class FormStatiscalList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatiscalList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.lbl_month = new System.Windows.Forms.Label();
            this.cmb_grade_visibility = new System.Windows.Forms.ComboBox();
            this.lbl_grade_visibility = new System.Windows.Forms.Label();
            this.btn_to_list = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_list = new System.Windows.Forms.ComboBox();
            this.cmb_trimester = new System.Windows.Forms.ComboBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToolStripMenuItem.Image")));
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.returnToolStripMenuItem.Text = "Volver";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_month);
            this.groupBox1.Controls.Add(this.lbl_month);
            this.groupBox1.Controls.Add(this.cmb_grade_visibility);
            this.groupBox1.Controls.Add(this.lbl_grade_visibility);
            this.groupBox1.Controls.Add(this.btn_to_list);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_list);
            this.groupBox1.Controls.Add(this.cmb_trimester);
            this.groupBox1.Controls.Add(this.cmb_year);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmb_month
            // 
            this.cmb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(564, 53);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(108, 21);
            this.cmb_month.TabIndex = 10;
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(528, 56);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(30, 13);
            this.lbl_month.TabIndex = 9;
            this.lbl_month.Text = "Mes:";
            // 
            // cmb_grade_visibility
            // 
            this.cmb_grade_visibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grade_visibility.FormattingEnabled = true;
            this.cmb_grade_visibility.Location = new System.Drawing.Point(161, 53);
            this.cmb_grade_visibility.Name = "cmb_grade_visibility";
            this.cmb_grade_visibility.Size = new System.Drawing.Size(292, 21);
            this.cmb_grade_visibility.TabIndex = 8;
            // 
            // lbl_grade_visibility
            // 
            this.lbl_grade_visibility.AutoSize = true;
            this.lbl_grade_visibility.Location = new System.Drawing.Point(53, 56);
            this.lbl_grade_visibility.Name = "lbl_grade_visibility";
            this.lbl_grade_visibility.Size = new System.Drawing.Size(102, 13);
            this.lbl_grade_visibility.TabIndex = 7;
            this.lbl_grade_visibility.Text = "Grado de visibilidad:";
            // 
            // btn_to_list
            // 
            this.btn_to_list.Location = new System.Drawing.Point(678, 21);
            this.btn_to_list.Name = "btn_to_list";
            this.btn_to_list.Size = new System.Drawing.Size(92, 23);
            this.btn_to_list.TabIndex = 6;
            this.btn_to_list.Text = "Listar";
            this.btn_to_list.UseVisualStyleBackColor = true;
            this.btn_to_list.Click += new System.EventHandler(this.btn_to_list_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trimestre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Año:";
            // 
            // cmb_list
            // 
            this.cmb_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_list.FormattingEnabled = true;
            this.cmb_list.Location = new System.Drawing.Point(327, 21);
            this.cmb_list.Name = "cmb_list";
            this.cmb_list.Size = new System.Drawing.Size(345, 21);
            this.cmb_list.TabIndex = 2;
            this.cmb_list.SelectedIndexChanged += new System.EventHandler(this.cmb_list_SelectedIndexChanged);
            // 
            // cmb_trimester
            // 
            this.cmb_trimester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_trimester.FormattingEnabled = true;
            this.cmb_trimester.Location = new System.Drawing.Point(221, 21);
            this.cmb_trimester.Name = "cmb_trimester";
            this.cmb_trimester.Size = new System.Drawing.Size(41, 21);
            this.cmb_trimester.TabIndex = 1;
            this.cmb_trimester.SelectedIndexChanged += new System.EventHandler(this.cmb_trimester_SelectedIndexChanged);
            // 
            // cmb_year
            // 
            this.cmb_year.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(88, 21);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(58, 21);
            this.cmb_year.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_list);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 281);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.AllowUserToResizeColumns = false;
            this.dgv_list.AllowUserToResizeRows = false;
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(56, 31);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowHeadersVisible = false;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(672, 227);
            this.dgv_list.TabIndex = 0;
            // 
            // FormStatiscalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 444);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormStatiscalList";
            this.Text = "Listado estadístico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_grade_visibility;
        private System.Windows.Forms.Label lbl_grade_visibility;
        private System.Windows.Forms.Button btn_to_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_list;
        private System.Windows.Forms.ComboBox cmb_trimester;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label lbl_month;
    }
}