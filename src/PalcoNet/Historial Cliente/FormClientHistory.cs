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

namespace PalcoNet.Historial_Cliente
{
    public partial class FormClientHistory : Form
    {
       
        public FormClientHistory(int roleId, int userId)
        {   
            InitializeComponent();
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
