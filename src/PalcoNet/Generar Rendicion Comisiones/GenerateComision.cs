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
using System.Configuration;

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
            FacturaDAO factura = new FacturaDAO();
            List<ItemDAO> items = new List<ItemDAO>();
            Decimal total = 0;
            Decimal pago = 0;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ItemDAO item = new ItemDAO();

                Int32 precio = Convert.ToInt32(row["Precio"]); 
                Decimal comision = Convert.ToDecimal(row["Comision de compra"]); 
                item.Item_Monto = precio * comision;
                item.Item_Cantidad = 1;
                total += item.Item_Monto;
                pago = pago + (precio - item.Item_Monto);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.Append("Comisión por ");
                sb.Append(Convert.ToString(row["Espectáculo"])+" ");
                sb.Append("Ubicación: ");
                if (!Convert.ToBoolean(row["Sin Numerar"]))
                {
                    sb.Append(Convert.ToString(row["Tipo de Ubicación"]) + " ");
                    sb.Append("Fila: ");
                    sb.Append(Convert.ToString(row["Fila"]) + " ");
                    sb.Append("Asiento: ");
                    sb.Append(Convert.ToString(row["Asiento"]));
                }
                else
                {
                    sb.Append("Sin numerar");
                }

                item.Item_Descripcion = sb.ToString();
                item.Compra_ID = Convert.ToInt32(row["Id Compra"]); 
                	
                items.Add(item);

            }

            factura.Factura_Fecha = Convert.ToDateTime(ConfigurationManager.AppSettings["FechaSistema"]);
            factura.Factura_Total = total;
            factura.Factura_Empresa_ID = Convert.ToInt32(txt_id_empresa.Text);

            Int32 IDFactura = FacturaConnection.CreateFactura(factura);

            System.Text.StringBuilder info = new System.Text.StringBuilder();

            info.Append("Se generó la factura ID "+IDFactura);
            info.Append(Environment.NewLine);
            info.Append(Environment.NewLine);
            info.Append("Total Factura " + total);
            info.Append(Environment.NewLine);
            info.Append("Total a pagar a la empresa " + pago);
            info.Append(Environment.NewLine);
            info.Append("Se crearon " + items.Count + " items");
            MessageBox.Show(info.ToString(), "Información");

            foreach( ItemDAO item in items)
            {
                item.Factura_ID = IDFactura;
            }
            
            FacturaConnection.CreateItems(items);

            //Actualiza la pantalla
            this.ds = EmpresaConnection.ListComprasByEmpresa(Empresa.IdEmpresa, dtp_date.Value);
            dgv_list.DataSource = ds.Tables[0];
        }
    }
}
