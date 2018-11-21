namespace PalcoNet
{
    partial class ContainerMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.closeSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDegreeOfPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsGeneratePublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsEditPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsGeneratePayCommissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsExchangeAdminPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchRecordClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStatisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.aBMToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.listToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(578, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.closeSessionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(60, 20);
            this.fileMenu.Text = "&Archivo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(140, 6);
            // 
            // closeSessionToolStripMenuItem
            // 
            this.closeSessionToolStripMenuItem.Name = "closeSessionToolStripMenuItem";
            this.closeSessionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeSessionToolStripMenuItem.Text = "Cerrar Sesion";
            this.closeSessionToolStripMenuItem.Click += new System.EventHandler(this.closeSessionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMRoleToolStripMenuItem,
            this.aBMClientToolStripMenuItem,
            this.aBMCompanyToolStripMenuItem,
            this.aBMCategoryToolStripMenuItem,
            this.aBMDegreeOfPublicationToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "A&BM";
            // 
            // aBMRoleToolStripMenuItem
            // 
            this.aBMRoleToolStripMenuItem.Name = "aBMRoleToolStripMenuItem";
            this.aBMRoleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aBMRoleToolStripMenuItem.Text = "Rol";
            this.aBMRoleToolStripMenuItem.Click += new System.EventHandler(this.aBMRoleToolStripMenuItem_Click);
            // 
            // aBMClientToolStripMenuItem
            // 
            this.aBMClientToolStripMenuItem.Name = "aBMClientToolStripMenuItem";
            this.aBMClientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aBMClientToolStripMenuItem.Text = "Cliente";
            this.aBMClientToolStripMenuItem.Click += new System.EventHandler(this.aBMClientToolStripMenuItem_Click);
            // 
            // aBMCompanyToolStripMenuItem
            // 
            this.aBMCompanyToolStripMenuItem.Name = "aBMCompanyToolStripMenuItem";
            this.aBMCompanyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aBMCompanyToolStripMenuItem.Text = "Empresa";
            this.aBMCompanyToolStripMenuItem.Click += new System.EventHandler(this.aBMCompanyToolStripMenuItem_Click);
            // 
            // aBMCategoryToolStripMenuItem
            // 
            this.aBMCategoryToolStripMenuItem.Name = "aBMCategoryToolStripMenuItem";
            this.aBMCategoryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aBMCategoryToolStripMenuItem.Text = "Categoría";
            // 
            // aBMDegreeOfPublicationToolStripMenuItem
            // 
            this.aBMDegreeOfPublicationToolStripMenuItem.Name = "aBMDegreeOfPublicationToolStripMenuItem";
            this.aBMDegreeOfPublicationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aBMDegreeOfPublicationToolStripMenuItem.Text = "Grado de publicación";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsGeneratePublicationToolStripMenuItem,
            this.actionsEditPublicationToolStripMenuItem,
            this.actionsBuyToolStripMenuItem,
            this.actionsGeneratePayCommissionsToolStripMenuItem,
            this.actionsExchangeAdminPointsToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.actionsToolStripMenuItem.Text = "A&cciones";
            // 
            // actionsGeneratePublicationToolStripMenuItem
            // 
            this.actionsGeneratePublicationToolStripMenuItem.Name = "actionsGeneratePublicationToolStripMenuItem";
            this.actionsGeneratePublicationToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.actionsGeneratePublicationToolStripMenuItem.Text = "Generar publicación";
            // 
            // actionsEditPublicationToolStripMenuItem
            // 
            this.actionsEditPublicationToolStripMenuItem.Name = "actionsEditPublicationToolStripMenuItem";
            this.actionsEditPublicationToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.actionsEditPublicationToolStripMenuItem.Text = "Editar publicación";
            // 
            // actionsBuyToolStripMenuItem
            // 
            this.actionsBuyToolStripMenuItem.Name = "actionsBuyToolStripMenuItem";
            this.actionsBuyToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.actionsBuyToolStripMenuItem.Text = "Comprar";
            // 
            // actionsGeneratePayCommissionsToolStripMenuItem
            // 
            this.actionsGeneratePayCommissionsToolStripMenuItem.Name = "actionsGeneratePayCommissionsToolStripMenuItem";
            this.actionsGeneratePayCommissionsToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.actionsGeneratePayCommissionsToolStripMenuItem.Text = "Generar pago de comisiones";
            // 
            // actionsExchangeAdminPointsToolStripMenuItem
            // 
            this.actionsExchangeAdminPointsToolStripMenuItem.Name = "actionsExchangeAdminPointsToolStripMenuItem";
            this.actionsExchangeAdminPointsToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.actionsExchangeAdminPointsToolStripMenuItem.Text = "Canje y administración de puntos";
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchRecordClientToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.watchToolStripMenuItem.Text = "Ver";
            // 
            // watchRecordClientToolStripMenuItem
            // 
            this.watchRecordClientToolStripMenuItem.Name = "watchRecordClientToolStripMenuItem";
            this.watchRecordClientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.watchRecordClientToolStripMenuItem.Text = "Historial del cliente";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listStatisticalToolStripMenuItem});
            this.listToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listToolStripMenuItem.Image")));
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.listToolStripMenuItem.Text = "&Listado";
            // 
            // listStatisticalToolStripMenuItem
            // 
            this.listStatisticalToolStripMenuItem.Name = "listStatisticalToolStripMenuItem";
            this.listStatisticalToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.listStatisticalToolStripMenuItem.Text = "Estadístico";
            // 
            // ContainerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 261);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "ContainerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA - PalcoNet";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem closeSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMDegreeOfPublicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsGeneratePublicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsEditPublicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchRecordClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStatisticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsGeneratePayCommissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsExchangeAdminPointsToolStripMenuItem;
    }
}

