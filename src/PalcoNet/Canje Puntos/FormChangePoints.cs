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
using System.Data.SqlClient;

namespace PalcoNet.Canje_Puntos
{
    public partial class FormChangePoints : Form
    {
        public int clientId { get; set; }
        public int userId { get; set; }
        public int points { get; set; }

        public FormChangePoints(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            this.clientId = ClientConnection.GetClientIdWithUserId(userId);
            txt_clientId.Text = Convert.ToString(this.clientId);

            this.points = setClientData(this.clientId);
            setChangeList(this.points);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int setClientData(int clientId)
        {
            SqlDataReader reader = ClientConnection.GetClientData(clientId);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_name.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    txt_surname.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    txt_email.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    txt_number_doc.Text = reader.IsDBNull(3) ? "" : reader.GetDecimal(3).ToString();
                    txt_points.Text = reader.IsDBNull(4) ? "" : reader.GetDecimal(4).ToString(); 

                }
            }

            reader.Close();
            return (Convert.ToInt32(txt_points.Text));
        }

        public void setChangeList(int points)
        {
            dgv_list.DataSource = ClientConnection.GetChangeList(points).Tables[0]; 
        }

        private void btn_exchange_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgv_list.SelectedRows.Count;

            if (selectedRowCount == 1)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                int rowIndex = dgv_list.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_list.Rows[rowIndex];
                string puntos = Convert.ToString(selectedRow.Cells["Puntos"].Value);           

                sb.Append("¿Desea canjear la ubicación "+Convert.ToString(selectedRow.Cells["ubicacion_tipo_descripcion"].Value+"?"));
                sb.Append(Environment.NewLine);

                if (Convert.ToInt32(selectedRow.Cells["ubicacion_sin_numerar"].Value) == 0)
                {
                    sb.Append("Fila:  " + Convert.ToString(selectedRow.Cells["ubicacion_fila"].Value));
                    sb.Append(Environment.NewLine);
                    sb.Append("Asiento:  " + Convert.ToString(selectedRow.Cells["ubicacion_asiento"].Value));
                    sb.Append(Environment.NewLine);
                }
                else
                {
                    sb.Append("Sin numerar");
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Espectáculo:  " + Convert.ToString(selectedRow.Cells["Espectaculo_Descripcion"].Value));
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append("Total puntos: " + puntos);
                
                DialogResult result = MessageBox.Show(sb.ToString(), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClientConnection.ChangePoints(  this.clientId, 
                                                    Convert.ToInt32(puntos), 
                                                    Convert.ToInt32(selectedRow.Cells["Publicacion_ID"].Value), 
                                                    Convert.ToInt32(selectedRow.Cells["Ubicacion_ID"].Value) );
                    
                    this.points = setClientData(this.clientId);
                    setChangeList(this.points);
                }

            }
            else
                MessageBox.Show("Debe seleccionar solo una fila");
        }

    }
}
