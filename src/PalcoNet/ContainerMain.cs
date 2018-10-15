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
        ArrayList functions = new ArrayList();

        public ContainerMain(int id, String usuario, int roleId)
        {
            InitializeComponent();
            init(id, usuario, roleId);
        }

        public void init(int id, String usuario, int roleId)
        {

        }

        private void GetFunctionsIDs()
        {
            SqlDataReader reader = FunctionConnection.GetFunctionsIds(roleId);

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
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
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
    }

}
