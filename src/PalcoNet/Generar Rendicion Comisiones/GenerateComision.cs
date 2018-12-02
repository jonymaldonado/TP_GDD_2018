using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using MyLibrary;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class GenerateComision : Form
    {
        public EmpresaDAO Empresa = new EmpresaDAO();
        public DataSet ds = new DataSet();

        public Int32 IdEmpresa
        {
            set
            {
                txt_id_empresa.Text = Convert.ToString(value);
                Empresa.IdEmpresa = value;
            }
        }

        public String RazonSocial
        {
            set
            {
                txt_razon_social.Text = value;
                Empresa.RazonSocial = value;
            }
        }

        public String Cuit
        {
            set
            {
                txt_cuit.Text = value;
                Empresa.Cuit = value;
            }
        }

        public String Email
        {
            set
            {
                txt_email.Text = value;
                Empresa.Email = value;
            }
        }


        public GenerateComision()
        {
            InitializeComponent();
            txt_cuit.Text = Empresa.Cuit;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            using (Abm_Empresa_Espectaculo.FormEmpresa FormEmpresa = new Abm_Empresa_Espectaculo.FormEmpresa(this))
            {
                FormEmpresa.ShowDialog();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.ds = EmpresaConnection.ListComprasByEmpresa(Empresa.IdEmpresa, dtp_date.Value);

            dgv_list.DataSource = ds.Tables[0];
            dgv_list.Columns["Publicacion_ID"].Visible = false;
            dgv_list.Columns["Ubicacion_ID"].Visible = false;
            dgv_list.Columns["Grado_Publicacion_ID"].Visible = false;
        }

        private void btn_rendir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_id_empresa.Text))
                MessageBox.Show("Debe seleccionar una empresa", "Advertencia");
            else if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("No se encontraron compras para rendir", "Advertencia");
            else
            {
                RendirCompras();
            }
        }

        private void RendirCompras()
        {

        }
    }
}
