using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using DAO;
using System.Configuration;

namespace PalcoNet.Editar_Publicacion
{
    public partial class EditPublication : Form
    {
        private String user;
        private Int32 idEmpresa;
        private static DateTime systemDate = Convert.ToDateTime(ConfigurationManager.AppSettings["FechaSistema"]);

        public EditPublication(String user, Int32 idEmpresa)
        {
            InitializeComponent();

            this.user = user;
            this.idEmpresa = idEmpresa;
            dtp_public_date.Value = systemDate; // dtp_public_date.MinDate = systemDate;
            dtp_date_to.Value = systemDate; //dtp_date_to.MinDate = systemDate;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_description.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_list.DataSource = PublicationConnection.ListPublication(txt_description.Text,dtp_public_date.Value, dtp_date_to.Value ,user).Tables[0];
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Int32 id = 0;

            try
            {

                id = Convert.ToInt32(dgv_list.CurrentRow.Cells[0].Value);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Debe seleccionar una fila válida para editar");
            }


            if (id != 0)
            {
                Generar_Publicacion.GeneratePublication form = new Generar_Publicacion.GeneratePublication(this,this.user, this.idEmpresa, id, true);
                this.Hide();
                form.ShowDialog();
            }

        }

        private void dtp_public_date_ValueChanged(object sender, EventArgs e)
        {
            dtp_date_to.MinDate = dtp_public_date.Value;
        }


    }
}
