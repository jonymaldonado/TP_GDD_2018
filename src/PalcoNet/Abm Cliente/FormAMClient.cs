using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public partial class FormAMClient : Form
    {
        Form formPrevious;

        public FormAMClient(FormClient formAMCliente)
        {
            InitializeComponent();
            this.formPrevious = formAMCliente;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrevious.Show();
            this.Close();
        }
    }

}
