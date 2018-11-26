using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Generar_Publicacion
{
    public partial class GeneratePublication : Form
    {
        private static BindingList<DateTime> batchDates = new BindingList<DateTime>();
        
        public GeneratePublication()
        {
            InitializeComponent();

            batchDates.Clear();
            lb_batch.DataSource = batchDates;

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_date_add_Click(object sender, EventArgs e)
        {
            batchDates.Add(dtp_date.Value);
                      
        }

        private void btn_date_remove_Click(object sender, EventArgs e)
        {

            if (lb_batch.SelectedIndex >= 0)
            {
                DateTime itemSelected = (DateTime)lb_batch.Items[lb_batch.SelectedIndex];
                batchDates.Remove(itemSelected);
            }
        }

        
    }
}
