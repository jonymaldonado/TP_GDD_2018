using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace PalcoNet
{
    public partial class ContainerMain : Form
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public String user { get; set; }

        public const int ADMINISTRATOR = 3;
        ArrayList functions = new ArrayList();

        public ContainerMain(int id, String usuario, int roleId)
        {
            InitializeComponent();
            init(id, usuario, roleId);
        }

        public void init(int id, String user, int roleId)
        {
            this.id = id;
            this.roleId = roleId;
            this.user = user;
            this.aBMToolStripMenuItem.Available = false;
            this.aBMRoleToolStripMenuItem.Available = false;
            this.aBMClientToolStripMenuItem.Available = false;
            this.aBMCompanyToolStripMenuItem.Available = false;
            this.aBMCategoryToolStripMenuItem.Available = false;
            this.aBMDegreeOfPublicationToolStripMenuItem.Available = false;
            this.actionsToolStripMenuItem.Available = false;
            this.actionsGeneratePublicationToolStripMenuItem.Available = false;
            this.actionsEditPublicationToolStripMenuItem.Available = false;
            this.actionsBuyToolStripMenuItem.Available = false;
            this.actionsGeneratePayCommissionsToolStripMenuItem.Available = false;
            this.actionsExchangeAdminPointsToolStripMenuItem.Available = false;
            this.watchToolStripMenuItem.Available = false;
            this.watchRecordClientToolStripMenuItem.Available = false;
            this.listToolStripMenuItem.Available = false;
            this.listStatisticalToolStripMenuItem.Available = false;
            this.administraciónDeUsuariosToolStripMenuItem.Available = false;
            this.cambiarPasswordToolStripMenuItem.Available = false;
            ChangeMenu(roleId);
        }

        private void GetFunctionsIDs()
        {
            SqlDataReader reader = FunctionConnection.GetFunctionsIds(this.roleId);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.functions.Add(reader.GetInt32(0));
                }
            }

            reader.Close();
        }

        private void ChangeMenu(int roleId)
        {
            functions.Clear();
            GetFunctionsIDs();

            foreach (int i in this.functions)
            {
                switch (i)
                {
                    case 1:
                        this.aBMToolStripMenuItem.Available = true;
                        this.aBMRoleToolStripMenuItem.Available = true;
                        break;

                    case 2:
                        this.aBMToolStripMenuItem.Available = true;
                        this.aBMClientToolStripMenuItem.Available = true;
                        break;

                    case 3:
                        this.aBMToolStripMenuItem.Available = true;
                        this.aBMCompanyToolStripMenuItem.Available = true;
                        break;

                    case 4:
                        this.aBMToolStripMenuItem.Available = true;
                        this.aBMCategoryToolStripMenuItem.Available = true;
                        break;

                    case 5:
                        this.aBMToolStripMenuItem.Available = true;
                        this.aBMDegreeOfPublicationToolStripMenuItem.Available = true;
                        break;

                    case 6:
                        this.actionsToolStripMenuItem.Available = true;
                        this.actionsGeneratePublicationToolStripMenuItem.Available = true;
                        break;

                    case 7:
                        this.actionsToolStripMenuItem.Available = true;
                        this.actionsEditPublicationToolStripMenuItem.Available = true;
                        break;

                    case 8:
                        this.actionsToolStripMenuItem.Available = true;
                        this.actionsBuyToolStripMenuItem.Available = true;
                        break;

                    case 9:
                        this.watchToolStripMenuItem.Available = true;
                        this.watchRecordClientToolStripMenuItem.Available = true;
                        break;

                    case 10:
                        this.actionsToolStripMenuItem.Available = true;
                        this.actionsExchangeAdminPointsToolStripMenuItem.Available = true;
                        break;

                    case 11:
                        this.actionsToolStripMenuItem.Available = true;
                        this.actionsGeneratePayCommissionsToolStripMenuItem.Available = true;
                        break;

                    case 12:
                        this.listToolStripMenuItem.Available = true;
                        this.listStatisticalToolStripMenuItem.Available = true;
                        break;

                    case 13:
                        this.actionsToolStripMenuItem.Available = true;
                        this.administraciónDeUsuariosToolStripMenuItem.Available = true;
                        break;
                    case 14:
                        this.fileMenu.Available = true;
                        this.cambiarPasswordToolStripMenuItem.Available = true;
                        break;

                    default: break;
                }
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login.Login fr = new Login.Login(this);
            //fr.Show();
            openForm(new Login.Login(this));
            
        }

        private void aBMRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Abm_Rol.FormRole());
        }

        private void aBMClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Abm_Cliente.FormClient());
        }

        private void openForm(Form fr)
        {
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void aBMCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Abm_Empresa_Espectaculo.FormEmpresa());
        }

        private void aBMDegreeOfPublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Abm_Grado.FormGrado());
        }

        private void watchRecordClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idCliente = 0;

            idCliente = Connection.queryForInt("SELECT Cliente_ID FROM EL_GROUP_BY.Cliente WHERE Usuario_ID =" + this.id);

            if (idCliente != 0)
                openForm(new Historial_Cliente.FormClientHistory(this.id, false, idCliente));
            else
                openForm(new Historial_Cliente.FormClientHistory(this.id, true,0));
        }

        private void actionsExchangeAdminPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idCliente = 0;

            idCliente = Connection.queryForInt("SELECT Cliente_ID FROM EL_GROUP_BY.Cliente WHERE Usuario_ID =" + this.id);

            if (idCliente != 0)
                openForm(new Canje_Puntos.FormChangePoints(this.id));
            else
                MessageBox.Show("No puede canjear puntos si el Usuario no tiene asignado un Cliente", "Error");

        }

        private void listStatisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Listado_Estadistico.FormStatiscalList());
        }

        private void aBMCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //No implementar ABM rubro está en la consigna y en el grupo google se comentó que redireccione a Form vacío
            openForm(new Abm_Rubro.Form1());
        }

        private void actionsGeneratePublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idEmpresa = 0;
            
            idEmpresa = Connection.queryForInt("SELECT Empresa_ID FROM EL_GROUP_BY.Empresa WHERE Usuario_ID ="+this.id);

            if (idEmpresa != 0)
                openForm(new Generar_Publicacion.GeneratePublication(this, this.user, idEmpresa, 0, false));
            else
                MessageBox.Show("No puede generar publicación si el usuario no tiene asignada una Empresa de espectáculos","Error");

        }

        private void actionsEditPublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idEmpresa = 0;

            idEmpresa = Connection.queryForInt("SELECT Empresa_ID FROM EL_GROUP_BY.Empresa WHERE Usuario_ID =" + this.id);

            if (idEmpresa != 0)
                openForm(new Editar_Publicacion.EditPublication(this.user, idEmpresa));
            else
                MessageBox.Show("No puede editar una publicación si el usuario no tiene asignada una Empresa de espectáculos", "Error");

        }

        private void actionsBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idCliente = 0;
            
            idCliente = Connection.queryForInt("SELECT Cliente_ID FROM EL_GROUP_BY.Cliente WHERE Usuario_ID =" + this.id);

            if (idCliente != 0)
                openForm(new Comprar.FormToBuy(idCliente));
            else
                MessageBox.Show("No puede comprar si el Usuario no tiene asignado un Cliente" , "Error");
        }

        private void actionsGeneratePayCommissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Generar_Rendicion_Comisiones.GenerateComision());
        }

        private void administraciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Administracion_de_Usuarios.UserAdmin());
        }

        private void cambiarPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Registro_de_Usuario.FormChangePassword(this.id, this.user));
        }
    }

}
