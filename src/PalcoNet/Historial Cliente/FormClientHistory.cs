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

namespace PalcoNet.Historial_Cliente
{
    public partial class FormClientHistory : Form
    {
        public int clientId { get; set; }
        public int userId { get; set; }

        public FormClientHistory(int userId)
        {
            InitializeComponent();
            
            this.userId = userId;
            this.clientId = ClientConnection.GetClientIdWithUserId(userId);
            txt_clientId.Text = Convert.ToString(this.clientId);

            setClientData(this.clientId);
            setHistoryData(this.clientId);
            
        }

        private void setClientData(int clientId)
        {
            SqlDataReader reader = ClientConnection.GetClientData(clientId);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_name.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    txt_surname.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    txt_email.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    txt_number_doc.Text = reader.IsDBNull(3) ? "" : reader.GetDecimal(3).ToString(); ;
                    
                }
            }

            reader.Close();
        }

        private void setHistoryData(int clientId)
        {
            dgv_list.DataSource = ClientConnection.GetHistoryDataByClient(clientId).Tables[0];
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_client_Click(object sender, EventArgs e)
        {

            Abm_Cliente.FormClient FormClient = new PalcoNet.Abm_Cliente.FormClient();

            this.Hide();
            FormClient.ShowDialog();
            this.Show();            

        }

    }
}
